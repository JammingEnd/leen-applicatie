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
                GetConnection(),
                $"INSERT INTO device_info (name, type, description) VALUES (\"{name}\",\"{type}\",\"{description}\");"
                );
        }

        public static void update(int id, string name, string type, string description)
        {
            client.exec(
                GetConnection(),
                $"INSERT INTO device_info (deviceId, name, type, description) VALUES (\"{id}\", \"{name}\",\"{type}\",\"{description}\") ON DUPLICATE KEY UPDATE name = \"{name}\", type = \"{type}\", description = \"{description}\""
            );
        }

        public static void deleteId(int id)
        {
            client.exec(
                GetConnection(),
                $"UPDATE device_info SET isDeleted = true WHERE deviceId = \"{id}\";"
                );
        }

        public static MySqlDataReader readAll()
        {
            MySqlDataReader data = client.exec(
                GetConnection(),
                "SELECT * FROM device_info WHERE isDeleted = false;"
                );
            return data;
        }
    }
}
