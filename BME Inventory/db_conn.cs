using System;
using System.Windows.Forms;

namespace BME_Inventory
{
    public partial class db_conn : Form
    {
        public db_conn()
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

            string connectionString = $"Data Source={serverName};Initial Catalog={databaseName};Integrated Security=True";

            try
            {
                this.Hide();
                DatabaseManager dbManager = new DatabaseManager(connectionString); // Create a DatabaseManager with the connection string
                login login = new login(dbManager); // Pass the DatabaseManager as an argument
                login.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed. Error: " + ex.Message);
            }
        }
    }
}
