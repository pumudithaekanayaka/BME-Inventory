using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace BME_Inventory
{
    public partial class login : Form
    {
        private DatabaseManager dbManager;
        private login loginForm;
        private string loggedInUsername = string.Empty;

        public login(DatabaseManager databaseManager, DatabaseConnection dbConnForm)
        {
            InitializeComponent();
            dbManager = databaseManager;
            password_txt.PasswordChar = '*';
        }

        public string LoggedInUsername
        {
            get { return loggedInUsername; }
        }

        private void RedirectBasedOnUserRole(string userRole)
        {
            if (userRole == "user" || userRole == "admin" || userRole == "maintenance")
            {
                UserRoles.CurrentUserRole = userRole;

                Form targetForm = new Dashboard(dbManager);

                this.Hide();
                targetForm.Show();
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
                                RedirectBasedOnUserRole(userRole);
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
            string logFolderPath = "C:\\Inventory logs";
            string logFileName = "login_log.txt";
            string logFilePath = Path.Combine(logFolderPath, logFileName);
            string logMessage = $"{username} logged in at {DateTime.Now}";

            try
            {
                // Ensure the log folder exists
                Directory.CreateDirectory(logFolderPath);

                using (StreamWriter writer = File.AppendText(logFilePath))
                {
                    writer.WriteLine(logMessage);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Failed to write to the log file: " + ex.Message);
            }
        }

    }
}
