using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BME_Inventory
{
    public partial class Home : Form
    {

        private SqlConnection databaseConnection;
        private string databaseName;
        private string tableName;

        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            distribute distribute = new distribute();
            distribute.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            View view = new View();
            view.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Insert insert = new Insert();
            insert.Show();
            this.Hide();
        }

        private void table_btn6_Click(object sender, EventArgs e)
        {
            Table table = new Table();
            table.Show();
            this.Hide();
        }

        private void exit_btn6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit the application?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void connect_btn6_Click(object sender, EventArgs e)
        {
            /*
            string serverName = "."; // Use "." for the local machine
            string connectionString = $"Data Source={serverName};Initial Catalog=master;Integrated Security=True";

            using (SqlConnection masterConnection = new SqlConnection(connectionString))
            {
                try
                {
                    masterConnection.Open();
                    databaseName = database_txt6.Text;
                    tableName = table_txt6.Text;

                    // Check if the database exists, if not, create it
                    using (SqlCommand createDatabaseCommand = new SqlCommand($"CREATE DATABASE IF NOT EXISTS {databaseName}", masterConnection))
                    {
                        createDatabaseCommand.ExecuteNonQuery();
                    }

                    // Switch to the newly created database
                    connectionString = $"Data Source={serverName};Initial Catalog={databaseName};Integrated Security=True";
                    databaseConnection = new SqlConnection(connectionString);
                    databaseConnection.Open();

                    // Check if the table exists, if not, create it
                    using (SqlCommand createTableCommand = new SqlCommand($"CREATE TABLE IF NOT EXISTS {tableName} (part_id INT PRIMARY KEY, part_name VARCHAR(50), equip_name VARCHAR(200), upper NUMERIC, lower NUMERIC, stock NUMERIC, description VARCHAR(200))", databaseConnection))
                    {
                        createTableCommand.ExecuteNonQuery();
                    }

                    MessageBox.Show("Connected to the database and table.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                } */
            } 
        }
    }
