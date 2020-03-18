using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public static class DBConnector
    {
        public static string connectionString = "server=127.0.0.1;user=root;password=dashasofia2;database=cinematheatre";
       public static MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
        public static MySqlCommand mySqlCommand = new MySqlCommand();
    }
}
