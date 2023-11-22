using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.SqlClient;
using System.IO;

namespace BME_Inventory
{
    public partial class Distribute : Form
    {
        private DatabaseManager dbManager;

        public Distribute(DatabaseManager databaseManager)
        {
            InitializeComponent();
            dbManager = databaseManager;
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
        }

        private void update_btn3_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(book_txt_distribute.Text))
                {
                    MessageBox.Show("Book ID is required!");
                    return;
                }

                dbManager.OpenConnection();

                string query = "UPDATE inventory SET stock = stock - @stock5 WHERE part_id = @part_id";
                using (SqlCommand cmd = new SqlCommand(query, dbManager.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@part_id", part_id_txt5.Text);
                    cmd.Parameters.AddWithValue("@book_id", book_txt_distribute.Text);

                    decimal stockValue5 = 0;

                    if (decimal.TryParse(stock_txt5.Text, out stockValue5))
                    {
                        cmd.Parameters.AddWithValue("@stock5", stockValue5);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            string logMessage = $"{user_lbl_distribution} updated record with part ID {part_id_txt5.Text} successfully with a reduction of {stockValue5} from the stock value of {stock_lbl.Text} at {DateTime.Now}, the Book page ID of the 500 book is {book_combo_distribute.SelectedItem?.ToString()} / {book_txt_distribute.Text}";
                            LogChanges(logMessage);


                            string distributionQuery = "INSERT INTO distribution (part_id, make, model, equip_name, issued_by, issued_quantity, time, book_page_id) VALUES (@part_id, @make, @model, @equip_name, @issued_by, @issued_quantity, @time, @book_page_id)";
                            using (SqlCommand distributionCmd = new SqlCommand(distributionQuery, dbManager.GetConnection()))
                            {
                                distributionCmd.Parameters.AddWithValue("@book_page_id", book_txt_distribute.Text + book_combo_distribute.SelectedItem?.ToString() ?? "");
                                distributionCmd.Parameters.AddWithValue("@part_id", part_id_txt5.Text);
                                distributionCmd.Parameters.AddWithValue("@make", make_lbl.Text);
                                distributionCmd.Parameters.AddWithValue("@model", model_lbl.Text);
                                distributionCmd.Parameters.AddWithValue("@equip_name", equip_name_lbl.Text);
                                distributionCmd.Parameters.AddWithValue("@issued_by", user_lbl_distribution);
                                distributionCmd.Parameters.AddWithValue("@issued_quantity", stockValue5);
                                distributionCmd.Parameters.AddWithValue("@time", DateTime.Now);

                                int distributionRowsAffected = distributionCmd.ExecuteNonQuery();

                                if (distributionRowsAffected > 0)
                                {
                                    MessageBox.Show("Data distributed and logged successfully!");
                                    stock_txt5.Text = "";
                                    stock_lbl.Text = (decimal.Parse(stock_lbl.Text) - stockValue5).ToString();
                                }
                                else
                                {
                                    MessageBox.Show("Failed to log distribution data!");
                                }
                            }
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
            string documentsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string logFolderPath = Path.Combine(documentsFolder, "Inventory Logs/Distribution Logs");
            string logFilePath = Path.Combine(logFolderPath, $"Distribution_log_{DateTime.Now:yyyyMMdd}.txt");
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

                string query = "SELECT * FROM inventory WHERE part_id LIKE '%' + @part_id + '%'";
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
                            make_lbl.Text = reader.GetString(7);
                            model_lbl.Text = reader.GetString(8);

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

        private void btn_database_distribute_Click(object sender, EventArgs e)
        {
            Database database = new Database(dbManager);
            database.Show();
            this.Hide();
        }

        private void btn_receive_distribute_Click(object sender, EventArgs e)
        {
            Recieve recieve = new Recieve(dbManager);
            recieve.Show();
            this.Hide();
        }

        private void btn_add_distribute_Click(object sender, EventArgs e)
        {
            Create create = new Create(dbManager);
            create.Show();
            this.Hide();
        }

        private void btn_adduser_distribute_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser(dbManager);
            addUser.Show();
            this.Hide();
        }

        private void btn_edit_distribute_Click(object sender, EventArgs e)
        {
            Edit edit = new Edit(dbManager);
            edit.Show();
            this.Hide();
        }

        private void btn_dev_dashboard_Click(object sender, EventArgs e)
        {
            DeveloperDashboard developerDashboard = new DeveloperDashboard(dbManager);
            developerDashboard.Show();
            this.Hide();
        }

        private void btn_home_distribute_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(dbManager);
            dashboard.Show();
            this.Hide();
        }

        private void btn_logout_distribute_Click(object sender, EventArgs e)
        {
            this.Close();
            Login loginForm = new Login(dbManager);
            loginForm.Show();
        }

        private void btn_exit_distribute_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit the application?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Distribute_Load(object sender, EventArgs e)
        {
            string username = CurrentUser.Username;

            if (username != null)
            {
                user_lbl_distribution.Text = $"{username}";
            }
            else
            {
                user_lbl_distribution.Text = $"Unable to retrieve username.";
            }
        }
    }
}
