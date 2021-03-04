using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace actualForm
{

    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
            MySqlClient client = new MySqlClient();
            MySqlConnection connection = client.connect();
            if (connection == null)
            {
                Console.WriteLine("Couldn't connect to the database.");
                return;
            }
            preInit(connection, client);
            //preInit(connection, client);
            // DeviceInfo.add("name", "type", "desc");
            // User.add("firstname", "lastname", 123, "class");
            // Lendings.add(1, 1);
            //init(connection, client);
            //makeTextBox();
        }

        static void preInit(MySqlConnection connection, MySqlClient client)
        {
            client.exec( /// device info
                connection,
                "CREATE table IF NOT EXISTS device_info (" +
                "deviceId INT NOT NULL AUTO_INCREMENT, " +
                "name VARCHAR(50) NOT NULL, " +
                "type VARCHAR(25) NOT NULL, " +
                "description TEXT, " +
                "isDeleted boolean NOT NULL DEFAULT false, " +
                "PRIMARY KEY(deviceId)" +
                ")"
                );
            connection.Close();
            connection.Open();
            client.exec( /// user info
                connection,
                "CREATE table IF NOT EXISTS user (" +
                "userId INT NOT NULL AUTO_INCREMENT, " +
                "firstName VARCHAR(20) NOT NULL, " +
                "lastName VARCHAR(20) NOT NULL, " +
                "studentId INT(6) NOT NULL, " +
                "class VARCHAR(10), " +
                "PRIMARY KEY(userId)" +
                ")"
                );
            connection.Close();
            connection.Open();
            client.exec( /// lendings
                connection,
                "CREATE table IF NOT EXISTS lendings (" +
                "lendingId INT NOT NULL AUTO_INCREMENT, " +
                "deviceId INT NOT NULL, " +
                "last_updated DATETIME NOT NULL, " +
                "userId INT NOT NULL, " +
                "isActive boolean NOT NULL, " +
                "PRIMARY KEY(lendingId), " +
                "FOREIGN KEY(deviceId) REFERENCES device_info(deviceId), " +
                "FOREIGN KEY(userId) REFERENCES user(userId)" +
                ")"
                );
            connection.Close();
            connection.Open();
            client.exec( /// returns
                connection,
                "CREATE table IF NOT EXISTS returns (" +
                "ID INT NOT NULL AUTO_INCREMENT, " +
                "deviceId INT NOT NULL, " +
                "userId INT NOT NULL, " +
                "lendingId INT NOT NULL, " +
                "description VARCHAR(200), " +
                "PRIMARY KEY(ID), " +
                "FOREIGN KEY(deviceId) REFERENCES device_info(deviceId), " +
                "FOREIGN KEY(userId) REFERENCES user(userId), " +
                "FOREIGN KEY(lendingId) REFERENCES lendings(lendingId)" +
                ")"
                );
            connection.Close();
        }

        private void handleError(string errorMessage)
        {
            ErrorMessage.Text = errorMessage;
            ErrorPanel.BringToFront();
            ErrorPanel.Visible = true;
        }

        private void AddDevice(object sender, EventArgs e)
        {
            /*if (
                AddScreenPanel.Visible ||
                LendingScreenPanel.Visible ||
                ReturnScreenPanel.Visible ||
                EditScreenDevice.Visible
                )*/
            AddScreenPanel.Visible = true;

        }

        private void loadDevices(string textToFind = "", bool custom = false)
        {
            listViewDevices.Items.Clear();
            MySqlDataReader reader = DeviceInfo.readAll();
            if (reader == null)
            {
                Console.WriteLine("reader is null.");
                return;
            }
            while (reader.Read())
            {
                Boolean checker = Lendings.isActive(reader.GetInt16(0));
                //Boolean isActive = Lendings.isActive(reader.GetInt16(0));

                //lvi.Tag = Devices;
                string LvStatus = string.Empty;
                if (checker == true)
                {
                    LvStatus = "uitgeleent";

                }
                else
                {
                    LvStatus = "uitleenbaar";

                }
                if (!reader.GetString(1).StartsWith(textToFind) && custom)
                {
                    continue;
                }
                var row = new string[] { reader.GetString(1), reader.GetString(2), LvStatus, reader.GetString(3), reader.GetString(0) }; // adding the item to the list. 
                var lvi = new ListViewItem(row);
                listViewDevices.Items.Add(lvi);
            }
        }

        private bool ValiDateDevice(string name, string type, string desc)
        {
            string patternName = @"^[a-zA-Z]{1,50}$";
            Regex regName = new Regex(patternName);
            string patternType = @"^[a-zA-Z0-9]{1,25}$";
            Regex regType = new Regex(patternType);
            string patternDesc = @"^[a-zA-Z0-9!?#\s]{1,500}$";
            Regex regDesc = new Regex(patternDesc);
            if (!regName.Match(name).Success)
            {
                handleError("A name may only include letters. And can have a length between 1 and 50 characters.");
                return false;
            }
            if (!regType.Match(type).Success)
            {
                handleError("A type may only include numbers and letters. And can have a length between 1 and 25 characters.");
                return false;
            }
            if (desc != null && desc.Length > 0 && !regDesc.Match(desc).Success)
            {
                handleError("A description may not include special characters. And may not have more than 500 characters.");
                return false;
            }

            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadDevices();
        }

        private void listViewDevices_CLICK(object sender, EventArgs e)
        {
            
            var item = listViewDevices.SelectedItems[0];
            //int itemId = int.Parse(item.SubItems[4].Text);
            bool isLend = item.SubItems[2].Text == "uitgeleent";
            if (isLend)
            {
                ReturnScreenPanel.Visible = true;

            } else
            {
                EditScreenLendOutButton.Visible = !isLend;
                EditScreenDevice.Visible = true;
                EditScreenDeviceName.Text = item.SubItems[0].Text;
                EditScreenDeviceType.Text = item.SubItems[1].Text;
                EditScreenDeviceDescription.Text = item.SubItems[3].Text;
            }
        }

        private void AddScreenCancel_Click(object sender, EventArgs e)
        {
            AddScreenName.Text = null;
            AddScreenDescription.Text = null;
            AddScreenType.Text = null;
            AddScreenPanel.Visible = false;
            loadDevices();
        }

        private void EditScreenDeviceCancelButton_Click(object sender, EventArgs e)
        {
            EditScreenDeviceDescription.Text = null;
            EditScreenDeviceName.Text = null;
            EditScreenDeviceType.Text = null;
            EditScreenDevice.Visible = false;
            loadDevices();
        }

        private void EditScreenDeviceDeleteButton_Click(object sender, EventArgs e)
        {
            var item = listViewDevices.SelectedItems[0];

            int IdDelete = int.Parse(item.SubItems[4].Text);
            DeviceInfo.deleteId(IdDelete);
            EditScreenDevice.Visible = false;
            loadDevices();
        }

        private void EditScreenDeviceSaveButton_Click(object sender, EventArgs e)
        {
            // SAVE AN EDITED DEVICE.
            var item = listViewDevices.SelectedItems[0];

            int id = int.Parse(item.SubItems[4].Text);
            string name = EditScreenDeviceName.Text;
            string type = EditScreenDeviceType.Text;
            string desc = EditScreenDeviceDescription.Text;
            if (!ValiDateDevice(name, type, desc))
            {
                return;
            }

            DeviceInfo.update(id, name, type, desc);
            EditScreenDevice.Visible = false;
            loadDevices();

        }

        private void EditScreenDeviceLendOut_Click(object sender, EventArgs e)
        {
            EditScreenDevice.Visible = false;
            LendingScreenPanel.Visible = true;
        }

        private void AddScreenSave_Click(object sender, EventArgs e)
        {
            // SAVE A NEW DEVICE.
            // handle all data and insert into db.
            string name = AddScreenName.Text;
            string type = AddScreenType.Text;
            string desc = AddScreenDescription.Text;
            if (!ValiDateDevice(name, type, desc))
            {
                return;
            }

            DeviceInfo.add(name, type, desc);
            AddScreenCancel_Click(sender, e);
        }

        private void ReturnScreenEditLendingButton_Click(object sender, EventArgs e)
        {
            // EDITING A LENDING
            ReturnScreenPanel.Visible = false;
            LendingScreenPanel.Visible = true;
        }

        private void ReturnScreenEditDeviceButton_Click(object sender, EventArgs e)
        {
            // EDITING A DEVICE
            ReturnScreenPanel.Visible = false;
            var item = listViewDevices.SelectedItems[0];
            bool isLendOut = item.SubItems[2].Text == "uitgeleent";
            EditScreenLendOutButton.Visible = !isLendOut;
            EditScreenDevice.Visible = true;
            EditScreenDeviceName.Text = item.SubItems[0].Text;
            EditScreenDeviceType.Text = item.SubItems[1].Text;
            EditScreenDeviceDescription.Text = item.SubItems[3].Text;
        }

        private void ReturnScreenCancelButton_Click(object sender, EventArgs e)
        {
            ReturnScreenPanel.Visible = false;
        }

        private void ReturnScreenReturnButton_Click(object sender, EventArgs e)
        {
            // RETURNING A DEVICE
            var item = listViewDevices.SelectedItems[0];

            int id = int.Parse(item.SubItems[4].Text);
            string returnDesc = returnBescrijving.Text;
            Lendings.delete(id, returnDesc);
            ReturnScreenPanel.Visible = false;
            loadDevices();
        }

        private void LendingScreenCancelButton_Click(object sender, EventArgs e)
        {
            // LENDING CANCEL BUTTON
            LendingScreenPanel.Visible = false;
        }

        private void LendingScreenSaveButton_Click(object sender, EventArgs e)
        {
            // LENDING SAVE BUTTON
            // idk where the button is to go to this screen actually, lol.
            string errMessage = string.Empty;
            Regex regFName = new Regex(@"^[A-Z][a-z]{2,20}$");
            Regex regLName = new Regex(@"^[A-Z][a-z]{2,20}$");
            Regex regStudentNum = new Regex(@"^[0-9]{6,10}$");
            Regex regClass = new Regex(@"^[a-zA-Z0-9]{6,10}$");
            if (!regFName.Match(LendingScreenFirstName.Text).Success)
            {
                errMessage += "First name can only contain letters and starts with a captial letter and needs to have 2 - 20 letters.\n\n";
            } 
            if (!regLName.Match(LendingScreenLastName.Text).Success)
            {
                errMessage += "Last name can only contain letters and starts with a captial letter and needs to have 2 - 20 letters.\n\n";
            }
            if (!regStudentNum.Match(LendingScreenStudentNum.Text).Success)
            {
                errMessage += "Sudent ID can only contain numbers and can have a length between 6 - 10.\n\n";
            }
            if (LendingScreenClass.Text.Length > 0 && !regClass.Match(LendingScreenClass.Text).Success)
            {
                errMessage += "Class can only contain letters and numbers and can have a length between 6 - 10.";
            }
            if (errMessage.EndsWith("\n\n"))
            {
                errMessage = errMessage.Substring(0, errMessage.Length - 4);
            }
            if (errMessage.Length > 0)
            {
                handleError(errMessage);
                return;
            }
            int userId = User.add(LendingScreenFirstName.Text, LendingScreenLastName.Text, int.Parse(LendingScreenStudentNum.Text), LendingScreenClass.Text);
            if (userId == -1)
            {
                handleError("Something went wrong, try again later!");
                return;
            }
            var item = listViewDevices.SelectedItems[0];

            int id = int.Parse(item.SubItems[4].Text);
            Lendings.add(id, userId);
            LendingScreenPanel.Visible = false;
            ReturnScreenPanel.Visible = false;
            loadDevices();
            
        }

        private void ErrorButton_Click(object sender, EventArgs e)
        {
            ErrorPanel.SendToBack();
            ErrorPanel.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string itemSearhing = searchBox.Text;
            ListView listView = listViewDevices;
            if (itemSearhing == null || itemSearhing == "" || listView.Items.Count == 0)
            {
                loadDevices();
                return;
            }
            // listView.Items.Find(itemSearhing, true);
            listView.FindItemWithText(itemSearhing);
            ListViewItem searchQuery = listView.FindItemWithText(itemSearhing);
            if (searchQuery != null)
            {
                loadDevices(itemSearhing, true);
            }
        }
    }
}
