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
        /// <summary>
        /// add
        /// create
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




        public static void add(string firstName, string lastName, int studentId, string Class)
        {
            client.exec(
                connection,
                $"INSERT INTO user (firstName, lastName, studentId, class) VALUES (\"{firstName}\", \"{lastName}\", \"{studentId}\", \"{Class}\");"
                );
            connection.Close();
        }

        public static void delete(int id)
        {
            client.exec(
                connection,
                $"DELETE FROM user WHERE userId = \"{id}\";"
                );
            connection.Close();
        }

        public static void updateAll(int id, string firstName, string lastName, int studentId, string Class)
        {
            client.exec(
                connection,
                $"UPDATE user SET firstname = \"{firstName}\", lastName = \"{lastName}\", studentId = \"{studentId}\", class = \"{Class}\" WHERE userId = \"{id}\";"
                );
            connection.Close();
        }

        public static void setFirstName(int id, string firstName)
        {
            client.exec(
                connection,
                $"UPDATE user SET firstname = \"{firstName}\" WHERE userId = \"{id}\";"
                );
            connection.Close();
        }

        public static void setLastName(int id, string lastName)
        {
            client.exec(
                connection,
                $"UPDATE user SET lastName = \"{lastName}\" WHERE userId = \"{id}\";"
                );
            connection.Close();
        }

        public static void setClass(int id, string Class)
        {
            client.exec(
                connection,
                $"UPDATE user SET class = \"{Class}\" WHERE userId = \"{id}\";"
                );
            connection.Close();
        }

        public static void setStudentId(int id, int studentId)
        {
            client.exec(
                connection,
                $"UPDATE user SET studentId = \"{studentId}\" WHERE userId = \"{id}\";"
                );
            connection.Close();
        }
    }
}
