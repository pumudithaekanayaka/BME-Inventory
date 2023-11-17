using System;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BME_Inventory
{
    public partial class Dashboard : Form
    {
        private DatabaseManager dbManager;
        private SqlConnection connection;

        public Dashboard(DatabaseManager databaseManager)
        {
            InitializeComponent();
            dbManager = databaseManager;
            connection = dbManager.GetConnection();
            UpdateUIBasedOnUserRole();
        }

        private void UpdateUIBasedOnUserRole()
        {
            string currentUserRole = UserRoles.CurrentUserRole;

            if (currentUserRole == "user")
            {
                btn_receive_dashboard.Enabled = false;
                btn_receive_dashboard.Visible = false;
                btn_edit_dashboard.Enabled = false;
                btn_edit_dashboard.Visible = false;
                btn_add_dashboard.Enabled = false;
                btn_add_dashboard.Visible = false;
                btn_database_dashboard.Enabled = true;
                btn_dev_dashboard.Enabled = false;
                btn_dev_dashboard.Visible = false;
            }
            else if (currentUserRole == "admin")
            {
                btn_distribute_dashboard.Enabled = true;
                btn_dev_dashboard.Enabled = false;
                btn_dev_dashboard.Visible = false;
                btn_edit_dashboard.Enabled = true;
                btn_add_dashboard.Enabled = true;
                btn_database_dashboard.Enabled = true;
            }
            else if (currentUserRole == "maintenance")
            {
                btn_distribute_dashboard.Enabled = true;
                btn_dev_dashboard.Enabled = true;
                btn_edit_dashboard.Enabled = true;
                btn_add_dashboard.Enabled = true;
                btn_database_dashboard.Enabled = true;
            }
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

        private void exit_btn6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit the application?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

            string username = CurrentUser.Username;

            if (username != null)
            {
                user_lbl_dashboard.Text = $"{username}";
            }
            else
            {
                user_lbl_dashboard.Text = $"Unable to retrieve username.";
            }
        }

        private void btn_logout_dashboard_Click(object sender, EventArgs e)
        {
            this.Close();
            Login loginForm = new Login(dbManager);
            loginForm.Show();
        }

        private void btn_table_dashboard_Click(object sender, EventArgs e)
        {
            Database database = new Database(dbManager);
            database.Show();
            this.Hide();
        }

        private void btn_distribute_dashboard_Click(object sender, EventArgs e)
        {
            Distribute distribute = new Distribute(dbManager);
            distribute.Show();
            this.Hide();
        }

        private void btn_receive_dashboard_Click(object sender, EventArgs e)
        {
            Recieve recieve = new Recieve(dbManager);
            recieve.Show();
            this.Hide();
        }

        private void btn_add_dashboard_Click(object sender, EventArgs e)
        {
            Create insert = new Create(dbManager);
            insert.Show();
            this.Hide();
        }

        private void btn_adduser_dashboard_Click_1(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser(dbManager);
            addUser.Show();
            this.Hide();
        }

        private void btn_edit_dashboard_Click(object sender, EventArgs e)
        {
            Edit edit = new Edit(dbManager);
            edit.Show();
            this.Hide();
        }

        private void btn_dev_dashboard_Click(object sender, EventArgs e)
        {
            DeveloperDashboard developer = new DeveloperDashboard(dbManager);
            developer.Show();
            this.Hide();
        }

        private void refresh_btn_dashboard_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM inventory WHERE stock < lower";
            LoadDataIntoGrid(query, new DataTable());
        }
    }
}
