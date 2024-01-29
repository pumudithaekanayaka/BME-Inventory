using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace BME_Inventory
{
    public partial class ConfigForm : Form
    {
        private DatabaseManager dbManager;

        public ConfigForm(DatabaseManager databaseManager)
        {
            InitializeComponent();
            dbManager = databaseManager;
        }

        private void cont_btn_select_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login(dbManager);
            login.Show();
        }

        private void create_tables_btn_config_Click(object sender, EventArgs e)
        {
            try
            {
                string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string inventoryLogsPath = Path.Combine(documentsPath, "Inventory Logs");
                Directory.CreateDirectory(inventoryLogsPath);

                string distributionLogsPath = Path.Combine(inventoryLogsPath, "Distribution Logs");
                string receivedLogsPath = Path.Combine(inventoryLogsPath, "Received Logs");
                string userLogsPath = Path.Combine(inventoryLogsPath, "User Logs");
                string applicationLogsPath = Path.Combine(inventoryLogsPath, "Application Logs");

                Directory.CreateDirectory(distributionLogsPath);
                Directory.CreateDirectory(receivedLogsPath);
                Directory.CreateDirectory(userLogsPath);
                Directory.CreateDirectory(applicationLogsPath);

                try
                {
                    dbManager.OpenConnection();

                    CreateTable("users", "username NVARCHAR(50) NOT NULL, password NVARCHAR(50) NOT NULL, user_role NVARCHAR(50) NOT NULL");
                    CreateTable("inventory", "part_id VARCHAR(50) PRIMARY KEY NOT NULL, part_name VARCHAR(MAX) NOT NULL, equip_name VARCHAR(MAX) NOT NULL, upper NUMERIC(18, 0) NOT NULL, lower NUMERIC(18, 0) NOT NULL, stock NUMERIC(18, 0) NOT NULL, description VARCHAR(MAX) NOT NULL, make VARCHAR(MAX), model VARCHAR(MAX), date_time DATETIME NOT NULL");
                    CreateTable("parts", "make VARCHAR(MAX), model VARCHAR(MAX)");
                    CreateTable("distribution", "part_id VARCHAR(50) PRIMARY KEY NOT NULL, make VARCHAR(MAX), model VARCHAR(MAX), equip_name VARCHAR(MAX) NOT NULL, issued_by VARCHAR(MAX) NOT NULL, issued_quantity NUMERIC(18, 0) NOT NULL, time DATETIME NOT NULL, book_page_id VARCHAR(50) NOT NULL");
                    CreateTable("received", "part_id VARCHAR(50) PRIMARY KEY NOT NULL, make VARCHAR(MAX), model VARCHAR(MAX), equip_name VARCHAR(MAX) NOT NULL, add_by VARCHAR(MAX) NOT NULL, add_quantity NUMERIC(18, 0) NOT NULL, time DATETIME NOT NULL, issue_id VARCHAR(50) NOT NULL");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while creating folders: " + ex.Message);
            }
        }

        private void CreateTable(string tableName, string columns)
        {
            string createTableQuery = $"IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = '{tableName}') " +
                                      $"CREATE TABLE {tableName} ({columns})";

            using (SqlCommand createTableCmd = new SqlCommand(createTableQuery, dbManager.GetConnection()))
            {
                createTableCmd.ExecuteNonQuery();
            }
        }
    }
}
