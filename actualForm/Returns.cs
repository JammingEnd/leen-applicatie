﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actualForm
{
    class Returns
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
        /// update ledingId
        /// update description
        /// 
        /// schema:
        /// ID INT NOT NULL AUTO_INCREMENT
        /// deviceId INT NOT NULL
        /// userId INT NOT NULL
        /// lendingId INT NOT NULL
        /// description VARCHAR(200)
        /// PRIMARY KEY(ID)
        /// FOREIGN KEY(deviceId) REFERENCES device_info(deviceId)
        /// FOREIGN KEY(userId) REFERENCES user(userId)
        /// FOREIGN KEY(lendingId) REFERENCES lendings(lendingId) 
        /// </summary>




        public static void add(int deviceId, int userId, int lendingId, string description = null)
        {
            client.exec(
                GetConnection(),
                $"INSERT INTO returns " +
                $"(deviceId, userId, lendingId{(description != null ? ", description" : "")}) " +
                $"VALUES " +
                $"(\"{deviceId}\", \"{userId}\", \"{lendingId}\"{(description != null ? $", \"{description}\"" : "")});"
                );
        }

        public static void delete(int id)
        {
            client.exec(
                GetConnection(),
                $"DELETE FROM returns WHERE ID = \"{id}\";"
                );
        }

        public static void updateAll(int id, int deviceId, int userId, int lendingId, string description = null)
        {
            client.exec(
                GetConnection(),
                $"UPDATE returns SET " +
                $"deviceId = \"{deviceId}\", " +
                $"userId = \"{userId}\", " +
                $"ledingId = \"{lendingId}\"" +
                $"{(description != null ? $", description = \"{description}\"" : "")} " +
                $"WHERE ID = \"{id}\";"
                );
        }

        public static void updateDeviceId(int id, int deviceId)
        {
            client.exec(
                GetConnection(),
                $"UPDATE returns SET deviceId = \"{deviceId}\" WHERE ID = \"{id}\";"
                );
        }

        public static void updateUserId(int id, int userId)
        {
            client.exec(
                GetConnection(),
                $"UPDATE returns SET userId = \"{userId}\" WHERE ID = \"{id}\";"
                );
        }

        public static void updateLendingId(int id, int lendingId)
        {
            client.exec(
                GetConnection(),
                $"UPDATE returns SET lendingId = \"{lendingId}\" WHERE ID = \"{id}\";"
                );
        }

        public static void updateDescription(int id, string description)
        {
            client.exec(
                GetConnection(),
                $"UPDATE returns SET description = \"{description}\" WHERE ID = \"{id}\";"
                );
        }
    }
}
