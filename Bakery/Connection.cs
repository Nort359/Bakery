using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery
{
    class Connection
    {
        //public static string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Sourse=Workers.mdb";
        //public static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Sourse=Workers.mdb";

        private static OleDbConnection connection; // Соединение с БД

        private static OleDbConnectionStringBuilder connectionString = new OleDbConnectionStringBuilder(); // Строка соединения

        private static string dbName = @"BakeryDB.mdb";

        public static string getDBName()
        {
            return dbName;
        }

        public static OleDbConnection getConnection()
        {
            if (connection != null)
            {
                return connection;
            }
            else
            {
                // Устанавливам соединение
                connectionString.Provider = "Microsoft.Jet.OLEDB.4.0";
                connectionString.DataSource = dbName;

                connection = new OleDbConnection(connectionString.ConnectionString + ";Jet OLEDB:Database Password=203040");

                return connection;
            }
        }
    }
}
