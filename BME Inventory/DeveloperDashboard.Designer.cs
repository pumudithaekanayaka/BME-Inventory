namespace BME_Inventory
{
    partial class DeveloperDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeveloperDashboard));
            dataGridView1 = new DataGridView();
            pnl_menu_dashboard = new Panel();
            home_btn_developer = new Button();
            btn_edit_developer = new Button();
            btn_adduser_developer = new Button();
            btn_add_developer = new Button();
            btn_receive_developer = new Button();
            btn_distribute_developer = new Button();
            btn_table_developer = new Button();
            pnl_home = new Panel();
            label6 = new Label();
            btn_logout_developer = new Button();
            btn_exit_developer = new Button();
            panel1 = new Panel();
            label7 = new Label();
            label2 = new Label();
            user_lbl_developer = new Label();
            firstrun_reset_btn_dev = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pnl_menu_dashboard.SuspendLayout();
            pnl_home.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.ControlLightLight;
            dataGridView1.Location = new Point(431, 82);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(695, 334);
            dataGridView1.TabIndex = 0;
            // 
            // pnl_menu_dashboard
            // 
            pnl_menu_dashboard.BackColor = Color.GhostWhite;
            pnl_menu_dashboard.BackgroundImageLayout = ImageLayout.None;
            pnl_menu_dashboard.Controls.Add(home_btn_developer);
            pnl_menu_dashboard.Controls.Add(btn_edit_developer);
            pnl_menu_dashboard.Controls.Add(btn_adduser_developer);
            pnl_menu_dashboard.Controls.Add(btn_add_developer);
            pnl_menu_dashboard.Controls.Add(btn_receive_developer);
            pnl_menu_dashboard.Controls.Add(btn_distribute_developer);
            pnl_menu_dashboard.Controls.Add(btn_table_developer);
            pnl_menu_dashboard.Controls.Add(pnl_home);
            pnl_menu_dashboard.Controls.Add(btn_logout_developer);
            pnl_menu_dashboard.Controls.Add(btn_exit_developer);
            pnl_menu_dashboard.Dock = DockStyle.Left;
            pnl_menu_dashboard.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            pnl_menu_dashboard.Location = new Point(0, 0);
            pnl_menu_dashboard.Name = "pnl_menu_dashboard";
            pnl_menu_dashboard.Size = new Size(333, 669);
            pnl_menu_dashboard.TabIndex = 10;
            // 
            // home_btn_developer
            // 
            home_btn_developer.AutoSize = true;
            home_btn_developer.Dock = DockStyle.Bottom;
            home_btn_developer.FlatAppearance.BorderSize = 0;
            home_btn_developer.FlatStyle = FlatStyle.Flat;
            home_btn_developer.Image = (Image)resources.GetObject("home_btn_developer.Image");
            home_btn_developer.ImageAlign = ContentAlignment.MiddleLeft;
            home_btn_developer.Location = new Point(0, 489);
            home_btn_developer.Name = "home_btn_developer";
            home_btn_developer.Size = new Size(333, 60);
            home_btn_developer.TabIndex = 17;
            home_btn_developer.Text = "Home";
            home_btn_developer.UseVisualStyleBackColor = true;
            home_btn_developer.Click += home_btn_developer_Click;
            // 
            // btn_edit_developer
            // 
            btn_edit_developer.Dock = DockStyle.Top;
            btn_edit_developer.FlatAppearance.BorderSize = 0;
            btn_edit_developer.FlatStyle = FlatStyle.Flat;
            btn_edit_developer.Image = (Image)resources.GetObject("btn_edit_developer.Image");
            btn_edit_developer.ImageAlign = ContentAlignment.MiddleLeft;
            btn_edit_developer.Location = new Point(0, 360);
            btn_edit_developer.Name = "btn_edit_developer";
            btn_edit_developer.Size = new Size(333, 60);
            btn_edit_developer.TabIndex = 16;
            btn_edit_developer.Text = "Edit Entries";
            btn_edit_developer.UseVisualStyleBackColor = true;
            btn_edit_developer.Click += btn_edit_developer_Click;
            // 
            // btn_adduser_developer
            // 
            btn_adduser_developer.Dock = DockStyle.Top;
            btn_adduser_developer.FlatAppearance.BorderSize = 0;
            btn_adduser_developer.FlatStyle = FlatStyle.Flat;
            btn_adduser_developer.Image = (Image)resources.GetObject("btn_adduser_developer.Image");
            btn_adduser_developer.ImageAlign = ContentAlignment.MiddleLeft;
            btn_adduser_developer.Location = new Point(0, 300);
            btn_adduser_developer.Name = "btn_adduser_developer";
            btn_adduser_developer.Size = new Size(333, 60);
            btn_adduser_developer.TabIndex = 15;
            btn_adduser_developer.Text = "Add New";
            btn_adduser_developer.UseVisualStyleBackColor = true;
            btn_adduser_developer.Click += btn_adduser_developer_Click;
            // 
            // btn_add_developer
            // 
            btn_add_developer.Dock = DockStyle.Top;
            btn_add_developer.FlatAppearance.BorderSize = 0;
            btn_add_developer.FlatStyle = FlatStyle.Flat;
            btn_add_developer.Image = (Image)resources.GetObject("btn_add_developer.Image");
            btn_add_developer.ImageAlign = ContentAlignment.MiddleLeft;
            btn_add_developer.Location = new Point(0, 240);
            btn_add_developer.Name = "btn_add_developer";
            btn_add_developer.Size = new Size(333, 60);
            btn_add_developer.TabIndex = 14;
            btn_add_developer.Text = "Add New";
            btn_add_developer.UseVisualStyleBackColor = true;
            btn_add_developer.Click += btn_add_developer_Click;
            // 
            // btn_receive_developer
            // 
            btn_receive_developer.Dock = DockStyle.Top;
            btn_receive_developer.FlatAppearance.BorderSize = 0;
            btn_receive_developer.FlatStyle = FlatStyle.Flat;
            btn_receive_developer.Image = (Image)resources.GetObject("btn_receive_developer.Image");
            btn_receive_developer.ImageAlign = ContentAlignment.MiddleLeft;
            btn_receive_developer.Location = new Point(0, 180);
            btn_receive_developer.Name = "btn_receive_developer";
            btn_receive_developer.Size = new Size(333, 60);
            btn_receive_developer.TabIndex = 13;
            btn_receive_developer.Text = "Receive";
            btn_receive_developer.UseVisualStyleBackColor = true;
            btn_receive_developer.Click += btn_receive_developer_Click;
            // 
            // btn_distribute_developer
            // 
            btn_distribute_developer.AutoSize = true;
            btn_distribute_developer.Dock = DockStyle.Top;
            btn_distribute_developer.FlatAppearance.BorderSize = 0;
            btn_distribute_developer.FlatStyle = FlatStyle.Flat;
            btn_distribute_developer.Image = (Image)resources.GetObject("btn_distribute_developer.Image");
            btn_distribute_developer.ImageAlign = ContentAlignment.MiddleLeft;
            btn_distribute_developer.Location = new Point(0, 120);
            btn_distribute_developer.Name = "btn_distribute_developer";
            btn_distribute_developer.Size = new Size(333, 60);
            btn_distribute_developer.TabIndex = 12;
            btn_distribute_developer.Text = "\r\nDistribute";
            btn_distribute_developer.TextAlign = ContentAlignment.TopCenter;
            btn_distribute_developer.UseVisualStyleBackColor = true;
            btn_distribute_developer.Click += btn_distribute_developer_Click;
            // 
            // btn_table_developer
            // 
            btn_table_developer.Dock = DockStyle.Top;
            btn_table_developer.FlatAppearance.BorderSize = 0;
            btn_table_developer.FlatStyle = FlatStyle.Flat;
            btn_table_developer.Image = (Image)resources.GetObject("btn_table_developer.Image");
            btn_table_developer.ImageAlign = ContentAlignment.MiddleLeft;
            btn_table_developer.Location = new Point(0, 60);
            btn_table_developer.Name = "btn_table_developer";
            btn_table_developer.Size = new Size(333, 60);
            btn_table_developer.TabIndex = 10;
            btn_table_developer.Text = "Database";
            btn_table_developer.UseVisualStyleBackColor = true;
            btn_table_developer.Click += btn_table_developer_Click;
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
            label6.Location = new Point(75, 18);
            label6.Name = "label6";
            label6.Size = new Size(182, 24);
            label6.TabIndex = 1;
            label6.Text = "Navigation Panel";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_logout_developer
            // 
            btn_logout_developer.AutoSize = true;
            btn_logout_developer.Dock = DockStyle.Bottom;
            btn_logout_developer.FlatAppearance.BorderSize = 0;
            btn_logout_developer.FlatStyle = FlatStyle.Flat;
            btn_logout_developer.Image = (Image)resources.GetObject("btn_logout_developer.Image");
            btn_logout_developer.ImageAlign = ContentAlignment.MiddleLeft;
            btn_logout_developer.Location = new Point(0, 549);
            btn_logout_developer.Name = "btn_logout_developer";
            btn_logout_developer.Size = new Size(333, 60);
            btn_logout_developer.TabIndex = 8;
            btn_logout_developer.Text = "Log Out";
            btn_logout_developer.UseVisualStyleBackColor = true;
            btn_logout_developer.Click += btn_logout_developer_Click;
            // 
            // btn_exit_developer
            // 
            btn_exit_developer.AutoSize = true;
            btn_exit_developer.Dock = DockStyle.Bottom;
            btn_exit_developer.FlatAppearance.BorderSize = 0;
            btn_exit_developer.FlatStyle = FlatStyle.Flat;
            btn_exit_developer.Image = (Image)resources.GetObject("btn_exit_developer.Image");
            btn_exit_developer.ImageAlign = ContentAlignment.MiddleLeft;
            btn_exit_developer.Location = new Point(0, 609);
            btn_exit_developer.Name = "btn_exit_developer";
            btn_exit_developer.Size = new Size(333, 60);
            btn_exit_developer.TabIndex = 9;
            btn_exit_developer.Text = "Exit";
            btn_exit_developer.UseVisualStyleBackColor = true;
            btn_exit_developer.Click += btn_exit_developer_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Snow;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(user_lbl_developer);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(333, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(917, 60);
            panel1.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Fira Sans Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(17, 18);
            label7.Name = "label7";
            label7.Size = new Size(228, 24);
            label7.TabIndex = 1;
            label7.Text = "Developer Dashboard";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Watch Applemint", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(603, 18);
            label2.Name = "label2";
            label2.Size = new Size(109, 22);
            label2.TabIndex = 13;
            label2.Text = "Logged in As";
            // 
            // user_lbl_developer
            // 
            user_lbl_developer.AutoSize = true;
            user_lbl_developer.Font = new Font("Watch Applemint", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            user_lbl_developer.Location = new Point(718, 18);
            user_lbl_developer.Name = "user_lbl_developer";
            user_lbl_developer.Size = new Size(90, 22);
            user_lbl_developer.TabIndex = 12;
            user_lbl_developer.Text = "UserName";
            // 
            // firstrun_reset_btn_dev
            // 
            firstrun_reset_btn_dev.Location = new Point(757, 487);
            firstrun_reset_btn_dev.Name = "firstrun_reset_btn_dev";
            firstrun_reset_btn_dev.Size = new Size(122, 32);
            firstrun_reset_btn_dev.TabIndex = 24;
            firstrun_reset_btn_dev.Text = "Reset";
            firstrun_reset_btn_dev.UseVisualStyleBackColor = true;
            firstrun_reset_btn_dev.Click += firstrun_reset_btn_dev_Click;
            // 
            // DeveloperDashboard
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            AutoScroll = true;
            BackColor = Color.MintCream;
            ClientSize = new Size(1250, 669);
            Controls.Add(firstrun_reset_btn_dev);
            Controls.Add(panel1);
            Controls.Add(pnl_menu_dashboard);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DeveloperDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Developer Dashboard";
            WindowState = FormWindowState.Maximized;
            Load += MaintenanceHome_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pnl_menu_dashboard.ResumeLayout(false);
            pnl_menu_dashboard.PerformLayout();
            pnl_home.ResumeLayout(false);
            pnl_home.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel pnl_menu_dashboard;
        private Button home_btn_developer;
        private Button btn_edit_developer;
        private Button btn_adduser_developer;
        private Button btn_add_developer;
        private Button btn_receive_developer;
        private Button btn_distribute_developer;
        private Button btn_table_developer;
        private Panel pnl_home;
        private Label label6;
        private Button btn_logout_developer;
        private Button btn_exit_developer;
        private Panel panel1;
        private Label label7;
        private Label label2;
        private Label user_lbl_developer;
        private Button firstrun_reset_btn_dev;
    }
}