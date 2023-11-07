using System;
using System.Windows.Forms;

namespace BME_Inventory
{
    public partial class AdminHome : Form
    {
        private DatabaseManager dbManager;

        public AdminHome(DatabaseManager databaseManager)
        {
            InitializeComponent();
            dbManager = databaseManager;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Distribute distribute = new Distribute(dbManager);
            distribute.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            View view = new View(dbManager);
            view.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Insert insert = new Insert(dbManager);
            insert.Show();
            this.Hide();
        }

        private void table_btn6_Click(object sender, EventArgs e)
        {
            Table table = new Table(dbManager);
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
            // Add your code to handle database connections if needed.
        }

        private void Home_Load(object sender, EventArgs e)
        {
            // Add your initialization code if needed.
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Recieve recieve = new Recieve(dbManager);
            recieve.Show();
            this.Hide();
        }
    }
}
