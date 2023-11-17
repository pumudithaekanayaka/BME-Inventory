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
    public partial class DeveloperDashboard : Form
    {
        private DatabaseManager dbManager;
        private SqlConnection connection;

        public DeveloperDashboard(DatabaseManager databaseManager)
        {
            InitializeComponent();
            dbManager = databaseManager;
            connection = dbManager.GetConnection();
        }


        private void LoadDataIntoGrid(string query, DataTable table)
        {
            try
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(query, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(table);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            if (table.Rows.Count > 0)
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                foreach (DataColumn column in table.Columns)
                {
                    dataGridView1.Columns.Add(column.ColumnName, column.ColumnName);
                }

                foreach (DataRow row in table.Rows)
                {
                    dataGridView1.Rows.Add(row.ItemArray);
                }

                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            else
            {
                MessageBox.Show("Record not found!");
            }
        }

        private void MaintenanceHome_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM users";
            LoadDataIntoGrid(query, new DataTable());

            string username = CurrentUser.Username;

            if (username != null)
            {
                user_lbl_developer.Text = $"{username}";
            }
            else
            {
                user_lbl_developer.Text = $"Unable to retrieve username.";
            }
        }

        private void btn_table_developer_Click(object sender, EventArgs e)
        {
            Database database = new Database(dbManager);
            database.Show();
            this.Close();
        }

        private void btn_distribute_developer_Click(object sender, EventArgs e)
        {
            Distribute distribute = new Distribute(dbManager);
            distribute.Show();
            this.Close();
        }

        private void btn_receive_developer_Click(object sender, EventArgs e)
        {
            Recieve recieve = new Recieve(dbManager);
            recieve.Show();
            this.Close();
        }

        private void btn_add_developer_Click(object sender, EventArgs e)
        {
            Create create = new Create(dbManager);
            create.Show();
            this.Close();
        }

        private void btn_adduser_developer_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser(dbManager);
            addUser.Show();
            this.Close();
        }

        private void btn_edit_developer_Click(object sender, EventArgs e)
        {
            Edit edit = new Edit(dbManager);
            edit.Show();
            this.Close();
        }

        private void home_btn_developer_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(dbManager);
            dashboard.Show();
            this.Close();
        }

        private void btn_logout_developer_Click(object sender, EventArgs e)
        {
            this.Close();
            Login loginForm = new Login(dbManager);
            loginForm.Show();
        }

        private void btn_exit_developer_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit the application?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void firstrun_reset_btn_dev_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to reset the first run status?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Properties.Settings.Default["IsFirstRun"] = true;
                Properties.Settings.Default.Save();

                MessageBox.Show("First run status has been reset.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
