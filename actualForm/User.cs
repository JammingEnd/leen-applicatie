using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actualForm
{
    class User
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
        /// setFirstName
        /// setLastName
        /// setClass
        /// setStudentId
        /// 
        /// schema:
        /// userId INT NOT NULL AUTO_INCREMENT, 
        /// firstName VARCHAR(20) NOT NULL, 
        /// lastName VARCHAR(20) NOT NULL,
        /// studentId INT (6) NOT NULL,
        /// class VARCHAR(10), 
        /// </summary>




        public static int add(string firstName, string lastName, int studentId, string Class)
        {
            Console.WriteLine("test");
            client.exec(
                GetConnection(),
                $"INSERT INTO user (firstName, lastName, studentId, class) VALUES (\"{firstName}\", \"{lastName}\", \"{studentId}\", \"{Class}\");"
                );
            MySqlDataReader reader = client.exec(
                GetConnection(),
                $"SELECT * FROM user WHERE firstname = \"{firstName}\" AND lastName = \"{lastName}\" AND studentId = \"{studentId}\" AND class = \"{Class}\";"
                );
            while (reader.Read())
            {
                return reader.GetInt16(0);
            }
            return -1;
        }

        public static void delete(int id)
        {
            client.exec(
                GetConnection(),
                $"DELETE FROM user WHERE userId = \"{id}\";"
                );
        }

        public static void updateAll(int id, string firstName, string lastName, int studentId, string Class)
        {
            client.exec(
                GetConnection(),
                $"UPDATE user SET firstname = \"{firstName}\", lastName = \"{lastName}\", studentId = \"{studentId}\", class = \"{Class}\" WHERE userId = \"{id}\";"
                );
        }

        public static void setFirstName(int id, string firstName)
        {
            client.exec(
                GetConnection(),
                $"UPDATE user SET firstname = \"{firstName}\" WHERE userId = \"{id}\";"
                );
        }

        public static void setLastName(int id, string lastName)
        {
            client.exec(
                GetConnection(),
                $"UPDATE user SET lastName = \"{lastName}\" WHERE userId = \"{id}\";"
                );
        }
        
        public static void setStudentId(int id, int studentId)
        {
            client.exec(
                GetConnection(),
                $"UPDATE user SET studentId = \"{studentId}\" WHERE userId = \"{id}\";"
                );
        }
        
        public static void setClass(int id, string Class)
        {
            client.exec(
                GetConnection(),
                $"UPDATE user SET class = \"{Class}\" WHERE userId = \"{id}\";"
                );
        }
    }
}
