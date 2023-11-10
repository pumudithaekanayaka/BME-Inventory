using System.Data.SqlClient;

namespace BME_Inventory
{
    public partial class Recieve : Form
    {
        private DatabaseManager dbManager;
        private string loggedInUsername;
        private string username;

        public Recieve(DatabaseManager databaseManager)
        {
            InitializeComponent();
            dbManager = databaseManager;
        }
        private void LogChanges(string logMessage)
        {
            string logFilePath = $"C:\\Inventory Logs\\recieved_log_{DateTime.Now:yyyyMMdd}.txt";
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

        private void update_btn3_Click_1(object sender, EventArgs e)
        {
            try
            {
                dbManager.OpenConnection();

                string query = "UPDATE inventory SET stock = stock + @stock5 WHERE part_id = @part_id";
                using (SqlCommand cmd = new SqlCommand(query, dbManager.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@part_id", part_id_txt_recieve.Text);
                    decimal stockValue5 = 0;
                    if (decimal.TryParse(stock_txt_recieve.Text, out stockValue5))
                    {
                        cmd.Parameters.AddWithValue("@stock5", stockValue5);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            string logMessage = $"{user_lbl_recived.Text} updated record with part ID {part_id_txt_recieve.Text} successfully with a increase of {stockValue5} from the stock value of {stock_lbl.Text} at {DateTime.Now}";
                            LogChanges(logMessage);

                            string distributionQuery = "INSERT INTO recived (part_id, make, model, equip_name, add_by, add_quantity, time) VALUES (@part_id, @make, @model, @equip_name, @add_by, @add_quantity, @time)";
                            using (SqlCommand distributionCmd = new SqlCommand(distributionQuery, dbManager.GetConnection()))
                            {
                                distributionCmd.Parameters.AddWithValue("@part_id", part_id_txt_recieve.Text);
                                distributionCmd.Parameters.AddWithValue("@make", make_lbl_recieve.Text);
                                distributionCmd.Parameters.AddWithValue("@model", model_lbl_recieve.Text);
                                distributionCmd.Parameters.AddWithValue("@equip_name", equip_name_lbl_recieve.Text);
                                distributionCmd.Parameters.AddWithValue("@add_by", user_lbl_recived.Text);
                                distributionCmd.Parameters.AddWithValue("@add_quantity", stockValue5);
                                distributionCmd.Parameters.AddWithValue("@time", DateTime.Now);

                                int distributionRowsAffected = distributionCmd.ExecuteNonQuery();

                                if (distributionRowsAffected > 0)
                                {
                                    MessageBox.Show("Data recieved and logged successfully!");
                                    stock_txt_recieve.Text = "";
                                    stock_lbl.Text = (decimal.Parse(stock_lbl.Text) - stockValue5).ToString();
                                }
                                else
                                {
                                    MessageBox.Show("Failed to log recieve data!");
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

        private void load_btn3_Click(object sender, EventArgs e)
        {
            try
            {
                dbManager.OpenConnection();

                string query = "SELECT * FROM inventory WHERE part_id LIKE '%' + @part_id + '%'";
                using (SqlCommand cmd = new SqlCommand(query, dbManager.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@part_id", part_id_txt_recieve.Text);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            part_name_lbl_recieve.Text = reader.GetString(1);
                            equip_name_lbl_recieve.Text = reader.GetString(2);
                            upper_lbl_recieve.Text = reader.GetDecimal(3).ToString();
                            lower_lbl_recieve.Text = reader.GetDecimal(4).ToString();
                            stock_lbl.Text = reader.GetDecimal(5).ToString();
                            description_lbl_recieve.Text = reader.GetString(6);

                            decimal stockValue;
                            if (decimal.TryParse(stock_lbl.Text, out stockValue) && decimal.TryParse(lower_lbl_recieve.Text, out decimal lowerValue))
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

        private void btn_home3_Click(object sender, EventArgs e)
        {
            Dashboard home = new Dashboard(dbManager);
            home.Show();
            this.Hide();
        }

        private void Recieve_Load(object sender, EventArgs e)
        {
            string username = CurrentUser.Username;

            if (username != null)
            {
                user_lbl_recived.Text = $"{username}";
            }
            else
            {
                user_lbl_recived.Text = $"Unable to retrieve logged-in username.";
            }
        }
    }
}
