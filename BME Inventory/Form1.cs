using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace BME_Inventory
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-F8T5T4R\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True");

        public Form1()
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

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM spare_parts WHERE part_id = '" + part_id_txt.Text + "'",con);

        }
    }
}
