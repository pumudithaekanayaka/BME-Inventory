using System;
using System.Windows.Forms;
using System.Data.SqlClient;

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
                dbManager.OpenConnection();

                CreateTable("users", "username NVARCHAR(50), password NVARCHAR(50), user_role NVARCHAR(50)");
                CreateTable("inventory", "part_id VARCHAR(50), part_name VARCHAR(MAX), equip_name VARCHAR(MAX), upper NUMERIC(18, 0), lower NUMERIC(18, 0), stock NUMERIC(18, 0), description VARCHAR(MAX), make VARCHAR(MAX), model VARCHAR(MAX), date_time DATETIME");
                CreateTable("parts", "make VARCHAR(MAX), model VARCHAR(MAX)");
                CreateTable("distribution", "part_id VARCHAR(50), make VARCHAR(MAX), model VARCHAR(MAX), equip_name VARCHAR(MAX), issued_by VARCHAR(MAX), issued_quantity NUMERIC(18, 0), time DATETIME, book_page_id VARCHAR(50)");
                CreateTable("received", "part_id VARCHAR(50), make VARCHAR(MAX), model VARCHAR(MAX), equip_name VARCHAR(MAX), add_by VARCHAR(MAX), add_quantity NUMERIC(18, 0), time DATETIME, issue_id VARCHAR(50)");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
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
