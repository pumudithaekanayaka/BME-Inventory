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
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-F8T5T4R\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True");

        public View()
        {
            InitializeComponent();
        }

        void populate()
        {
            connection.Open();
            SqlCommand command = new SqlCommand("select * from spare_parts", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            SqlCommandBuilder cb = new SqlCommandBuilder(adapter);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
            populate();
        }

        private void load_btn_Click(object sender, EventArgs e)
        {

        }


        private void View_Load(object sender, EventArgs e)
        {
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
