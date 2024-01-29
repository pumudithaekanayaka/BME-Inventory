using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using System.Data.SqlClient;
using Npgsql;
using System.Data.SQLite;

namespace BME_Inventory
{
    public partial class SQLConnect : Form
    {

        private DatabaseManager dbManager;
        private string serverName;
        private string databaseName;
        private string username;
        private string password;

        public SQLConnect(DatabaseManager databaseManager)
        {
            InitializeComponent();
            dbManager = databaseManager;
        }

        public string ServerName
        {
            get { return serverName; }
            set { serverName = value; }
        }

        public string DatabaseName
        {
            get { return databaseName; }
            set { databaseName = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string ConnectionString
        {
            get
            {
                // Use the SqlConnectionStringBuilder to build the connection string
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
                {
                    DataSource = ServerName,
                    InitialCatalog = DatabaseName,
                    IntegratedSecurity = string.IsNullOrWhiteSpace(Username) && string.IsNullOrWhiteSpace(Password),
                    UserID = string.IsNullOrWhiteSpace(Username) ? null : Username,
                    Password = string.IsNullOrWhiteSpace(Password) ? null : Password
                };

                return builder.ToString();
            }
        }

        private void sql_conn_btn_Click(object sender, EventArgs e)
        {
            string enteredServerName = server_add_txt.Text;
            string enteredDatabaseName = database_txt.Text;
            string enteredUsername = username_txt.Text;
            string enteredPassword = password_txt.Text;

            if (string.IsNullOrWhiteSpace(enteredServerName) || string.IsNullOrWhiteSpace(enteredDatabaseName))
            {
                ShowErrorMessage("Please enter both server and database names.");
                return;
            }

            serverName = enteredServerName;
            databaseName = enteredDatabaseName;
            username = enteredUsername;
            password = enteredPassword;

            if (dbManager != null)
            {
                try
                {
                    if (TestDatabaseConnection())
                    {
                        SaveConfiguration();

                        OnConnectionSuccess();
                    }
                    else
                    {
                        ShowErrorMessage("Connection failed. Check your settings and try again.");
                    }
                }
                catch (Exception ex)
                {
                    ShowErrorMessage("Connection failed. Error: " + ex.Message);
                }
            }
            else
            {
                ShowErrorMessage("Database manager is not initialized.");
            }
        }

        private bool TestDatabaseConnection()
        {
            if (dbManager != null)
            {

                string enteredServerName = server_add_txt.Text;
                string enteredDatabaseName = database_txt.Text;
                string enteredUsername = username_txt.Text;
                string enteredPassword = password_txt.Text;
                // Use the SqlConnectionStringBuilder to build the connection string
                string connectionString = dbManager.GetConnectionString(enteredServerName, enteredDatabaseName, enteredUsername, enteredPassword);

                return dbManager.SearchAndConnectToDatabase(enteredServerName, enteredDatabaseName, enteredUsername, enteredPassword);
            }
            else
            {
                ShowErrorMessage("Database manager is not initialized.");
                return false;
            }
        }

        private void OnConnectionSuccess()
        {
            ConfigForm configForm = new ConfigForm(dbManager);
            configForm.Show();
            this.Close();
        }

        private void SaveConfiguration()
        {
            Properties.Settings.Default.ServerName = serverName;
            Properties.Settings.Default.DatabaseName = databaseName;
            Properties.Settings.Default.Save();
        }

        private static void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
