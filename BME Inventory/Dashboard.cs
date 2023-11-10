using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BME_Inventory
{
    public partial class Dashboard : Form
    {
        private DatabaseManager dbManager;
        private string loggedInUsername;
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
                btn_receive_dashboard.Enabled = false;
                btn_receive_dashboard.Visible = false;
                btn_edit_dashboard.Enabled = false;
                btn_edit_dashboard.Visible = false;
                btn_add_dashboard.Enabled = false;
                btn_add_dashboard.Visible = false;
                btn_table_dashboard.Enabled = true;
                btn_dev_dashboard.Enabled = false;
                btn_dev_dashboard.Visible = false;
            }
            else if (currentUserRole == "admin")
            {
                btn_distribute_dashboard.Enabled = true;
                btn_dev_dashboard.Enabled = false;
                btn_dev_dashboard.Visible = false;
                btn_edit_dashboard.Enabled = true;
                btn_add_dashboard.Enabled = true;
                btn_table_dashboard.Enabled = true;
            }
            else if (currentUserRole == "maintenance")
            {
                btn_distribute_dashboard.Enabled = true;
                btn_dev_dashboard.Enabled = true;
                btn_edit_dashboard.Enabled = true;
                btn_add_dashboard.Enabled = true;
                btn_table_dashboard.Enabled = true;
            }
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

        private void Dashboard_Load(object sender, EventArgs e)
        {
            string username = CurrentUser.Username;

            if (username != null)
            {
                user_lbl_dashboard.Text = $"Logged in user: {username}";
            }
            else
            {
                user_lbl_dashboard.Text = $"Unable to retrieve logged-in username.";
            }
        }


        private void btn_receive_Click(object sender, EventArgs e)
        {
            Recieve recieve = new Recieve(dbManager);
            recieve.Show();
            this.Hide();
        }

        private void btn_dev6_Click(object sender, EventArgs e)
        {
            dev_dash developer = new dev_dash(dbManager);
            developer.Show();
            this.Hide();
        }
    }
}
