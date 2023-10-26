using System.Data.SqlClient;

namespace BME_Inventory
{
    public partial class Insert : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ASUS_X512JA\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True");

        public Insert()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "insert into spare_parts(part_id, part_name, equip_name, upper, lower, stock, description) values(@part_id, @part_name, @equip_name, @upper, @lower, @stock, @description)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@part_id", part_id_txt.Text);
            cmd.Parameters.AddWithValue("@part_name", part_name_txt.Text);
            cmd.Parameters.AddWithValue("@equip_name", equip_name_txt.Text);
            cmd.Parameters.AddWithValue("@upper", upper_txt.Text);
            cmd.Parameters.AddWithValue("@lower", lower_txt.Text);
            cmd.Parameters.AddWithValue("@stock", stock_txt.Text);
            cmd.Parameters.AddWithValue("@description", desc_txt.Text);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Entry Successfully Updated");

                foreach (Control c in this.Controls)
                {
                    if (c is TextBox)
                    {
                        c.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
            finally { con.Close(); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
    }
}
