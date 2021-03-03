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
            Console.WriteLine("Executing this");
            ErrorMessage.Text = errorMessage;
            ErrorPanel.BringToFront();
            ErrorPanel.Visible = true;
        }

        private void AddDevice(object sender, EventArgs e)
        {
            AddScreenPanel.Visible = true;
        }

        private void loadDevices()
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

                var row = new string[] { reader.GetString(1), reader.GetString(2), LvStatus, null, reader.GetString(0) }; // adding the item to the list. 
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
            string patternDesc = @"^[a-zA-Z0-9!?#]{1,500}$";
            Regex regDesc = new Regex(patternDesc);
            Console.WriteLine(regName.Match(name).Success);
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
            Console.WriteLine(item.SubItems[2].Text);
            bool isLend = item.SubItems[2].Text == "uitgeleent";
            Console.WriteLine(isLend.ToString());
            if (isLend)
            {
                ReturnScreenPanel.Visible = true;
            } else
            {
                EditScreenDevice.Visible = true;
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
            ListViewItem itemId = listViewDevices.SelectedItems[0];

            int IdDelete = Convert.ToInt16(itemId.SubItems[4].Text);
            // DeviceInfo.deleteId(IdDelete);
            Console.WriteLine(IdDelete);
        }

        private void EditScreenDeviceSaveButton_Click(object sender, EventArgs e)
        {
            // SAVE AN EDITED DEVICE.
            string itemIdString = listViewDevices.SelectedItems[0].SubItems[4].Text;
            int itemId = int.Parse(itemIdString);
            Console.WriteLine(itemId);
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
            EditScreenDevice.Visible = true;
        }

        private void ReturnScreenCancelButton_Click(object sender, EventArgs e)
        {
            ReturnScreenPanel.Visible = false;
        }

        private void ReturnScreenReturnButton_Click(object sender, EventArgs e)
        {
            // RETURNING A DEVICE
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
                errMessage += "First name can only contain letters and starts with a captial letter and needs to have 2 - 20 letters.\n\n";
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

            //TODO saving.
        }

        private void ErrorButton_Click(object sender, EventArgs e)
        {
            ErrorPanel.SendToBack();
            ErrorPanel.Visible = false;
        }
    }
}
