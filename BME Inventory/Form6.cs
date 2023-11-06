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
    public partial class Home : Form
    {


        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Distribute distribute = new Distribute();
            distribute.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            View view = new View();
            view.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Insert insert = new Insert();
            insert.Show();
            this.Hide();
        }

        private void table_btn6_Click(object sender, EventArgs e)
        {
            Table table = new Table();
            table.Show();
            this.Hide();
        }

        private void exit_btn6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit the application?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void connect_btn6_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
