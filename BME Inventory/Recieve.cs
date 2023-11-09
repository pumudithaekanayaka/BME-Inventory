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
            string logFilePath = @"C:\Inventory Logs\recived_log.txt";
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

                string query = "UPDATE spare_parts SET stock = stock + @stock6 WHERE part_id = @part_id";
                using (SqlCommand cmd = new SqlCommand(query, dbManager.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@part_id", part_id_txt5.Text);
                    decimal stockValue6 = 0;
                    if (decimal.TryParse(stock_txt6.Text, out stockValue6))
                    {
                        cmd.Parameters.AddWithValue("@stock6", stockValue6);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            string logMessage = "";

                            if (stockValue6 > 0)
                            {
                                logMessage = $"{loggedInUsername} updated record with part ID {part_id_txt5.Text} successfully with an increase of {stockValue6} to the stock value of {stock_lbl.Text} at {DateTime.Now}";
                            }
                            LogChanges(logMessage);

                            MessageBox.Show("Record updated successfully!");
                            stock_txt6.Text = "";
                            stock_lbl.Text = (decimal.Parse(stock_lbl.Text) + stockValue6).ToString();
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

        private void btn_home3_Click(object sender, EventArgs e)
        {
            Dashboard home = new Dashboard(dbManager);
            home.Show();
            this.Hide();
        }
    }
}
