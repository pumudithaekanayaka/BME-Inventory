using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.SqlClient;

namespace BME_Inventory
{
    public partial class Distribute : Form
    {
        private DatabaseManager dbManager;
        private string loggedInUsername;
        private string username;

        public Distribute(DatabaseManager databaseManager)
        {
            InitializeComponent();
            dbManager = databaseManager;
            UpdateUIBasedOnUserRole();
        }

        private void UpdateUIBasedOnUserRole()
        {
            string currentUserRole = UserRoles.CurrentUserRole;

            if (currentUserRole == "user")
            {
                btn_receive5.Enabled = false;
                btn_receive5.Visible = false;
                btn_edit5.Enabled = false;
                btn_edit5.Visible = false;
                btn_add5.Enabled = false;
                btn_add5.Visible = false;
                btn_home5.Enabled = true;
                btn_table5.Enabled = true;
                btn_dev5.Enabled = false;
                btn_dev5.Visible = false;
            }
            else if (currentUserRole == "admin")
            {
                btn_home5.Enabled = true;
                btn_dev5.Enabled = false;
                btn_dev5.Visible = false;
                btn_edit5.Enabled = true;
                btn_add5.Enabled = true;
                btn_table5.Enabled = true;
            }
            else if (currentUserRole == "maintenance")
            {
                btn_home5.Enabled = true;
                btn_dev5.Enabled = true;
                btn_edit5.Enabled = true;
                btn_add5.Enabled = true;
                btn_table5.Enabled = true;
            }
        }

        private void update_btn3_Click(object sender, EventArgs e)
        {
            try
            {
                dbManager.OpenConnection();

                string query = "UPDATE spare_parts SET stock = stock - @stock5 WHERE part_id = @part_id";
                using (SqlCommand cmd = new SqlCommand(query, dbManager.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@part_id", part_id_txt5.Text);
                    decimal stockValue5 = 0;
                    if (decimal.TryParse(stock_txt5.Text, out stockValue5))
                    {
                        cmd.Parameters.AddWithValue("@stock5", stockValue5);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            string logMessage = "";

                            if (stockValue5 > 0)
                            {
                                logMessage = $"{loggedInUsername} updated record with part ID {part_id_txt5.Text} successfully with a reduction of {stockValue5} from the stock value of {stock_lbl.Text} at {DateTime.Now}";
                            }

                            LogChanges(logMessage);

                            MessageBox.Show("Record updated successfully!");
                            stock_txt5.Text = "";
                            stock_lbl.Text = (decimal.Parse(stock_lbl.Text) - stockValue5).ToString();
                        }
                        else
                        {
                            MessageBox.Show("Record not found!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid input for stock value!");
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

        private void LogChanges(string logMessage)
        {
            string logFilePath = @"C:\Inventory Logs\distribute_log.txt";
            int maxRows = 100;
            List<string> logLines = new List<string>();

            if (File.Exists(logFilePath))
            {
                using (StreamReader reader = new StreamReader(logFilePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        logLines.Add(line);
                    }
                }
            }

            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.WriteLine(logMessage);
            }

            if (logLines.Count > maxRows)
            {
                File.WriteAllLines(logFilePath, logLines.Skip(logLines.Count - maxRows));
            }
        }

        private void load_btn_Click(object sender, EventArgs e)
        {
            try
            {
                dbManager.OpenConnection();

                string query = "SELECT * FROM spare_parts WHERE part_id LIKE '%' + @part_id + '%'";
                using (SqlCommand cmd = new SqlCommand(query, dbManager.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@part_id", part_id_txt5.Text);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            part_name_lbl.Text = reader.GetString(1);
                            equip_name_lbl.Text = reader.GetString(2);
                            upper_lbl5.Text = reader.GetDecimal(3).ToString();
                            lower_lbl5.Text = reader.GetDecimal(4).ToString();
                            stock_lbl.Text = reader.GetDecimal(5).ToString();
                            description_lbl.Text = reader.GetString(6);

                            decimal stockValue;
                            if (decimal.TryParse(stock_lbl.Text, out stockValue) && decimal.TryParse(lower_lbl5.Text, out decimal lowerValue))
                            {
                                if (stockValue < lowerValue)
                                {
                                    MessageBox.Show("Stock value is less than lower limit!");
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Record not found!");
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

        private void Distribute_Load(object sender, EventArgs e)
        {
            string username = (this.Owner as login)?.LoggedInUsername;

            if (username != null)
            {
                user_lbl5.Text = $"Logged in user: {username}";
            }
            else
            {
                user_lbl5.Text = $"Unable to retrieve logged-in username.";
            }
        }


        private void btn_home5_Click(object sender, EventArgs e)
        {
            Dashboard home = new Dashboard(dbManager);
            home.Show();
            this.Hide();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit the application?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_table6_Click(object sender, EventArgs e)
        {
            string currentUserRole = UserRoles.CurrentUserRole;
            if (currentUserRole != "user") // Check user role here
            {
                Table table = new Table(dbManager);
                table.Show();
                this.Hide();
            }
        }

        private void btn_receive6_Click(object sender, EventArgs e)
        {
            Recieve recieve = new Recieve(dbManager);
            recieve.Show();
            this.Hide();
        }

        private void btn_edit6_Click(object sender, EventArgs e)
        {
            string currentUserRole = UserRoles.CurrentUserRole;
            if (currentUserRole != "user") // Check user role here
            {
                View view = new View(dbManager);
                view.Show();
                this.Hide();
            }
        }

        private void btn_add6_Click(object sender, EventArgs e)
        {
            string currentUserRole = UserRoles.CurrentUserRole;
            if (currentUserRole != "user") // Check user role here
            {
                Insert insert = new Insert(dbManager);
                insert.Show();
                this.Hide();
            }
        }

        private void btn_dev6_Click(object sender, EventArgs e)
        {
            dev_dash developer = new dev_dash(dbManager);
            developer.Show();
            this.Hide();
        }

        private void user_lbl5_Click(object sender, EventArgs e)
        {

        }
    }
}
