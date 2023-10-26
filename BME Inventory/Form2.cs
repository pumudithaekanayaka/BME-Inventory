using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void load_btn_Click(object sender, EventArgs e)
        {
            connection.Open();
            string query = "SELECT * FROM spare_parts WHERE part_id LIKE '%' + @part_id + '%'";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@part_id", part_id_txt1.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                dataGridView1.DataSource = table;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                if (dataGridView1.SelectedCells.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    part_name_txt1.Text = Convert.ToString(selectedRow.Cells[1].Value);
                    equip_name_txt1.Text = Convert.ToString(selectedRow.Cells[2].Value);
                    upper_lbl1.Text = Convert.ToString(selectedRow.Cells[3].Value);
                    lower_lbl1.Text = Convert.ToString(selectedRow.Cells[4].Value);
                    stock_txt1.Text = Convert.ToString(selectedRow.Cells[5].Value);
                    desc_txt1.Text = Convert.ToString(selectedRow.Cells[6].Value);
                }
            }
            else
            {
                MessageBox.Show("Record not found!");
            }
            connection.Close();
        }


        private void View_Load(object sender, EventArgs e)
        {
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Insert form1 = new Insert();
            form1.Show();
            this.Hide();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            connection.Open();
            string query = "UPDATE spare_parts SET part_name = @part_name, equip_name = @equipment_name, stock = @stock, description = @description WHERE part_id = @part_id";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@part_id", part_id_txt1.Text);
            cmd.Parameters.AddWithValue("@part_name", part_name_txt1.Text);
            cmd.Parameters.AddWithValue("@equipment_name", equip_name_txt1.Text);
            cmd.Parameters.AddWithValue("@stock", Convert.ToDecimal(stock_txt1.Text));
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
            connection.Close();
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
                Insert form1 = new Insert();
                form1.Show();
                this.Hide();
            }

        }
    }
}
