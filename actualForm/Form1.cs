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
        }

        static void init(MySqlConnection connection, MySqlClient client)
        {
            client.exec(
                connection,
                "CREATE table IF NOT EXISTS device_info (deviceId INT NOT NULL AUTO_INCREMENT, name VARCHAR(50) NOT NULL, type VARCHAR(25) NOT NULL, description TEXT NOT NULL, PRIMARY KEY(deviceId))"
                );
            connection.Close();
            connection.Open();
            client.exec(
                connection,
                "CREATE table IF NOT EXISTS user (userId INT NOT NULL AUTO_INCREMENT, firstName VARCHAR(20) NOT NULL, lastName VARCHAR(20) NOT NULL, class VARCHAR(10), PRIMARY KEY(userId))"
                );
            connection.Close();
            connection.Open();
            client.exec(
                connection,
                "CREATE table IF NOT EXISTS lendings (lendingId INT NOT NULL AUTO_INCREMENT, deviceId INT NOT NULL, last_updated DATETIME NOT NULL, userId INT NOT NULL, PRIMARY KEY(lendingId), FOREIGN KEY(deviceId) REFERENCES device_info(deviceId), FOREIGN KEY(userId) REFERENCES user(userId))"
                );
            connection.Close();
            connection.Open();
            client.exec(
                connection,
                "CREATE table IF NOT EXISTS returns (ID INT NOT NULL AUTO_INCREMENT, deviceId INT NOT NULL, userId INT NOT NULL, lendingId INT NOT NULL, description VARCHAR(200), PRIMARY KEY(ID), FOREIGN KEY(deviceId) REFERENCES device_info(deviceId), FOREIGN KEY(userId) REFERENCES user(userId), FOREIGN KEY(lendingId) REFERENCES lendings(lendingId))"
                );
            connection.Close();
        }

        static void addDivce(string name, string type, string description)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
