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
        private login loginForm;

        public Dashboard(DatabaseManager databaseManager)
        {
            InitializeComponent();
            dbManager = databaseManager;
            this.loginForm = loginForm;
            UpdateUIBasedOnUserRole();
        }

        private void UpdateUIBasedOnUserRole()
        {
            string currentUserRole = UserRoles.CurrentUserRole;

            if (currentUserRole == "user")
            {
                btn_receive.Enabled = false;
                btn_receive.Visible = false;
                btn_edit.Enabled = false;
                btn_edit.Visible = false;
                btn_add.Enabled = false;
                btn_add.Visible = false;
                btn_table.Enabled = true;
                btn_dev6.Enabled = false;
                btn_dev6.Visible = false;
            }
            else if (currentUserRole == "admin")
            {
                btn_distribute.Enabled = true;
                btn_dev6.Enabled = false;
                btn_dev6.Visible = false;
                btn_edit.Enabled = true;
                btn_add.Enabled = true;
                btn_table.Enabled = true;
            }
            else if (currentUserRole == "maintenance")
            {
                btn_distribute.Enabled = true;
                btn_dev6.Enabled = true;
                btn_edit.Enabled = true;
                btn_add.Enabled = true;
                btn_table.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string currentUserRole = UserRoles.CurrentUserRole;
            if (currentUserRole != "user")
            {
                Distribute distribute = new Distribute(dbManager);
                distribute.Show();
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string currentUserRole = UserRoles.CurrentUserRole;
            if (currentUserRole != "user")
            {
                View view = new View(dbManager);
                view.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string currentUserRole = UserRoles.CurrentUserRole;
            if (currentUserRole != "user")
            {
                Insert insert = new Insert(dbManager);
                insert.Show();
                this.Hide();
            }
        }

        private void table_btn6_Click(object sender, EventArgs e)
        {
            string currentUserRole = UserRoles.CurrentUserRole;
            if (currentUserRole != "user")
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

        private void Dashboard_Load(object sender, EventArgs e)
        {
            string username = loginForm.LoggedInUsername;

            if (username != null)
            {
                user_lbl6.Text = $"Logged in user: {username}";
            }
            else
            {
                user_lbl6.Text = $"Unable to retrieve logged-in username.";
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
