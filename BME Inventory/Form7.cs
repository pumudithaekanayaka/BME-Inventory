using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BME_Inventory
{
    public partial class login : Form
    {
        private string ConnectionString;
        private SqlConnection con;
        private SqlCommand cmd;

        public login(string connectionString)
        {
            InitializeComponent();
            this.ConnectionString = connectionString;
            con = new SqlConnection(ConnectionString);
            cmd = new SqlCommand();
            cmd.Connection = con;
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
                con.Open();
                cmd.Parameters.Clear();
                cmd.CommandText = "SELECT password, user_role FROM users WHERE username = @username";
                cmd.Parameters.AddWithValue("@username", username);

                SqlDataReader reader = cmd.ExecuteReader();

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
                            AdminHome adminHome = new AdminHome();
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
