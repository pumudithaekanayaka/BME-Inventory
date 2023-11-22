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
    public partial class AddUser : Form
    {
        private DatabaseManager dbManager;

        public AddUser(DatabaseManager databaseManager)
        {
            InitializeComponent();
            dbManager = databaseManager;
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            try
            {
                dbManager.OpenConnection();

                string createTableQuery = "IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'users') " +
                                          "CREATE TABLE users (Id INT PRIMARY KEY IDENTITY(1,1), Username NVARCHAR(50), Password NVARCHAR(50), UserLevel NVARCHAR(10))";
                using (SqlCommand createTableCmd = new SqlCommand(createTableQuery, dbManager.GetConnection()))
                {
                    createTableCmd.ExecuteNonQuery();
                }

                string username = username_txt_add.Text;
                string password = password_txt_add.Text;
                string confirmPassword = confirm_password_txt_add.Text;
                string userLevel = user_level_add.SelectedItem?.ToString() ?? "DefaultUserLevel";

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                if (password != confirmPassword)
                {
                    MessageBox.Show("Passwords do not match.");
                    return;
                }

                string insertUserQuery = "INSERT INTO users (Username, Password, UserLevel) VALUES (@Username, @Password, @UserLevel)";
                using (SqlCommand insertUserCmd = new SqlCommand(insertUserQuery, dbManager.GetConnection()))
                {
                    insertUserCmd.Parameters.AddWithValue("@Username", username);
                    insertUserCmd.Parameters.AddWithValue("@Password", password);
                    insertUserCmd.Parameters.AddWithValue("@UserLevel", userLevel);
                    insertUserCmd.ExecuteNonQuery();
                }

                MessageBox.Show("User added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btn_database_adduser_Click(object sender, EventArgs e)
        {
            Database database = new Database(dbManager);
            database.Show();
            this.Hide();
        }

        private void btn_distribute_adduser_Click(object sender, EventArgs e)
        {
            Distribute distribute = new Distribute(dbManager);
            distribute.Show();
            this.Hide();
        }

        private void btn_receive_adduser_Click(object sender, EventArgs e)
        {
            Recieve recieve = new Recieve(dbManager);
            recieve.Show();
            this.Hide();
        }

        private void btn_add_adduser_Click(object sender, EventArgs e)
        {
            Create insert = new Create(dbManager);
            insert.Show();
            this.Hide();
        }

        private void btn_edit_adduser_Click(object sender, EventArgs e)
        {
            Edit edit = new Edit(dbManager);
            edit.Show();
            this.Hide();
        }

        private void btn_dev_adduser_Click_1(object sender, EventArgs e)
        {
            DeveloperDashboard developer = new DeveloperDashboard(dbManager);
            developer.Show();
            this.Hide();
        }

        private void btn_home_adduser_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(dbManager);
            dashboard.Show();
            this.Hide();
        }

        private void btn_logout_adduser_Click(object sender, EventArgs e)
        {
            this.Close();
            Login loginForm = new Login(dbManager);
            loginForm.Show();
        }

        private void btn_exit_adduser_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit the application?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
