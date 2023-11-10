using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BME_Inventory
{
    public partial class DatabaseConnection : Form
    {
        public DatabaseConnection()
        {
            InitializeComponent();
        }

        private void conn_btn_Click(object sender, EventArgs e)
        {
            string serverName = server_txt.Text;
            string databaseName = db_txt.Text;

            if (string.IsNullOrWhiteSpace(serverName) || string.IsNullOrWhiteSpace(databaseName))
            {
                MessageBox.Show("Please enter both server and database names.");
                return;
            }

            Properties.Settings.Default.ServerName = serverName;
            Properties.Settings.Default.DatabaseName = databaseName;
            Properties.Settings.Default.Save();

            try
            {
                string connectionString = GetConnectionString();

                using (DatabaseManager dbManager = new DatabaseManager(connectionString))
                {
                    if (dbManager.TestConnection())
                    {
                        this.Hide();
                        Login login = new Login(dbManager);
                        login.Show();

                        MessageBox.Show("Connection successful!");
                    }
                    else
                    {
                        MessageBox.Show("Connection failed. Check your settings and try again.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed. Error: " + ex.Message);
            }
        }

        private string GetConnectionString()
        {
            string serverName = Properties.Settings.Default.ServerName;
            string databaseName = Properties.Settings.Default.DatabaseName;

            return $"Data Source={serverName};Initial Catalog={databaseName};Integrated Security=True";
        }
    }
}
