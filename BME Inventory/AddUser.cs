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

        private void user_save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                dbManager.OpenConnection();

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

                string insertUserQuery = "INSERT INTO users (username, password, user_role) VALUES (@Username, @Password, @User_Role)";
                using (SqlCommand insertUserCmd = new SqlCommand(insertUserQuery, dbManager.GetConnection()))
                {
                    insertUserCmd.Parameters.AddWithValue("@Username", username);
                    insertUserCmd.Parameters.AddWithValue("@Password", password);
                    insertUserCmd.Parameters.AddWithValue("@User_Role", userLevel);
                    insertUserCmd.ExecuteNonQuery();
                }

                MessageBox.Show("User added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
