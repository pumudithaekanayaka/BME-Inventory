using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BME_Inventory
{
    public partial class login : Form
    {
        private const string ConnectionString = "Data Source=ASUS_X512JA\\SQLEXPRESS;Initial Catalog=Badulla Inventory;Integrated Security=True";
        private SqlConnection con;
        private SqlCommand cmd;

        public login()
        {
            InitializeComponent();
            con = new SqlConnection(ConnectionString);
            cmd = new SqlCommand();
            cmd.Connection = con;
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string username = username_txt.Text;
            string password = password_txt.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            try
            {
                con.Open();
                cmd.Parameters.Clear();
                cmd.CommandText = "SELECT password, user_level FROM users WHERE username = @username";
                cmd.Parameters.AddWithValue("@username", username);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string storedPassword = reader["password"].ToString();
                    string userRole = reader["user_level"].ToString();

                    if (storedPassword == password)
                    {
                        MessageBox.Show("Login successful!");

                        if (userRole == "user")
                        {
                            // User-specific actions
                            this.Hide();
                            UserHome userHome = new UserHome();
                            userHome.Show();
                        }
                        else if (userRole == "admin")
                        {
                            // Admin-specific actions
                            this.Hide();
                            AdminHome adminHome = new AdminHome();
                            adminHome.Show();
                        }
                        else if (userRole == "maintenance")
                        {
                            // Maintenance-specific actions
                            this.Hide();
                            MaintenanceHome maintenanceHome = new MaintenanceHome();
                            maintenanceHome.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }


    }
}
