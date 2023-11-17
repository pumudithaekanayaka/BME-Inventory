using System;
using System.Windows.Forms;

namespace BME_Inventory
{
    public partial class DatabaseConnection : Form
    {
        private DatabaseManager dbManager;
        private string serverName;
        private string databaseName;

        public DatabaseConnection(DatabaseManager databaseManager, bool firstRun)
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

        public string ConnectionString
        {
            get
            {
                return $"Data Source={ServerName};Initial Catalog={DatabaseName};Integrated Security=True";
            }
        }

        private void conn_btn_Click(object sender, EventArgs e)
        {
            string enteredServerName = server_txt.Text;
            string enteredDatabaseName = db_txt.Text;

            if (string.IsNullOrWhiteSpace(enteredServerName) || string.IsNullOrWhiteSpace(enteredDatabaseName))
            {
                ShowErrorMessage("Please enter both server and database names.");
                return;
            }

            serverName = enteredServerName;
            databaseName = enteredDatabaseName;

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
                return dbManager.SearchAndConnectToDatabase(serverName, databaseName);
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

        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
