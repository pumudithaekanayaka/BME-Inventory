using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BME_Inventory
{
    public partial class Insert : Form
    {
        private const string ConnectionString = "Data Source=ASUS_X512JA\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True";

        private SqlConnection con;
        private SqlCommand cmd;

        public Insert()
        {
            InitializeComponent();

            con = new SqlConnection(ConnectionString);
            cmd = new SqlCommand("", con);
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                cmd.CommandText = "INSERT INTO spare_parts(part_id, part_name, equip_name, upper, lower, stock, description, make, model) " + "VALUES(@part_id, @part_name, @equip_name, @upper, @lower, @stock, @description, @make, @model)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@part_id", part_id_txt.Text);
                cmd.Parameters.AddWithValue("@part_name", part_name_txt.Text);
                cmd.Parameters.AddWithValue("@equip_name", equip_name_txt.Text);
                cmd.Parameters.AddWithValue("@upper", upper_txt.Text);
                cmd.Parameters.AddWithValue("@lower", lower_txt.Text);
                cmd.Parameters.AddWithValue("@stock", stock_txt.Text);
                cmd.Parameters.AddWithValue("@description", desc_txt.Text);
                cmd.Parameters.AddWithValue("@make", make_combo1.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@model", model_combo1.SelectedItem.ToString());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Entry Successfully Updated");

                ClearTextBoxes(this);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void ClearTextBoxes(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                else
                {
                    ClearTextBoxes(c);
                }
            }
        }

        private void view_btn_Click(object sender, EventArgs e)
        {
            View view = new View();
            view.Show();
            this.Hide();
        }

        private void load_btn_Click(object sender, EventArgs e)
        {
            Show_Data show_data = new Show_Data();
            show_data.Show();
            this.Hide();
        }

        private void home_btn1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void make_btn1_Click(object sender, EventArgs e)
        {

        }
    }
}
