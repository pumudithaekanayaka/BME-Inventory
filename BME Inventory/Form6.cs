using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BME_Inventory
{
    public partial class Dashboard : Form
    {
        private DatabaseManager dbManager;
        private string username;

        public Dashboard(DatabaseManager databaseManager)
        {
            InitializeComponent();
            dbManager = databaseManager;
            UpdateUIBasedOnUserRole();
        }

        private void UpdateUIBasedOnUserRole()
        {
            string currentUserRole = UserRoles.CurrentUserRole;

            if (currentUserRole == "user")
            {
                btn_distribute.Enabled = false;
                btn_edit.Enabled = false;
                btn_add.Enabled = false;
                btn_table.Enabled = true;
            }
            else if (currentUserRole == "admin")
            {
                btn_distribute.Enabled = true;
                btn_edit.Enabled = true;
                btn_add.Enabled = true;
                btn_table.Enabled = true;
            }
            else if (currentUserRole == "maintenance")
            {
                btn_distribute.Enabled = true;
                btn_edit.Enabled = true;
                btn_add.Enabled = true;
                btn_table.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string currentUserRole = UserRoles.CurrentUserRole;
            if (currentUserRole != "user") // Check user role here
            {
                Distribute distribute = new Distribute(dbManager);
                distribute.Show();
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string currentUserRole = UserRoles.CurrentUserRole;
            if (currentUserRole != "user") // Check user role here
            {
                View view = new View(dbManager);
                view.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string currentUserRole = UserRoles.CurrentUserRole;
            if (currentUserRole != "user") // Check user role here
            {
                Insert insert = new Insert(dbManager);
                insert.Show();
                this.Hide();
            }
        }

        private void table_btn6_Click(object sender, EventArgs e)
        {
            string currentUserRole = UserRoles.CurrentUserRole;
            if (currentUserRole != "user") // Check user role here
            {
                Table table = new Table(dbManager);
                table.Show();
                this.Hide();
            }
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

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // Add your initialization code if needed.
        }

        private void btn_receive_Click(object sender, EventArgs e)
        {
            Recieve recieve = new Recieve(dbManager);
            recieve.Show();
            this.Hide();
        }
    }
}
