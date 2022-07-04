using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace gestion_stock
{
    class Myconnection
    {
        private static MySqlConnection conn = null;
        public static  MySqlConnection getConnection()
        {
            try
            {
                
                if (conn == null)
                {
                    conn = new MySqlConnection("SERVER=localhost;PORT=3306;DATABASE=dbecole;UID=root;PWD=;");
                    conn.Open();
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Eurreur de connection à la base de données" + ex);
            }
            return conn;
        }
    }
}