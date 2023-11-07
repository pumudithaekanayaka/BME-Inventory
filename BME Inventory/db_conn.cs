using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BME_Inventory
{
    public partial class db_conn : Form
    {
        public string ConnectionString { get; private set; }

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

            ConnectionString = $"Data Source={serverName};Initial Catalog={databaseName};Integrated Security=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                }

                login loginForm = new login(ConnectionString);
                loginForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed. Error: " + ex.Message);
            }
        }
    }
}
