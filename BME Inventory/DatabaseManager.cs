using System;
using System.Data.SqlClient;

namespace BME_Inventory
{
    public class DatabaseManager : IDisposable
    {
        private SqlConnection connection;
        private string connectionString;

        public DatabaseManager(string connectionString)
        {
            this.connectionString = connectionString;
            connection = new SqlConnection(connectionString);
        }

        public SqlConnection GetConnection()
        {
            return connection;
        }

        public void OpenConnection()
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error while opening connection: " + ex.Message);
            }
        }

        public void CloseConnection()
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error while closing connection: " + ex.Message);
            }
        }

        public void Dispose()
        {
            CloseConnection();
            connection.Dispose();
        }
    }
}
