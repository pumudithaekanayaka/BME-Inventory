using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BME_Inventory
{
    public partial class login : Form
    {
        private DatabaseManager dbManager; // Replace 'DatabaseManager' with your actual class name

        public login(DatabaseManager databaseManager)
        {
            InitializeComponent();
            dbManager = databaseManager;
            password_txt.PasswordChar = '*';
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
                dbManager.OpenConnection();

                using (var cmd = new SqlCommand("SELECT password, user_role FROM users WHERE username = @username", dbManager.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@username", username);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string storedPassword = reader["password"].ToString();
                            string userRole = reader["user_role"].ToString();

                            if (storedPassword == password)
                            {
                                if (userRole == "user")
                                {
                                    this.Hide();
                                    UserHome userHome = new UserHome();
                                    userHome.Show();
                                }
                                else if (userRole == "admin")
                                {
                                    this.Hide();
                                    AdminHome adminHome = new AdminHome(dbManager);
                                    adminHome.Show();
                                }
                                else if (userRole == "maintenance")
                                {
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
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                dbManager.CloseConnection();
            }
        }
    }
}
