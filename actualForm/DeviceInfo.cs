using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actualForm
{
    class DeviceInfo
    {
        private static MySqlClient client = new MySqlClient();
        private static MySqlConnection connection = client.connect();
        private static MySqlConnection GetConnection()
        {
            return client.connect();
        }
        public static void add(string name, string type, string description)
        {
            client.exec(
                connection,
                $"INSERT INTO device_info (name, type, description) VALUES (\"{name}\",\"{type}\",\"{description}\");"
                );
            connection.Close();
        }

        public static void setName(int id, string name)
        {
            client.exec(
                connection,
                $"UPDATE device_info SET name = \"{name}\" WHERE deviceId = \"{id}\";"
                );
            connection.Close();
        }

        public static void setType(int id, string type)
        {
            client.exec(
                connection,
                $"UPDATE device_info SET type = \"{type}\" WHERE deviceId = \"{id}\";"
                );
            connection.Close();
        }

        public static void setDescription(int id, string description)
        {
            client.exec(
                connection,
                $"UPDATE device_info SET description = \"{description}\" WHERE deviceId = \"{id}\";"
                );
            connection.Close();
        }

        public static void updateAll(int id, string name, string type, string description)
        {
            client.exec(
                connection,
                $"UPDATE device_info SET name = \"{name}\", type = \"{type}\", description = \"{description}\" WHERE deviceId = \"{id}\";"
                );
            connection.Close();
        }

        public static void deleteId(int id)
        {
            client.exec(
                connection,
                $"DELETE FROM device_info WHERE id = \"{id}\";"
                );
            connection.Close();
        }

        class DeviceInfoData
        {
            public int deviceId { get; set; } 
            public string name { get; set; } 
            public string type { get; set; } 
            public string description { get; set; }
        }


        public static MySqlDataReader readAll()
        {
            return client.exec(
                GetConnection(),
                "SELECT * FROM device_info;"
                );
            /*object[][] data = new object[][] { };
            while (reader.Read())
            {
                int deviceId = reader.GetInt16(0);
                string name = reader.GetString(1);
                string type = reader.GetString(2);
                string description = reader.GetString(3);
                object[] d = new object[] { deviceId, name, type, description };
                data.Append(d);
            }
            connection.Close();*/
            //return data;
        }
    }
}
