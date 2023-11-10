using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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

        public bool TestConnection()
        {
            try
            {
                OpenConnection();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }


        public void OpenConnection()
        {
            try
            {
                if (CheckConnectionState() != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error while opening connection: " + ex.Message);
            }
        }

        public void CloseConnection()
        {
            try
            {
                if (CheckConnectionState() != System.Data.ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error while closing connection: " + ex.Message);
            }
        }

        public void Dispose()
        {
            CloseConnection();
            connection.Dispose();
        }

        private ConnectionState CheckConnectionState()
        {
            return connection.State;
        }
    }
}
