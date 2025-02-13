﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actualForm
{
    class Lendings
    {
        private static MySqlClient client = new MySqlClient();
        private static MySqlConnection connection = client.connect();
        private static MySqlConnection GetConnection()
        {
            return client.connect();
        }

        /// <summary>
        /// add
        /// delete
        /// updateAll
        /// update deviceId
        /// update userId
        /// 
        /// schema:
        /// lendingId INT NOT NULL AUTO_INCREMENT
        /// deviceId INT NOT NULL
        /// last_updated DATETIME NOT NULL
        /// userId INT NOT NULL
        /// isActive BOOLEAN NOT NULL
        /// PRIMARY KEY(lendingId)
        /// FOREIGN KEY(deviceId) REFERENCES device_info(deviceId)
        /// FOREIGN KEY(userId) REFERENCES user(userId)
        /// </summary>

        public static void add(int deviceId, int userId)
        {
            client.exec(
                GetConnection(),
                $"INSERT INTO lendings (deviceId, last_updated, userId, isActive) VALUES (\"{deviceId}\", NOW(), \"{userId}\", \"{1}\");"
                );
            
        }

        public static void delete(int deviceId, string description)
        {
            MySqlDataReader reader = client.exec(
                GetConnection(),
                $"SELECT * FROM lendings WHERE isActive = 1 AND deviceId = \"{deviceId}\";"
                );
            while (reader.Read())
            {
                int lendingId = reader.GetInt16(0);
                int userId = reader.GetInt16(3);
                Returns.add(deviceId, userId, lendingId, description);
                client.exec(
                    GetConnection(),
                    $"UPDATE lendings SET isActive = \"{0}\" WHERE deviceId = \"{deviceId}\" AND isActive = \"{1}\";"
                    );
            }
        }

        public static void updateAll(int lendingId, int deviceId, int userId)
        {
            client.exec(
                GetConnection(),
                $"UPDATE lendings SET deviceId = \"{deviceId}\", last_updated = NOW(), userId = \"{userId}\" WHERE lendingId = \"{lendingId}\";"
                );
        }

        public static void updateDeviceId(int lendingId, int deviceId)
        {
            client.exec(
                GetConnection(),
                $"UPDATE lendings SET deviceId = \"{deviceId}\", last_updated = NOW() WHERE lendingId = \"{lendingId}\";"
                );
        }

        public static void updateUserId(int lendingId, int userId)
        {
            client.exec(
                GetConnection(),
                $"UPDATE lendings SET userId = \"{userId}\", last_updated = NOW() WHERE lendingId = \"{lendingId}\";"
                );
        }

        public static MySqlDataReader getOneLending(int deviceId)
        {
            return client.exec(
                GetConnection(),
                $"SELECT * FROM lendings WHERE deviceId = \"{deviceId}\""
                );
        }

        public static bool isActive(int deviceId)
        {
            Console.WriteLine();
            MySqlDataReader reader = getOneLending(deviceId);
            if (reader == null)
            {
                return false;
            }
            while(reader.Read())
            {
                if (reader.GetBoolean(4))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
