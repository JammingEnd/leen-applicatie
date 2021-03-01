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
                "description TEXT NOT NULL, " +
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

        static void init(MySqlConnection connection, MySqlClient client)
        {
            MySqlDataReader reader = DeviceInfo.readAll();
            if (reader == null)
            {
                Console.WriteLine("reader is null.");
                return;
            }
            while (reader.Read())
            {​​
                string lvName = reader.GetString(1);
                string lvType = reader.GetString(2);
                return;
            }
           // MySqlDataReader readerLend = 
            }

        static void makeTextBox()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { 
         
            var showDevices = GetDevices();
            foreach(var Devices in showDevices)
            {
                var row = new string[] { Devices.name, Devices.type, Devices.status, Devices.remark };
                var lvi = new ListViewItem(row);

                lvi.Tag = Devices;

                listViewDevices.Items.Add(lvi);
            }
        }

        private List<Devices> GetDevices()
        {
            var list = new List<Devices>();
            list.Add(new Devices() { name = LvName.ToString(), type = LvType.ToString(), status = "uitgeleent", remark = null }); ; ;

            return list;


        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }


        // volgens mij is er een verschil tussen schetsen en database locaties
        /*  static void lendDevice(string name, string type, string description)
          {
              MySqlClient client = new MySqlClient();
              MySqlConnection connection = client.connect();
              client.exec(
                  connection,
                  $"INSERT INTO device_info (name, type, description) VALUES ({name},{type},{description});"
                  );
          }
        */











    }
}
