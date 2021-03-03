using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace actualForm
{
    class MySqlClient
    {
        #region database connection
        /// <summary>
        /// connecting to the database
        /// </summary>
        /// <returns></returns>
        public MySqlConnection connect()
        {
            string str = new DatabaseCreds().databaseUri;
            if (str == null || str.Trim() == "") return null;
            try
            {
                MySqlConnection con = new MySqlConnection(str);
                con.Open();
                //Console.WriteLine("Database Connected.");
                return con;
            } catch (Exception err)
            {
                Console.WriteLine(err);
                return null;
            }
        }
        #endregion

        #region exec database calls
        /// <summary>
        /// Executing database calls.
        /// </summary>
        /// <param name="con"> The database connection </param>
        /// <param name="str"> The SQL String </param>
        /// <returns></returns>
        public MySqlDataReader exec(MySqlConnection con, string str)
        {
            try
            {
                //Console.WriteLine(str);
                MySqlCommand cmd = new MySqlCommand(str, con);
                return cmd.ExecuteReader();
            } catch (Exception err)
            {
                Console.WriteLine(err);
                return null;
            }
        }
        #endregion

    }
}
