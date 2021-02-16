using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            init(connection, client);
            addPanel.Visible = false;
        }

        static void init(MySqlConnection connection, MySqlClient client)
        {
            client.exec( /// device info
                /**
                 * deviceId INT
                 * name VARCHAR(50)
                 * type VARCHAR(25)
                 * description TEXT
                 */
                connection,
                "CREATE table IF NOT EXISTS device_info (deviceId INT NOT NULL AUTO_INCREMENT, name VARCHAR(50) NOT NULL, type VARCHAR(25) NOT NULL, description TEXT NOT NULL, PRIMARY KEY(deviceId))"
                );
            connection.Close();
            connection.Open();
            client.exec( /// user info
                connection,
                "CREATE table IF NOT EXISTS user (userId INT NOT NULL AUTO_INCREMENT, firstName VARCHAR(20) NOT NULL, lastName VARCHAR(20) NOT NULL, class VARCHAR(10), PRIMARY KEY(userId))"
                );
            connection.Close();
            connection.Open();
            client.exec( /// lendings
                connection,
                "CREATE table IF NOT EXISTS lendings (lendingId INT NOT NULL AUTO_INCREMENT, deviceId INT NOT NULL, last_updated DATETIME NOT NULL, userId INT NOT NULL, PRIMARY KEY(lendingId), FOREIGN KEY(deviceId) REFERENCES device_info(deviceId), FOREIGN KEY(userId) REFERENCES user(userId))"
                );
            connection.Close();
            connection.Open();
            client.exec( /// returns
                connection,
                "CREATE table IF NOT EXISTS returns (ID INT NOT NULL AUTO_INCREMENT, deviceId INT NOT NULL, userId INT NOT NULL, lendingId INT NOT NULL, description VARCHAR(200), PRIMARY KEY(ID), FOREIGN KEY(deviceId) REFERENCES device_info(deviceId), FOREIGN KEY(userId) REFERENCES user(userId), FOREIGN KEY(lendingId) REFERENCES lendings(lendingId))"
                );
            connection.Close();
        }

        static void addDivce(string name, string type, string description)
        {
            MySqlClient client = new MySqlClient();
            MySqlConnection connection = client.connect();
            client.exec(
                connection,
                $"INSERT INTO device_info (name, type, description) VALUES ({name},{type},{description});"
                );
        }
        
       
        
           

           
        
        private void button2_Click(object sender, EventArgs e) //add button
        {
           if(addPanel.Visible == false)
            {
                addPanel.Visible = true;
            }
            else
            {
                addPanel.Visible = false;
            }

  
        }

        private void addNameTextbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void addStudentnumTextbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void addStudentnumTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);  //only number textbox. doesnt prevent copy/paste text
        }

        private void addUitleenButton_Click(object sender, EventArgs e)
        {
            //send uitleenData to quary 
            // uitleen info
            string leenName = addNameTextbox.Text;
            float studentNumber = Convert.ToInt32(addStudentnumTextbox.Text);
            DateTime uitleenDate = uitleenPicker.Value;
            DateTime retourDate = retourPicker.Value;

          
       
        }

        private void addApparaatButton_Click(object sender, EventArgs e)
        {
            //apparaat toevoegen info
            string deviceName = addApparaatNaamTextbox.Text;
            string deviceType = addTypeApparaatTextbox.Text;
            string description = addOmschrijvingTextbox.Text;


            addDivce(deviceName, deviceType, description);
        }
    }
}
