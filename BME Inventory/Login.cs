using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace BME_Inventory
{
    public partial class Login : Form
    {
        private DatabaseManager dbManager;
        private string loggedInUsername;

        public Login(DatabaseManager databaseManager)
        {
            InitializeComponent();
            dbManager = databaseManager;
            password_txt.PasswordChar = '*';
        }

        public string LoggedInUsername => loggedInUsername;

        private void RedirectBasedOnUserRole(string userRole, string username)
        {
            if (userRole == "user" || userRole == "admin" || userRole == "maintenance")
            {
                UserRoles.CurrentUserRole = userRole;
                CurrentUser.Username = username;
                Dashboard dashboard = new Dashboard(dbManager);

                Hide();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
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
                                loggedInUsername = username;
                                RedirectBasedOnUserRole(userRole, username);
                                LogLogin(username_txt.Text);
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

        private void LogLogin(string username)
        {
            string documentsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string logFolderPath = Path.Combine(documentsFolder, "Inventory Logs");
            string logFilePath = Path.Combine(logFolderPath, $"user_log_{DateTime.Now:yyyyMMdd}.txt");
            string logMessage = $"{username_txt.Text} logged in at {DateTime.Now}";

            try
            {
                if (!Directory.Exists(logFolderPath))
                {
                    Directory.CreateDirectory(logFolderPath);
                }

                using (StreamWriter writer = File.AppendText(logFilePath))
                {
                    writer.WriteLine(logMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to write to the log file: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chng_server_btn_login_Click(object sender, EventArgs e)
        {
            DatabaseConnection databaseConnection = new DatabaseConnection(dbManager, false);
            databaseConnection.Show();
            this.Hide();
        }

    }
}
