using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BME_Inventory
{
    public partial class Recieve : Form
    {
        private DatabaseManager dbManager;

        public Recieve(DatabaseManager databaseManager)
        {
            InitializeComponent();
            dbManager = databaseManager;
        }

        private void load_btn_Click(object sender, EventArgs e)
        {
            try
            {
                dbManager.OpenConnection(); // Open the database connection using DatabaseManager

                string query = "SELECT * FROM spare_parts WHERE part_id LIKE '%' + @part_id + '%' OR part_name LIKE '%' + @part_name + '%' OR equip_name LIKE '%' + @equip_name + '%'";
                using (SqlCommand cmd = new SqlCommand(query, dbManager.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@part_id", part_id_txt2.Text);
                    cmd.Parameters.AddWithValue("@part_name", part_name_txt2.Text);
                    cmd.Parameters.AddWithValue("@equip_name", equip_name_txt2.Text);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            part_name_txt2.Text = reader.GetString(1);
                            equip_name_txt2.Text = reader.GetString(2);
                            upper_lbl2.Text = reader.GetDecimal(3).ToString();
                            lower_lbl2.Text = reader.GetDecimal(4).ToString();
                            stock_txt2.Text = reader.GetDecimal(5).ToString();
                            desc_txt2.Text = reader.GetString(6);

                            if (Convert.ToDecimal(stock_txt2.Text) < Convert.ToDecimal(lower_lbl2.Text))
                            {
                                MessageBox.Show("Stock value is less than the lower limit!");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Record not found!");
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                dbManager.CloseConnection(); // Close the database connection using DatabaseManager
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Hide();
            Insert form1 = new Insert(dbManager); // Pass the DatabaseManager object to the Insert form
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Table table = new Table(dbManager);
            table.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Hide();
            Distribute distribute = new Distribute(dbManager);
            distribute.Show();
        }
    }
}
