using System;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Bibliography;
using System.Runtime.InteropServices;

namespace BME_Inventory
{
    public partial class NavigationHome : Form
    {
        private DatabaseManager dbManager;
        private Form activeForm;
        private readonly Color TurquoiseColor = Color.DeepSkyBlue;
        private readonly Color WhiteColor = Color.GhostWhite;
        private const int SC_CLOSE = 0xF060;
        private const int MF_BYCOMMAND = 0x00000000;
        private readonly Color customTitleBarColor = Color.LightSkyBlue;

        public NavigationHome(DatabaseManager databaseManager)
        {
            InitializeComponent();
            InitializeCustomTitleBar();
            dbManager = databaseManager;
            UpdateUIBasedOnUserRole();
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.dll")]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32.dll")]
        private static extern int GetMenuItemCount(IntPtr hMenu);
        [DllImport("user32.dll")]
        private static extern bool DrawMenuBar(IntPtr hWnd);
        [DllImport("user32.dll")]
        private static extern bool RemoveMenu(IntPtr hMenu, int uPosition, int uFlags);

        private void InitializeCustomTitleBar()
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int count = GetMenuItemCount(hMenu);
            RemoveMenu(hMenu, count - 1, MF_BYCOMMAND);
            this.Paint += CustomForm_Paint;
        }

        private void CustomForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(customTitleBarColor), 0, 0, this.Width, SystemInformation.CaptionHeight);
        }

        private void UpdateUIBasedOnUserRole()
        {
            string currentUserRole = UserRoles.CurrentUserRole;

            Button[] buttons = { btn_receive_navhome, btn_edit_navhome, btn_add_navhome, btn_dev_navhome, btn_adduser_navhome };

            foreach (var button in buttons)
            {
                button.Visible = button.Enabled = true;
            }

            if (currentUserRole == "user")
            {
                foreach (var button in buttons)
                {
                    button.Visible = button.Enabled = false;
                }

                btn_database_navhome.Enabled = true;
            }
            else if (currentUserRole == "admin" || currentUserRole == "maintenance")
            {
                btn_distribute_navhome.Enabled = true;
                btn_edit_navhome.Enabled = true;
                btn_add_navhome.Enabled = true;
                btn_database_navhome.Enabled = true;
            }
        }

        private void HandleButtonClick(Form form, string title)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnl_home_navhome.Controls.Add(form);
            form.Show();
            title_lbl_navhome.Text = title;
        }

        private void SetButtonColors(Button button, Color backColor)
        {
            button.BackColor = backColor;
        }

        private void NavigationHome_Load(object sender, EventArgs e)
        {
            string username = CurrentUser.Username;

            user_lbl_navhome.Text = username != null ? $"{username}" : $"Unable to retrieve username.";

            Dashboard dashboard = new Dashboard(dbManager);

            HandleButtonClick(dashboard, "DashBoard");
            btn_database_navhome.Enabled = true;
            btn_receive_navhome.Enabled = true;
            btn_distribute_navhome.Enabled = true;
            btn_edit_navhome.Enabled = true;
            btn_adduser_navhome.Enabled = true;
            btn_add_navhome.Enabled = true;
            btn_dev_navhome.Enabled = true;
            btn_home_navhome.Enabled = false;

            SetButtonColors(btn_dev_navhome, TurquoiseColor);
            SetButtonColors(btn_database_navhome, TurquoiseColor);
            SetButtonColors(btn_receive_navhome, TurquoiseColor);
            SetButtonColors(btn_distribute_navhome, TurquoiseColor);
            SetButtonColors(btn_edit_navhome, TurquoiseColor);
            SetButtonColors(btn_adduser_navhome, TurquoiseColor);
            SetButtonColors(btn_add_navhome, TurquoiseColor);
            SetButtonColors(btn_home_navhome, WhiteColor);

        }

        private void btn_database_navhome_Click(object sender, EventArgs e)
        {
            Database database = new Database(dbManager);

            HandleButtonClick(database, "Database");

            btn_database_navhome.Enabled = false;
            btn_receive_navhome.Enabled = true;
            btn_distribute_navhome.Enabled = true;
            btn_edit_navhome.Enabled = true;
            btn_adduser_navhome.Enabled = true;
            btn_add_navhome.Enabled = true;
            btn_dev_navhome.Enabled = true;
            btn_home_navhome.Enabled = true;

            SetButtonColors(btn_dev_navhome, TurquoiseColor);
            SetButtonColors(btn_database_navhome, WhiteColor);
            SetButtonColors(btn_receive_navhome, TurquoiseColor);
            SetButtonColors(btn_distribute_navhome, TurquoiseColor);
            SetButtonColors(btn_edit_navhome, TurquoiseColor);
            SetButtonColors(btn_adduser_navhome, TurquoiseColor);
            SetButtonColors(btn_add_navhome, TurquoiseColor);
            SetButtonColors(btn_home_navhome, TurquoiseColor);
        }

        private void btn_distribute_navhome_Click(object sender, EventArgs e)
        {
            Distribute distribute = new Distribute(dbManager);

            HandleButtonClick(distribute, "Issue Form");

            btn_database_navhome.Enabled = true;
            btn_receive_navhome.Enabled = true;
            btn_distribute_navhome.Enabled = false;
            btn_edit_navhome.Enabled = true;
            btn_adduser_navhome.Enabled = true;
            btn_add_navhome.Enabled = true;
            btn_dev_navhome.Enabled = true;
            btn_home_navhome.Enabled = true;

            SetButtonColors(btn_dev_navhome, TurquoiseColor);
            SetButtonColors(btn_database_navhome, TurquoiseColor);
            SetButtonColors(btn_receive_navhome, TurquoiseColor);
            SetButtonColors(btn_distribute_navhome, WhiteColor);
            SetButtonColors(btn_edit_navhome, TurquoiseColor);
            SetButtonColors(btn_adduser_navhome, TurquoiseColor);
            SetButtonColors(btn_add_navhome, TurquoiseColor);
            SetButtonColors(btn_home_navhome, TurquoiseColor);
        }

        private void btn_receive_navhome_Click(object sender, EventArgs e)
        {
            Recieve recieve = new Recieve(dbManager);
            HandleButtonClick(recieve, "Distribution Form");

            btn_database_navhome.Enabled = true;
            btn_receive_navhome.Enabled = false;
            btn_distribute_navhome.Enabled = true;
            btn_edit_navhome.Enabled = true;
            btn_adduser_navhome.Enabled = true;
            btn_add_navhome.Enabled = true;
            btn_dev_navhome.Enabled = true;
            btn_home_navhome.Enabled = true;

            SetButtonColors(btn_dev_navhome, TurquoiseColor);
            SetButtonColors(btn_database_navhome, TurquoiseColor);
            SetButtonColors(btn_receive_navhome, WhiteColor);
            SetButtonColors(btn_distribute_navhome, TurquoiseColor);
            SetButtonColors(btn_edit_navhome, TurquoiseColor);
            SetButtonColors(btn_adduser_navhome, TurquoiseColor);
            SetButtonColors(btn_add_navhome, TurquoiseColor);
            SetButtonColors(btn_home_navhome, TurquoiseColor);
        }

        private void btn_add_navhome_Click(object sender, EventArgs e)
        {
            Create create = new Create(dbManager);
            HandleButtonClick(create, "Add New Item");

            btn_database_navhome.Enabled = true;
            btn_receive_navhome.Enabled = true;
            btn_distribute_navhome.Enabled = true;
            btn_edit_navhome.Enabled = true;
            btn_adduser_navhome.Enabled = true;
            btn_add_navhome.Enabled = false;
            btn_dev_navhome.Enabled = true;
            btn_home_navhome.Enabled = true;

            SetButtonColors(btn_dev_navhome, TurquoiseColor);
            SetButtonColors(btn_database_navhome, TurquoiseColor);
            SetButtonColors(btn_receive_navhome, TurquoiseColor);
            SetButtonColors(btn_distribute_navhome, TurquoiseColor);
            SetButtonColors(btn_edit_navhome, TurquoiseColor);
            SetButtonColors(btn_adduser_navhome, TurquoiseColor);
            SetButtonColors(btn_add_navhome, WhiteColor);
            SetButtonColors(btn_home_navhome, TurquoiseColor);
        }

        private void btn_adduser_navhome_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser(dbManager);
            HandleButtonClick(addUser, "Add New User");

            btn_database_navhome.Enabled = true;
            btn_receive_navhome.Enabled = true;
            btn_distribute_navhome.Enabled = true;
            btn_edit_navhome.Enabled = true;
            btn_adduser_navhome.Enabled = false;
            btn_add_navhome.Enabled = true;
            btn_dev_navhome.Enabled = true;
            btn_home_navhome.Enabled = true;

            SetButtonColors(btn_dev_navhome, TurquoiseColor);
            SetButtonColors(btn_database_navhome, TurquoiseColor);
            SetButtonColors(btn_receive_navhome, TurquoiseColor);
            SetButtonColors(btn_distribute_navhome, TurquoiseColor);
            SetButtonColors(btn_edit_navhome, TurquoiseColor);
            SetButtonColors(btn_adduser_navhome, WhiteColor);
            SetButtonColors(btn_add_navhome, TurquoiseColor);
            SetButtonColors(btn_home_navhome, TurquoiseColor);
        }

        private void btn_edit_nvahome_Click(object sender, EventArgs e)
        {
            Edit edit = new Edit(dbManager);
            HandleButtonClick(edit, "Edit Existing Item");

            btn_database_navhome.Enabled = true;
            btn_receive_navhome.Enabled = true;
            btn_distribute_navhome.Enabled = true;
            btn_edit_navhome.Enabled = false;
            btn_adduser_navhome.Enabled = true;
            btn_add_navhome.Enabled = true;
            btn_dev_navhome.Enabled = true;
            btn_home_navhome.Enabled = true;

            SetButtonColors(btn_dev_navhome, TurquoiseColor);
            SetButtonColors(btn_database_navhome, TurquoiseColor);
            SetButtonColors(btn_receive_navhome, TurquoiseColor);
            SetButtonColors(btn_distribute_navhome, TurquoiseColor);
            SetButtonColors(btn_edit_navhome, WhiteColor);
            SetButtonColors(btn_adduser_navhome, TurquoiseColor);
            SetButtonColors(btn_add_navhome, TurquoiseColor);
            SetButtonColors(btn_home_navhome, TurquoiseColor);
        }

        private void btn_dev_navhome_Click(object sender, EventArgs e)
        {
            DeveloperDashboard developerdashboard = new DeveloperDashboard(dbManager);
            HandleButtonClick(developerdashboard, "Developer Dashboard");

            btn_database_navhome.Enabled = true;
            btn_receive_navhome.Enabled = true;
            btn_distribute_navhome.Enabled = true;
            btn_edit_navhome.Enabled = true;
            btn_adduser_navhome.Enabled = true;
            btn_add_navhome.Enabled = true;
            btn_dev_navhome.Enabled = false;
            btn_home_navhome.Enabled = true;

            SetButtonColors(btn_dev_navhome, WhiteColor);
            SetButtonColors(btn_database_navhome, TurquoiseColor);
            SetButtonColors(btn_receive_navhome, TurquoiseColor);
            SetButtonColors(btn_distribute_navhome, TurquoiseColor);
            SetButtonColors(btn_edit_navhome, TurquoiseColor);
            SetButtonColors(btn_adduser_navhome, TurquoiseColor);
            SetButtonColors(btn_add_navhome, TurquoiseColor);
            SetButtonColors(btn_home_navhome, TurquoiseColor);
        }

        private void btn_home_navhome_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(dbManager);
            HandleButtonClick(dashboard, "Dashboard");

            btn_database_navhome.Enabled = true;
            btn_receive_navhome.Enabled = true;
            btn_distribute_navhome.Enabled = true;
            btn_edit_navhome.Enabled = true;
            btn_adduser_navhome.Enabled = true;
            btn_add_navhome.Enabled = true;
            btn_dev_navhome.Enabled = true;
            btn_home_navhome.Enabled = false;

            SetButtonColors(btn_dev_navhome, TurquoiseColor);
            SetButtonColors(btn_database_navhome, TurquoiseColor);
            SetButtonColors(btn_receive_navhome, TurquoiseColor);
            SetButtonColors(btn_distribute_navhome, TurquoiseColor);
            SetButtonColors(btn_edit_navhome, TurquoiseColor);
            SetButtonColors(btn_adduser_navhome, TurquoiseColor);
            SetButtonColors(btn_add_navhome, TurquoiseColor);
            SetButtonColors(btn_home_navhome, WhiteColor);
        }

        private void btn_logout_navhome_Click(object sender, EventArgs e)
        {
            this.Close();
            Login loginForm = new Login(dbManager);
            loginForm.Show();
        }

        private void btn_exit_navhome_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit the application?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
