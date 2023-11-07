using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BME_Inventory
{
    public partial class View : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=ASUS_X512JA\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True");

        public View()
        {
            InitializeComponent();
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
            connection.Open();
            string query = "UPDATE spare_parts SET part_name = @part_name, equip_name = @equipment_name, stock = @stock, description = @description WHERE part_id = @part_id";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@part_id", part_id_txt1.Text);
            cmd.Parameters.AddWithValue("@part_name", part_name_txt1.Text);
            cmd.Parameters.AddWithValue("@equipment_name", equip_name_txt1.Text);
            cmd.Parameters.AddWithValue("@stock", stock_txt1.Text);
            cmd.Parameters.AddWithValue("@description", desc_txt1.Text);
            int rowsAffected = cmd.ExecuteNonQuery();
            connection.Close();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Record updated successfully!");
            }
            else
            {
                MessageBox.Show("Record not found!");
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            connection.Open();
            string query = "DELETE FROM spare_parts WHERE part_id = @part_id";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@part_id", part_id_txt1.Text);

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int rowsAffected = cmd.ExecuteNonQuery();
                connection.Close();

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
                // Redirect back to the main form (Insert)
                Hide();
                Insert form1 = new Insert();
                form1.Show();
            }
        }

        private void home_btn2_Click(object sender, EventArgs e)
        {
            // Navigate to the Home form
            Hide();
            Home home = new Home();
            home.Show();
        }

        // Other event handlers remain the same

    }
}
