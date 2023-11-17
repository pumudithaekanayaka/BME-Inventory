namespace BME_Inventory
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            btn_exit_dashboard = new Button();
            pnl_menu_dashboard = new Panel();
            btn_dev_dashboard = new Button();
            btn_edit_dashboard = new Button();
            btn_adduser_dashboard = new Button();
            btn_add_dashboard = new Button();
            btn_receive_dashboard = new Button();
            btn_distribute_dashboard = new Button();
            btn_database_dashboard = new Button();
            pnl_home = new Panel();
            label6 = new Label();
            btn_logout_dashboard = new Button();
            imageList1 = new ImageList(components);
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            label7 = new Label();
            label2 = new Label();
            user_lbl_dashboard = new Label();
            refresh_btn_dashboard = new Button();
            pnl_menu_dashboard.SuspendLayout();
            pnl_home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_exit_dashboard
            // 
            btn_exit_dashboard.AutoSize = true;
            btn_exit_dashboard.Dock = DockStyle.Bottom;
            btn_exit_dashboard.FlatAppearance.BorderSize = 0;
            btn_exit_dashboard.FlatStyle = FlatStyle.Flat;
            btn_exit_dashboard.Image = (Image)resources.GetObject("btn_exit_dashboard.Image");
            btn_exit_dashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btn_exit_dashboard.Location = new Point(0, 717);
            btn_exit_dashboard.Name = "btn_exit_dashboard";
            btn_exit_dashboard.Size = new Size(333, 60);
            btn_exit_dashboard.TabIndex = 9;
            btn_exit_dashboard.Text = "Exit";
            btn_exit_dashboard.UseVisualStyleBackColor = true;
            btn_exit_dashboard.Click += exit_btn6_Click;
            // 
            // pnl_menu_dashboard
            // 
            pnl_menu_dashboard.BackColor = Color.Azure;
            pnl_menu_dashboard.BackgroundImageLayout = ImageLayout.None;
            pnl_menu_dashboard.Controls.Add(btn_dev_dashboard);
            pnl_menu_dashboard.Controls.Add(btn_edit_dashboard);
            pnl_menu_dashboard.Controls.Add(btn_adduser_dashboard);
            pnl_menu_dashboard.Controls.Add(btn_add_dashboard);
            pnl_menu_dashboard.Controls.Add(btn_receive_dashboard);
            pnl_menu_dashboard.Controls.Add(btn_distribute_dashboard);
            pnl_menu_dashboard.Controls.Add(btn_database_dashboard);
            pnl_menu_dashboard.Controls.Add(pnl_home);
            pnl_menu_dashboard.Controls.Add(btn_logout_dashboard);
            pnl_menu_dashboard.Controls.Add(btn_exit_dashboard);
            pnl_menu_dashboard.Dock = DockStyle.Left;
            pnl_menu_dashboard.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            pnl_menu_dashboard.Location = new Point(0, 0);
            pnl_menu_dashboard.Name = "pnl_menu_dashboard";
            pnl_menu_dashboard.Size = new Size(333, 777);
            pnl_menu_dashboard.TabIndex = 9;
            // 
            // btn_dev_dashboard
            // 
            btn_dev_dashboard.Dock = DockStyle.Top;
            btn_dev_dashboard.FlatAppearance.BorderSize = 0;
            btn_dev_dashboard.FlatStyle = FlatStyle.Flat;
            btn_dev_dashboard.Image = (Image)resources.GetObject("btn_dev_dashboard.Image");
            btn_dev_dashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btn_dev_dashboard.Location = new Point(0, 420);
            btn_dev_dashboard.Name = "btn_dev_dashboard";
            btn_dev_dashboard.Size = new Size(333, 60);
            btn_dev_dashboard.TabIndex = 17;
            btn_dev_dashboard.Text = "Developer Mode";
            btn_dev_dashboard.UseVisualStyleBackColor = true;
            btn_dev_dashboard.Click += btn_dev_dashboard_Click;
            // 
            // btn_edit_dashboard
            // 
            btn_edit_dashboard.Dock = DockStyle.Top;
            btn_edit_dashboard.FlatAppearance.BorderSize = 0;
            btn_edit_dashboard.FlatStyle = FlatStyle.Flat;
            btn_edit_dashboard.Image = (Image)resources.GetObject("btn_edit_dashboard.Image");
            btn_edit_dashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btn_edit_dashboard.Location = new Point(0, 360);
            btn_edit_dashboard.Name = "btn_edit_dashboard";
            btn_edit_dashboard.Size = new Size(333, 60);
            btn_edit_dashboard.TabIndex = 16;
            btn_edit_dashboard.Text = "Edit Entries";
            btn_edit_dashboard.UseVisualStyleBackColor = true;
            btn_edit_dashboard.Click += btn_edit_dashboard_Click;
            // 
            // btn_adduser_dashboard
            // 
            btn_adduser_dashboard.Dock = DockStyle.Top;
            btn_adduser_dashboard.FlatAppearance.BorderSize = 0;
            btn_adduser_dashboard.FlatStyle = FlatStyle.Flat;
            btn_adduser_dashboard.Image = (Image)resources.GetObject("btn_adduser_dashboard.Image");
            btn_adduser_dashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btn_adduser_dashboard.Location = new Point(0, 300);
            btn_adduser_dashboard.Name = "btn_adduser_dashboard";
            btn_adduser_dashboard.Size = new Size(333, 60);
            btn_adduser_dashboard.TabIndex = 15;
            btn_adduser_dashboard.Text = "Add New";
            btn_adduser_dashboard.UseVisualStyleBackColor = true;
            btn_adduser_dashboard.Click += btn_adduser_dashboard_Click_1;
            // 
            // btn_add_dashboard
            // 
            btn_add_dashboard.Dock = DockStyle.Top;
            btn_add_dashboard.FlatAppearance.BorderSize = 0;
            btn_add_dashboard.FlatStyle = FlatStyle.Flat;
            btn_add_dashboard.Image = (Image)resources.GetObject("btn_add_dashboard.Image");
            btn_add_dashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btn_add_dashboard.Location = new Point(0, 240);
            btn_add_dashboard.Name = "btn_add_dashboard";
            btn_add_dashboard.Size = new Size(333, 60);
            btn_add_dashboard.TabIndex = 14;
            btn_add_dashboard.Text = "Add New";
            btn_add_dashboard.UseVisualStyleBackColor = true;
            btn_add_dashboard.Click += btn_add_dashboard_Click;
            // 
            // btn_receive_dashboard
            // 
            btn_receive_dashboard.Dock = DockStyle.Top;
            btn_receive_dashboard.FlatAppearance.BorderSize = 0;
            btn_receive_dashboard.FlatStyle = FlatStyle.Flat;
            btn_receive_dashboard.Image = (Image)resources.GetObject("btn_receive_dashboard.Image");
            btn_receive_dashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btn_receive_dashboard.Location = new Point(0, 180);
            btn_receive_dashboard.Name = "btn_receive_dashboard";
            btn_receive_dashboard.Size = new Size(333, 60);
            btn_receive_dashboard.TabIndex = 13;
            btn_receive_dashboard.Text = "Receive";
            btn_receive_dashboard.UseVisualStyleBackColor = true;
            btn_receive_dashboard.Click += btn_receive_dashboard_Click;
            // 
            // btn_distribute_dashboard
            // 
            btn_distribute_dashboard.AutoSize = true;
            btn_distribute_dashboard.Dock = DockStyle.Top;
            btn_distribute_dashboard.FlatAppearance.BorderSize = 0;
            btn_distribute_dashboard.FlatStyle = FlatStyle.Flat;
            btn_distribute_dashboard.Image = (Image)resources.GetObject("btn_distribute_dashboard.Image");
            btn_distribute_dashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btn_distribute_dashboard.Location = new Point(0, 120);
            btn_distribute_dashboard.Name = "btn_distribute_dashboard";
            btn_distribute_dashboard.Size = new Size(333, 60);
            btn_distribute_dashboard.TabIndex = 12;
            btn_distribute_dashboard.Text = "\r\nDistribute";
            btn_distribute_dashboard.TextAlign = ContentAlignment.TopCenter;
            btn_distribute_dashboard.UseVisualStyleBackColor = true;
            btn_distribute_dashboard.Click += btn_distribute_dashboard_Click;
            // 
            // btn_database_dashboard
            // 
            btn_database_dashboard.Dock = DockStyle.Top;
            btn_database_dashboard.FlatAppearance.BorderSize = 0;
            btn_database_dashboard.FlatStyle = FlatStyle.Flat;
            btn_database_dashboard.Image = (Image)resources.GetObject("btn_database_dashboard.Image");
            btn_database_dashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btn_database_dashboard.Location = new Point(0, 60);
            btn_database_dashboard.Name = "btn_database_dashboard";
            btn_database_dashboard.Size = new Size(333, 60);
            btn_database_dashboard.TabIndex = 10;
            btn_database_dashboard.Text = "Database";
            btn_database_dashboard.UseVisualStyleBackColor = true;
            btn_database_dashboard.Click += btn_table_dashboard_Click;
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
            // btn_logout_dashboard
            // 
            btn_logout_dashboard.AutoSize = true;
            btn_logout_dashboard.Dock = DockStyle.Bottom;
            btn_logout_dashboard.FlatAppearance.BorderSize = 0;
            btn_logout_dashboard.FlatStyle = FlatStyle.Flat;
            btn_logout_dashboard.Image = (Image)resources.GetObject("btn_logout_dashboard.Image");
            btn_logout_dashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btn_logout_dashboard.Location = new Point(0, 657);
            btn_logout_dashboard.Name = "btn_logout_dashboard";
            btn_logout_dashboard.Size = new Size(333, 60);
            btn_logout_dashboard.TabIndex = 8;
            btn_logout_dashboard.Text = "Log Out";
            btn_logout_dashboard.UseVisualStyleBackColor = true;
            btn_logout_dashboard.Click += btn_logout_dashboard_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "arrow-right_icon-icons.com_72375.png");
            imageList1.Images.SetKeyName(1, "hamburger_button_menu_icon_155296.png");
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.ControlLightLight;
            dataGridView1.Location = new Point(360, 75);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(904, 153);
            dataGridView1.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Snow;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(user_lbl_dashboard);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(333, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 60);
            panel1.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Fira Sans Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(17, 18);
            label7.Name = "label7";
            label7.Size = new Size(119, 24);
            label7.TabIndex = 1;
            label7.Text = "Dashboard";
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
            // user_lbl_dashboard
            // 
            user_lbl_dashboard.AutoSize = true;
            user_lbl_dashboard.Font = new Font("Watch Applemint", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            user_lbl_dashboard.Location = new Point(718, 18);
            user_lbl_dashboard.Name = "user_lbl_dashboard";
            user_lbl_dashboard.Size = new Size(90, 22);
            user_lbl_dashboard.TabIndex = 12;
            user_lbl_dashboard.Text = "UserName";
            // 
            // refresh_btn_dashboard
            // 
            refresh_btn_dashboard.Location = new Point(390, 270);
            refresh_btn_dashboard.Name = "refresh_btn_dashboard";
            refresh_btn_dashboard.Size = new Size(102, 32);
            refresh_btn_dashboard.TabIndex = 23;
            refresh_btn_dashboard.Text = "Refresh";
            refresh_btn_dashboard.UseVisualStyleBackColor = true;
            refresh_btn_dashboard.Click += refresh_btn_dashboard_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            BackColor = Color.Snow;
            ClientSize = new Size(1315, 777);
            Controls.Add(refresh_btn_dashboard);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(pnl_menu_dashboard);
            Font = new Font("Nunito", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Dashboard";
            Text = "Dashboard";
            TransparencyKey = Color.Cyan;
            WindowState = FormWindowState.Maximized;
            Load += Dashboard_Load;
            pnl_menu_dashboard.ResumeLayout(false);
            pnl_menu_dashboard.PerformLayout();
            pnl_home.ResumeLayout(false);
            pnl_home.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btn_exit_dashboard;
        private Panel pnl_menu_dashboard;
        private Label user_lbl_dashboard;
        private Button btn_logout_dashboard;
        private ImageList imageList1;
        private DataGridView dataGridView1;
        private Panel pnl_home;
        private Button btn_database_dashboard;
        private Button btn_dev_dashboard;
        private Button btn_edit_dashboard;
        private Button btn_adduser_dashboard;
        private Button btn_add_dashboard;
        private Button btn_receive_dashboard;
        private Button btn_distribute_dashboard;
        private Panel panel1;
        private Label label7;
        private Label label2;
        private Label user_lbl_adduser;
        private Label label6;
        private Button refresh_btn_dashboard;
    }
}