using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace CRUD
{
    class connection
    {
        public static MySqlConnection getConnection()
        {
            MySqlConnection conn = null;
            try
            {
                string sConnString = "server=localhost ;database=crud ;uid=root;password=;";
                conn = new MySqlConnection(sConnString);
            }
            catch (MySqlException sqlex)
            {
                throw new Exception(sqlex.Message.ToString());
            }
            return conn;
        }
    }
}
