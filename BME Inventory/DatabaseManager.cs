using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Win32;

namespace BME_Inventory
{
    public class DatabaseManager : IDisposable
    {
        private SqlConnection connection;
        private string connectionString;
        public string ServerName { get; private set; }
        public string DatabaseName { get; private set; }

        public DatabaseManager()
        {
            LoadConfiguration();

            connection = new SqlConnection(GetOldConnectionString(ServerName, DatabaseName));
        }

        public DatabaseManager(string connectionString)
        {
            this.connectionString = connectionString;
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
        }

        public void OpenConnection()
        {
            if (CheckConnectionState() != ConnectionState.Open)
            {
                connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (CheckConnectionState() != ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        public bool SearchAndConnectToDatabase(string serverName, string databaseName, string username = null, string password = null)
        {
            try
            {
                ServerName = serverName;
                DatabaseName = databaseName;

                SaveConfiguration();
                SaveToRegistry();

                if (string.IsNullOrWhiteSpace(username) && string.IsNullOrWhiteSpace(password))
                {
                    connection.ConnectionString = GetOldConnectionString(ServerName, DatabaseName);
                }
                else
                {
                    connection.ConnectionString = GetConnectionString(ServerName, DatabaseName, username, password);
                }

                connection.Open();
                return true;
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine("SQL Exception: " + sqlEx.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("General Exception: " + ex.Message);
                return false;
            }
        }


        private ConnectionState CheckConnectionState()
        {
            return connection.State;
        }

        private string GetOldConnectionString(string serverName, string databaseName)
        {
            return $"Data Source={serverName};Initial Catalog={databaseName};Integrated Security=True";
        }


        public string GetConnectionString(string serverName, string databaseName, string username, string password)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
            {
                DataSource = serverName,
                InitialCatalog = databaseName,
                IntegratedSecurity = string.IsNullOrWhiteSpace(username) && string.IsNullOrWhiteSpace(password),
                UserID = string.IsNullOrWhiteSpace(username) ? null : username,
                Password = string.IsNullOrWhiteSpace(password) ? null : password
            };

            return builder.ToString();
        }

        private void SaveConfiguration()
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.AppSettings.Settings["ServerName"].Value = ServerName;
            configuration.AppSettings.Settings["DatabaseName"].Value = DatabaseName;
            configuration.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        private void LoadConfiguration()
        {
            ServerName = ConfigurationManager.AppSettings["ServerName"];
            DatabaseName = ConfigurationManager.AppSettings["DatabaseName"];
        }

        private void SaveToRegistry()
        {
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software", true);
            registryKey = registryKey?.CreateSubKey("BMEInventory", true);

            if (registryKey != null)
            {
                registryKey.SetValue("ServerName", ServerName);
                registryKey.SetValue("DatabaseName", DatabaseName);
                registryKey.Close();
            }
        }

        public void Dispose()
        {
            CloseConnection();
            connection.Dispose();
        }
    }
}
