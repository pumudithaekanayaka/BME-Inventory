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
        }

        private void update_btn3_Click(object sender, EventArgs e)
        {
            try
            {
                dbManager.OpenConnection();

                string query = "UPDATE spare_parts SET stock = stock - @stock5 + @stock6 WHERE part_id = @part_id";
                using (SqlCommand cmd = new SqlCommand(query, dbManager.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@part_id", part_id_txt5.Text);
                    decimal stockValue5 = 0;
                    decimal stockValue6 = 0;
                    if (decimal.TryParse(stock_txt5.Text, out stockValue5) || decimal.TryParse(stock_txt6.Text, out stockValue6))
                    {
                        cmd.Parameters.AddWithValue("@stock5", stockValue5);
                        cmd.Parameters.AddWithValue("@stock6", stockValue6);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            string logMessage = "";

                            if (stockValue5 > 0 && stockValue6 > 0)
                            {
                                logMessage = $"{loggedInUsername} updated record with part ID {part_id_txt5.Text} successfully with an increase of {stockValue6} and a reduction from {stockValue5} to the stock value of {stock_lbl.Text} at {DateTime.Now}";
                            }
                            else if (stockValue5 > 0)
                            {
                                logMessage = $"{loggedInUsername} updated record with part ID {part_id_txt5.Text} successfully with a reduction of {stockValue5} from the stock value of {stock_lbl.Text} at {DateTime.Now}";
                            }
                            else
                            {
                                logMessage = $"{loggedInUsername} updated record with part ID {part_id_txt5.Text} successfully with an increase of {stockValue6} to the stock value of {stock_lbl.Text} at {DateTime.Now}";
                            }

                            LogChanges(logMessage);

                            MessageBox.Show("Record updated successfully!");
                            stock_txt5.Text = "";
                            stock_txt6.Text = "";
                            stock_lbl.Text = (decimal.Parse(stock_lbl.Text) - stockValue5 + stockValue6).ToString();
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
            string logFilePath = @"C:\Inventory Logs\mylog.txt";
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

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard home = new Dashboard(dbManager);
            home.Show();
            this.Hide();
        }

        private void Distribute_Load(object sender, EventArgs e)
        {
            // Load data as needed
        }
    }
}
