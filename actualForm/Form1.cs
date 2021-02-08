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
            MySqlDataReader reader = client.exec(
                connection, 
                "SELECT name FROM test"
                );
            if (reader == null)
            {
                Console.WriteLine("Couldn't execute this SQL query");
                return;
            }
            while (reader.Read())
            {
                Console.WriteLine(">>>>>>>>>>> TEST");
                Console.WriteLine(reader.GetString(0));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
