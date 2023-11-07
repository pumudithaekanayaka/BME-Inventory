using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BME_Inventory
{
    public partial class View : Form
    {
        private DatabaseManager dbManager;

        public View(DatabaseManager databaseManager)
        {
            InitializeComponent();
            dbManager = databaseManager;
        }

        private void LoadData()
        {
        }

        private void load_btn_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                dbManager.OpenConnection(); // Open the database connection using DatabaseManager

                string query = "UPDATE spare_parts SET part_name = @part_name, equip_name = @equipment_name, stock = @stock, description = @description WHERE part_id = @part_id";
                using (SqlCommand cmd = new SqlCommand(query, dbManager.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@part_id", part_id_txt1.Text);
                    cmd.Parameters.AddWithValue("@part_name", part_name_txt1.Text);
                    cmd.Parameters.AddWithValue("@equipment_name", equip_name_txt1.Text);
                    cmd.Parameters.AddWithValue("@stock", stock_txt1.Text);
                    cmd.Parameters.AddWithValue("@description", desc_txt1.Text);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record updated successfully!");
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
                dbManager.CloseConnection(); // Close the database connection using DatabaseManager
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                dbManager.OpenConnection(); // Open the database connection using DatabaseManager

                string query = "DELETE FROM spare_parts WHERE part_id = @part_id";
                using (SqlCommand cmd = new SqlCommand(query, dbManager.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@part_id", part_id_txt1.Text);

                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record deleted successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Record not found!");
                        }
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        Hide();
                        Insert form1 = new Insert(dbManager); // Pass the DatabaseManager object to the Insert form
                        form1.Show();
                    }
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

        private void home_btn2_Click(object sender, EventArgs e)
        {
            Hide();
            AdminHome home = new AdminHome(dbManager);
            home.Show();
        }
    }
}

