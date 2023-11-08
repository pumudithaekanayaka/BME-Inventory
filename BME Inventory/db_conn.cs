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

            Properties.Settings.Default.ServerName = serverName;
            Properties.Settings.Default.DatabaseName = databaseName;
            Properties.Settings.Default.Save();

            try
            {
                this.Hide();
                DatabaseManager dbManager = new DatabaseManager(GetConnectionString());
                login login = new login(dbManager);
                login.Show();
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
