using System.Data.SqlClient;

namespace BME_Inventory
{
    public partial class Show_Data : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=ASUS_X512JA\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True");
        public Show_Data()
        {
            InitializeComponent();
        }

        private void load_btn_Click(object sender, EventArgs e)
        {
            connection.Open();
            string query = "SELECT * FROM spare_parts WHERE part_id LIKE '%' + @part_id + '%' OR part_name LIKE '%' + @part_name + '%' OR equip_name LIKE '%' + @equip_name + '%';";
            SqlCommand cmd = new SqlCommand(query, connection);
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
                        MessageBox.Show("Stock value is less than lower limit!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Record not found!");
            }
            connection.Close();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Insert form1 = new Insert();
            form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Table table = new Table();
            table.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            distribute distribute = new distribute();
            distribute.Show();
            this.Hide();
        }
    }
}
