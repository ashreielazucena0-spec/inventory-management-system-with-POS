using System;
using MySql.Data.MySqlClient;

namespace inventory_management_system_with_POS
{
    public static class DBConnection
    {
        private const string Server = "localhost";
        private const string Port = "3306";
        private const string Database = "inventorydb";
        private const string UserId = "root";
        private const string Password = "123456789";

        private static string ConnectionString =>
            $"Server={Server};Port={Port};Database={Database};Uid={UserId};Pwd={Password};";

        public static MySqlConnection GetConnection()
        {
            var conn = new MySqlConnection(ConnectionString);
            conn.Open();
            return conn;    
        }

       
        public static string DatabaseName => Database;

        public static bool TestConnection(out string errorMessage)
        {
            try
            {
                using (var conn = GetConnection())
                {
                    errorMessage = null;
                    return conn.State == System.Data.ConnectionState.Open;
                }
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return false;
            }
        }
    }
}