namespace BME_Inventory
{
    partial class AddUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            user_add_btn_add = new Button();
            password_txt_add = new TextBox();
            username_txt_add = new TextBox();
            confirm_password_txt_add = new TextBox();
            user_level_add = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            imageList1 = new ImageList(components);
            label1 = new Label();
            user_lbl_adduser = new Label();
            pnl_menu_dashboard = new Panel();
            btn_home_adduser = new Button();
            btn_dev_adduser = new Button();
            btn_edit_adduser = new Button();
            btn_add_adduser = new Button();
            btn_receive_adduser = new Button();
            btn_distribute_adduser = new Button();
            btn_database_adduser = new Button();
            pnl_home = new Panel();
            label6 = new Label();
            btn_logout_adduser = new Button();
            btn_exit_adduser = new Button();
            panel1 = new Panel();
            label7 = new Label();
            panel2 = new Panel();
            pnl_menu_dashboard.SuspendLayout();
            pnl_home.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // user_add_btn_add
            // 
            user_add_btn_add.FlatStyle = FlatStyle.System;
            user_add_btn_add.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            user_add_btn_add.Location = new Point(305, 240);
            user_add_btn_add.Name = "user_add_btn_add";
            user_add_btn_add.Size = new Size(145, 55);
            user_add_btn_add.TabIndex = 13;
            user_add_btn_add.Text = "Save User";
            user_add_btn_add.UseVisualStyleBackColor = true;
            user_add_btn_add.Click += login_btn_Click;
            // 
            // password_txt_add
            // 
            password_txt_add.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            password_txt_add.Location = new Point(305, 80);
            password_txt_add.Name = "password_txt_add";
            password_txt_add.Size = new Size(328, 29);
            password_txt_add.TabIndex = 12;
            // 
            // username_txt_add
            // 
            username_txt_add.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            username_txt_add.Location = new Point(305, 30);
            username_txt_add.Name = "username_txt_add";
            username_txt_add.Size = new Size(328, 29);
            username_txt_add.TabIndex = 11;
            // 
            // confirm_password_txt_add
            // 
            confirm_password_txt_add.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            confirm_password_txt_add.Location = new Point(305, 130);
            confirm_password_txt_add.Name = "confirm_password_txt_add";
            confirm_password_txt_add.Size = new Size(328, 29);
            confirm_password_txt_add.TabIndex = 14;
            // 
            // user_level_add
            // 
            user_level_add.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            user_level_add.FormattingEnabled = true;
            user_level_add.Items.AddRange(new object[] { "user", "admin", "maintenance" });
            user_level_add.Location = new Point(305, 180);
            user_level_add.Name = "user_level_add";
            user_level_add.Size = new Size(145, 29);
            user_level_add.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(105, 30);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 16;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(105, 80);
            label3.Name = "label3";
            label3.Size = new Size(83, 21);
            label3.TabIndex = 17;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(105, 130);
            label4.Name = "label4";
            label4.Size = new Size(150, 21);
            label4.TabIndex = 18;
            label4.Text = "Re-Type Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(105, 180);
            label5.Name = "label5";
            label5.Size = new Size(136, 21);
            label5.TabIndex = 19;
            label5.Text = "Select User Role";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "arrow-right_icon-icons.com_72375.png");
            imageList1.Images.SetKeyName(1, "burger_line_list_menu_nav_navigation_option_icon_123231.png");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Watch Applemint", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(603, 18);
            label1.Name = "label1";
            label1.Size = new Size(109, 22);
            label1.TabIndex = 13;
            label1.Text = "Logged in As";
            // 
            // user_lbl_adduser
            // 
            user_lbl_adduser.AutoSize = true;
            user_lbl_adduser.Font = new Font("Watch Applemint", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            user_lbl_adduser.Location = new Point(718, 18);
            user_lbl_adduser.Name = "user_lbl_adduser";
            user_lbl_adduser.Size = new Size(90, 22);
            user_lbl_adduser.TabIndex = 12;
            user_lbl_adduser.Text = "UserName";
            // 
            // pnl_menu_dashboard
            // 
            pnl_menu_dashboard.BackColor = Color.GhostWhite;
            pnl_menu_dashboard.BackgroundImageLayout = ImageLayout.None;
            pnl_menu_dashboard.Controls.Add(btn_home_adduser);
            pnl_menu_dashboard.Controls.Add(btn_dev_adduser);
            pnl_menu_dashboard.Controls.Add(btn_edit_adduser);
            pnl_menu_dashboard.Controls.Add(btn_add_adduser);
            pnl_menu_dashboard.Controls.Add(btn_receive_adduser);
            pnl_menu_dashboard.Controls.Add(btn_distribute_adduser);
            pnl_menu_dashboard.Controls.Add(btn_database_adduser);
            pnl_menu_dashboard.Controls.Add(pnl_home);
            pnl_menu_dashboard.Controls.Add(btn_logout_adduser);
            pnl_menu_dashboard.Controls.Add(btn_exit_adduser);
            pnl_menu_dashboard.Dock = DockStyle.Left;
            pnl_menu_dashboard.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            pnl_menu_dashboard.Location = new Point(0, 0);
            pnl_menu_dashboard.Name = "pnl_menu_dashboard";
            pnl_menu_dashboard.Size = new Size(333, 832);
            pnl_menu_dashboard.TabIndex = 20;
            // 
            // btn_home_adduser
            // 
            btn_home_adduser.AutoSize = true;
            btn_home_adduser.Dock = DockStyle.Bottom;
            btn_home_adduser.FlatAppearance.BorderSize = 0;
            btn_home_adduser.FlatStyle = FlatStyle.Flat;
            btn_home_adduser.Image = (Image)resources.GetObject("btn_home_adduser.Image");
            btn_home_adduser.ImageAlign = ContentAlignment.MiddleLeft;
            btn_home_adduser.Location = new Point(0, 652);
            btn_home_adduser.Name = "btn_home_adduser";
            btn_home_adduser.Size = new Size(333, 60);
            btn_home_adduser.TabIndex = 18;
            btn_home_adduser.Text = "Home";
            btn_home_adduser.UseVisualStyleBackColor = true;
            btn_home_adduser.Click += btn_home_adduser_Click;
            // 
            // btn_dev_adduser
            // 
            btn_dev_adduser.Dock = DockStyle.Top;
            btn_dev_adduser.FlatAppearance.BorderSize = 0;
            btn_dev_adduser.FlatStyle = FlatStyle.Flat;
            btn_dev_adduser.Image = (Image)resources.GetObject("btn_dev_adduser.Image");
            btn_dev_adduser.ImageAlign = ContentAlignment.MiddleLeft;
            btn_dev_adduser.Location = new Point(0, 360);
            btn_dev_adduser.Name = "btn_dev_adduser";
            btn_dev_adduser.Size = new Size(333, 60);
            btn_dev_adduser.TabIndex = 17;
            btn_dev_adduser.Text = "Developer Mode";
            btn_dev_adduser.UseVisualStyleBackColor = true;
            btn_dev_adduser.Click += btn_dev_adduser_Click_1;
            // 
            // btn_edit_adduser
            // 
            btn_edit_adduser.Dock = DockStyle.Top;
            btn_edit_adduser.FlatAppearance.BorderSize = 0;
            btn_edit_adduser.FlatStyle = FlatStyle.Flat;
            btn_edit_adduser.Image = (Image)resources.GetObject("btn_edit_adduser.Image");
            btn_edit_adduser.ImageAlign = ContentAlignment.MiddleLeft;
            btn_edit_adduser.Location = new Point(0, 300);
            btn_edit_adduser.Name = "btn_edit_adduser";
            btn_edit_adduser.Size = new Size(333, 60);
            btn_edit_adduser.TabIndex = 16;
            btn_edit_adduser.Text = "Edit Entries";
            btn_edit_adduser.UseVisualStyleBackColor = true;
            btn_edit_adduser.Click += btn_edit_adduser_Click;
            // 
            // btn_add_adduser
            // 
            btn_add_adduser.Dock = DockStyle.Top;
            btn_add_adduser.FlatAppearance.BorderSize = 0;
            btn_add_adduser.FlatStyle = FlatStyle.Flat;
            btn_add_adduser.Image = (Image)resources.GetObject("btn_add_adduser.Image");
            btn_add_adduser.ImageAlign = ContentAlignment.MiddleLeft;
            btn_add_adduser.Location = new Point(0, 240);
            btn_add_adduser.Name = "btn_add_adduser";
            btn_add_adduser.Size = new Size(333, 60);
            btn_add_adduser.TabIndex = 14;
            btn_add_adduser.Text = "Add New";
            btn_add_adduser.UseVisualStyleBackColor = true;
            btn_add_adduser.Click += btn_add_adduser_Click;
            // 
            // btn_receive_adduser
            // 
            btn_receive_adduser.Dock = DockStyle.Top;
            btn_receive_adduser.FlatAppearance.BorderSize = 0;
            btn_receive_adduser.FlatStyle = FlatStyle.Flat;
            btn_receive_adduser.Image = (Image)resources.GetObject("btn_receive_adduser.Image");
            btn_receive_adduser.ImageAlign = ContentAlignment.MiddleLeft;
            btn_receive_adduser.Location = new Point(0, 180);
            btn_receive_adduser.Name = "btn_receive_adduser";
            btn_receive_adduser.Size = new Size(333, 60);
            btn_receive_adduser.TabIndex = 13;
            btn_receive_adduser.Text = "Receive";
            btn_receive_adduser.UseVisualStyleBackColor = true;
            btn_receive_adduser.Click += btn_receive_adduser_Click;
            // 
            // btn_distribute_adduser
            // 
            btn_distribute_adduser.AutoSize = true;
            btn_distribute_adduser.Dock = DockStyle.Top;
            btn_distribute_adduser.FlatAppearance.BorderSize = 0;
            btn_distribute_adduser.FlatStyle = FlatStyle.Flat;
            btn_distribute_adduser.Image = (Image)resources.GetObject("btn_distribute_adduser.Image");
            btn_distribute_adduser.ImageAlign = ContentAlignment.MiddleLeft;
            btn_distribute_adduser.Location = new Point(0, 120);
            btn_distribute_adduser.Name = "btn_distribute_adduser";
            btn_distribute_adduser.Size = new Size(333, 60);
            btn_distribute_adduser.TabIndex = 12;
            btn_distribute_adduser.Text = "\r\nDistribute";
            btn_distribute_adduser.TextAlign = ContentAlignment.TopCenter;
            btn_distribute_adduser.UseVisualStyleBackColor = true;
            btn_distribute_adduser.Click += btn_distribute_adduser_Click;
            // 
            // btn_database_adduser
            // 
            btn_database_adduser.Dock = DockStyle.Top;
            btn_database_adduser.FlatAppearance.BorderSize = 0;
            btn_database_adduser.FlatStyle = FlatStyle.Flat;
            btn_database_adduser.Image = (Image)resources.GetObject("btn_database_adduser.Image");
            btn_database_adduser.ImageAlign = ContentAlignment.MiddleLeft;
            btn_database_adduser.Location = new Point(0, 60);
            btn_database_adduser.Name = "btn_database_adduser";
            btn_database_adduser.Size = new Size(333, 60);
            btn_database_adduser.TabIndex = 10;
            btn_database_adduser.Text = "Database";
            btn_database_adduser.UseVisualStyleBackColor = true;
            btn_database_adduser.Click += btn_database_adduser_Click;
            // 
            // pnl_home
            // 
            pnl_home.Controls.Add(label6);
            pnl_home.Dock = DockStyle.Top;
            pnl_home.Location = new Point(0, 0);
            pnl_home.Name = "pnl_home";
            pnl_home.Size = new Size(333, 60);
            pnl_home.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Fira Sans Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(12, 18);
            label6.Name = "label6";
            label6.Size = new Size(182, 24);
            label6.TabIndex = 0;
            label6.Text = "Navigation Panel";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_logout_adduser
            // 
            btn_logout_adduser.AutoSize = true;
            btn_logout_adduser.Dock = DockStyle.Bottom;
            btn_logout_adduser.FlatAppearance.BorderSize = 0;
            btn_logout_adduser.FlatStyle = FlatStyle.Flat;
            btn_logout_adduser.Image = (Image)resources.GetObject("btn_logout_adduser.Image");
            btn_logout_adduser.ImageAlign = ContentAlignment.MiddleLeft;
            btn_logout_adduser.Location = new Point(0, 712);
            btn_logout_adduser.Name = "btn_logout_adduser";
            btn_logout_adduser.Size = new Size(333, 60);
            btn_logout_adduser.TabIndex = 8;
            btn_logout_adduser.Text = "Log Out";
            btn_logout_adduser.UseVisualStyleBackColor = true;
            btn_logout_adduser.Click += btn_logout_adduser_Click;
            // 
            // btn_exit_adduser
            // 
            btn_exit_adduser.AutoSize = true;
            btn_exit_adduser.Dock = DockStyle.Bottom;
            btn_exit_adduser.FlatAppearance.BorderSize = 0;
            btn_exit_adduser.FlatStyle = FlatStyle.Flat;
            btn_exit_adduser.Image = (Image)resources.GetObject("btn_exit_adduser.Image");
            btn_exit_adduser.ImageAlign = ContentAlignment.MiddleLeft;
            btn_exit_adduser.Location = new Point(0, 772);
            btn_exit_adduser.Name = "btn_exit_adduser";
            btn_exit_adduser.Size = new Size(333, 60);
            btn_exit_adduser.TabIndex = 9;
            btn_exit_adduser.Text = "Exit";
            btn_exit_adduser.UseVisualStyleBackColor = true;
            btn_exit_adduser.Click += btn_exit_adduser_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Snow;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(user_lbl_adduser);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(333, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(853, 60);
            panel1.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Fira Sans Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(17, 18);
            label7.Name = "label7";
            label7.Size = new Size(243, 24);
            label7.TabIndex = 1;
            label7.Text = "Enter New User Details";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Ivory;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(confirm_password_txt_add);
            panel2.Controls.Add(password_txt_add);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(username_txt_add);
            panel2.Controls.Add(user_add_btn_add);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(user_level_add);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(333, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(853, 420);
            panel2.TabIndex = 22;
            // 
            // AddUser
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            AutoScroll = true;
            AutoSize = true;
            BackColor = Color.MintCream;
            ClientSize = new Size(1186, 832);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pnl_menu_dashboard);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddUser";
            Text = "Add New User";
            WindowState = FormWindowState.Maximized;
            Load += AddUser_Load;
            pnl_menu_dashboard.ResumeLayout(false);
            pnl_menu_dashboard.PerformLayout();
            pnl_home.ResumeLayout(false);
            pnl_home.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button user_add_btn_add;
        private TextBox password_txt_add;
        private TextBox username_txt_add;
        private TextBox confirm_password_txt_add;
        private ComboBox user_level_add;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ImageList imageList1;
        private Label label1;
        private Label user_lbl_adduser;
        private Panel pnl_menu_dashboard;
        private Button btn_dev_adduser;
        private Button btn_edit_adduser;
        private Button btn_add_adduser;
        private Button btn_receive_adduser;
        private Button btn_distribute_adduser;
        private Button btn_database_adduser;
        private Panel pnl_home;
        private Button btn_logout_adduser;
        private Button btn_exit_adduser;
        private Panel panel1;
        private Label label6;
        private Panel panel2;
        private Label label7;
        private Button btn_home_adduser;
    }
}