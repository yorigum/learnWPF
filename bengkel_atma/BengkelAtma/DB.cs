using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
namespace BengkelAtma
{
    public static class DB
    {
        static MySqlConnection databaseConnection=null;
        public static MySqlConnection GetDBConnection()
        {
            if (databaseConnection == null)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["myDBConnect"].ConnectionString;
                databaseConnection = new MySqlConnection(connectionString);
            }
            return databaseConnection;
        }
    }
}
