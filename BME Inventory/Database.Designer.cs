namespace BME_Inventory
{
    partial class Database
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Database));
            export_btn = new Button();
            export_all_btn4 = new Button();
            dataGridView1 = new DataGridView();
            search_txt_database = new TextBox();
            search_btn_database = new Button();
            pnl_menu_dashboard = new Panel();
            btn_home_database = new Button();
            btn_dev_database = new Button();
            btn_edit_database = new Button();
            btn_adduser_database = new Button();
            btn_add_database = new Button();
            btn_receive_database = new Button();
            btn_distribute_database = new Button();
            pnl_home = new Panel();
            label6 = new Label();
            btn_logout_database = new Button();
            btn_exit_database = new Button();
            panel1 = new Panel();
            label7 = new Label();
            label1 = new Label();
            user_lbl_database = new Label();
            attention_btn_database = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            refresh_btn_database = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pnl_menu_dashboard.SuspendLayout();
            pnl_home.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // export_btn
            // 
            export_btn.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            export_btn.Location = new Point(839, 530);
            export_btn.Name = "export_btn";
            export_btn.Size = new Size(94, 29);
            export_btn.TabIndex = 2;
            export_btn.Text = "Export";
            export_btn.UseVisualStyleBackColor = true;
            export_btn.Click += mail_btn_Click;
            // 
            // export_all_btn4
            // 
            export_all_btn4.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            export_all_btn4.Location = new Point(839, 584);
            export_all_btn4.Name = "export_all_btn4";
            export_all_btn4.Size = new Size(94, 29);
            export_all_btn4.TabIndex = 4;
            export_all_btn4.Text = "Export All";
            export_all_btn4.UseVisualStyleBackColor = true;
            export_all_btn4.Click += export_all_btn4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(339, 149);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(915, 284);
            dataGridView1.TabIndex = 6;
            // 
            // search_txt_database
            // 
            search_txt_database.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            search_txt_database.Location = new Point(395, 85);
            search_txt_database.Name = "search_txt_database";
            search_txt_database.Size = new Size(450, 29);
            search_txt_database.TabIndex = 54;
            // 
            // search_btn_database
            // 
            search_btn_database.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            search_btn_database.Location = new Point(888, 81);
            search_btn_database.Name = "search_btn_database";
            search_btn_database.Size = new Size(110, 30);
            search_btn_database.TabIndex = 55;
            search_btn_database.Text = "Search";
            search_btn_database.UseVisualStyleBackColor = true;
            search_btn_database.Click += search_btn_database_Click;
            // 
            // pnl_menu_dashboard
            // 
            pnl_menu_dashboard.BackColor = Color.Azure;
            pnl_menu_dashboard.BackgroundImageLayout = ImageLayout.None;
            pnl_menu_dashboard.Controls.Add(btn_home_database);
            pnl_menu_dashboard.Controls.Add(btn_dev_database);
            pnl_menu_dashboard.Controls.Add(btn_edit_database);
            pnl_menu_dashboard.Controls.Add(btn_adduser_database);
            pnl_menu_dashboard.Controls.Add(btn_add_database);
            pnl_menu_dashboard.Controls.Add(btn_receive_database);
            pnl_menu_dashboard.Controls.Add(btn_distribute_database);
            pnl_menu_dashboard.Controls.Add(pnl_home);
            pnl_menu_dashboard.Controls.Add(btn_logout_database);
            pnl_menu_dashboard.Controls.Add(btn_exit_database);
            pnl_menu_dashboard.Dock = DockStyle.Left;
            pnl_menu_dashboard.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            pnl_menu_dashboard.Location = new Point(0, 0);
            pnl_menu_dashboard.Name = "pnl_menu_dashboard";
            pnl_menu_dashboard.Size = new Size(333, 723);
            pnl_menu_dashboard.TabIndex = 56;
            // 
            // btn_home_database
            // 
            btn_home_database.AutoSize = true;
            btn_home_database.Dock = DockStyle.Bottom;
            btn_home_database.FlatAppearance.BorderSize = 0;
            btn_home_database.FlatStyle = FlatStyle.Flat;
            btn_home_database.Image = (Image)resources.GetObject("btn_home_database.Image");
            btn_home_database.ImageAlign = ContentAlignment.MiddleLeft;
            btn_home_database.Location = new Point(0, 543);
            btn_home_database.Name = "btn_home_database";
            btn_home_database.Size = new Size(333, 60);
            btn_home_database.TabIndex = 18;
            btn_home_database.Text = "Home";
            btn_home_database.UseVisualStyleBackColor = true;
            btn_home_database.Click += btn_home_database_Click;
            // 
            // btn_dev_database
            // 
            btn_dev_database.Dock = DockStyle.Top;
            btn_dev_database.FlatAppearance.BorderSize = 0;
            btn_dev_database.FlatStyle = FlatStyle.Flat;
            btn_dev_database.Image = (Image)resources.GetObject("btn_dev_database.Image");
            btn_dev_database.ImageAlign = ContentAlignment.MiddleLeft;
            btn_dev_database.Location = new Point(0, 360);
            btn_dev_database.Name = "btn_dev_database";
            btn_dev_database.Size = new Size(333, 60);
            btn_dev_database.TabIndex = 17;
            btn_dev_database.Text = "Developer Mode";
            btn_dev_database.UseVisualStyleBackColor = true;
            btn_dev_database.Click += btn_dev_database_Click;
            // 
            // btn_edit_database
            // 
            btn_edit_database.Dock = DockStyle.Top;
            btn_edit_database.FlatAppearance.BorderSize = 0;
            btn_edit_database.FlatStyle = FlatStyle.Flat;
            btn_edit_database.Image = (Image)resources.GetObject("btn_edit_database.Image");
            btn_edit_database.ImageAlign = ContentAlignment.MiddleLeft;
            btn_edit_database.Location = new Point(0, 300);
            btn_edit_database.Name = "btn_edit_database";
            btn_edit_database.Size = new Size(333, 60);
            btn_edit_database.TabIndex = 16;
            btn_edit_database.Text = "Edit Entries";
            btn_edit_database.UseVisualStyleBackColor = true;
            btn_edit_database.Click += btn_edit_database_Click;
            // 
            // btn_adduser_database
            // 
            btn_adduser_database.Dock = DockStyle.Top;
            btn_adduser_database.FlatAppearance.BorderSize = 0;
            btn_adduser_database.FlatStyle = FlatStyle.Flat;
            btn_adduser_database.Image = (Image)resources.GetObject("btn_adduser_database.Image");
            btn_adduser_database.ImageAlign = ContentAlignment.MiddleLeft;
            btn_adduser_database.Location = new Point(0, 240);
            btn_adduser_database.Name = "btn_adduser_database";
            btn_adduser_database.Size = new Size(333, 60);
            btn_adduser_database.TabIndex = 15;
            btn_adduser_database.Text = "Add New";
            btn_adduser_database.UseVisualStyleBackColor = true;
            btn_adduser_database.Click += btn_adduser_database_Click;
            // 
            // btn_add_database
            // 
            btn_add_database.Dock = DockStyle.Top;
            btn_add_database.FlatAppearance.BorderSize = 0;
            btn_add_database.FlatStyle = FlatStyle.Flat;
            btn_add_database.Image = (Image)resources.GetObject("btn_add_database.Image");
            btn_add_database.ImageAlign = ContentAlignment.MiddleLeft;
            btn_add_database.Location = new Point(0, 180);
            btn_add_database.Name = "btn_add_database";
            btn_add_database.Size = new Size(333, 60);
            btn_add_database.TabIndex = 14;
            btn_add_database.Text = "Add New";
            btn_add_database.UseVisualStyleBackColor = true;
            btn_add_database.Click += btn_add_database_Click;
            // 
            // btn_receive_database
            // 
            btn_receive_database.Dock = DockStyle.Top;
            btn_receive_database.FlatAppearance.BorderSize = 0;
            btn_receive_database.FlatStyle = FlatStyle.Flat;
            btn_receive_database.Image = (Image)resources.GetObject("btn_receive_database.Image");
            btn_receive_database.ImageAlign = ContentAlignment.MiddleLeft;
            btn_receive_database.Location = new Point(0, 120);
            btn_receive_database.Name = "btn_receive_database";
            btn_receive_database.Size = new Size(333, 60);
            btn_receive_database.TabIndex = 13;
            btn_receive_database.Text = "Receive";
            btn_receive_database.UseVisualStyleBackColor = true;
            btn_receive_database.Click += btn_receive_database_Click;
            // 
            // btn_distribute_database
            // 
            btn_distribute_database.AutoSize = true;
            btn_distribute_database.Dock = DockStyle.Top;
            btn_distribute_database.FlatAppearance.BorderSize = 0;
            btn_distribute_database.FlatStyle = FlatStyle.Flat;
            btn_distribute_database.Image = (Image)resources.GetObject("btn_distribute_database.Image");
            btn_distribute_database.ImageAlign = ContentAlignment.MiddleLeft;
            btn_distribute_database.Location = new Point(0, 60);
            btn_distribute_database.Name = "btn_distribute_database";
            btn_distribute_database.Size = new Size(333, 60);
            btn_distribute_database.TabIndex = 12;
            btn_distribute_database.Text = "\r\nDistribute";
            btn_distribute_database.TextAlign = ContentAlignment.TopCenter;
            btn_distribute_database.UseVisualStyleBackColor = true;
            btn_distribute_database.Click += btn_distribute_database_Click;
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
            // btn_logout_database
            // 
            btn_logout_database.AutoSize = true;
            btn_logout_database.Dock = DockStyle.Bottom;
            btn_logout_database.FlatAppearance.BorderSize = 0;
            btn_logout_database.FlatStyle = FlatStyle.Flat;
            btn_logout_database.Image = (Image)resources.GetObject("btn_logout_database.Image");
            btn_logout_database.ImageAlign = ContentAlignment.MiddleLeft;
            btn_logout_database.Location = new Point(0, 603);
            btn_logout_database.Name = "btn_logout_database";
            btn_logout_database.Size = new Size(333, 60);
            btn_logout_database.TabIndex = 8;
            btn_logout_database.Text = "Log Out";
            btn_logout_database.UseVisualStyleBackColor = true;
            btn_logout_database.Click += btn_logout_database_Click;
            // 
            // btn_exit_database
            // 
            btn_exit_database.AutoSize = true;
            btn_exit_database.Dock = DockStyle.Bottom;
            btn_exit_database.FlatAppearance.BorderSize = 0;
            btn_exit_database.FlatStyle = FlatStyle.Flat;
            btn_exit_database.Image = (Image)resources.GetObject("btn_exit_database.Image");
            btn_exit_database.ImageAlign = ContentAlignment.MiddleLeft;
            btn_exit_database.Location = new Point(0, 663);
            btn_exit_database.Name = "btn_exit_database";
            btn_exit_database.Size = new Size(333, 60);
            btn_exit_database.TabIndex = 9;
            btn_exit_database.Text = "Exit";
            btn_exit_database.UseVisualStyleBackColor = true;
            btn_exit_database.Click += btn_exit_database_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Snow;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(user_lbl_database);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(333, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(921, 60);
            panel1.TabIndex = 57;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Fira Sans Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(17, 18);
            label7.Name = "label7";
            label7.Size = new Size(270, 24);
            label7.TabIndex = 1;
            label7.Text = "Inventory Database Table";
            label7.TextAlign = ContentAlignment.MiddleCenter;
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
            // user_lbl_database
            // 
            user_lbl_database.AutoSize = true;
            user_lbl_database.Font = new Font("Watch Applemint", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            user_lbl_database.Location = new Point(718, 18);
            user_lbl_database.Name = "user_lbl_database";
            user_lbl_database.Size = new Size(90, 22);
            user_lbl_database.TabIndex = 12;
            user_lbl_database.Text = "UserName";
            // 
            // attention_btn_database
            // 
            attention_btn_database.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            attention_btn_database.Location = new Point(839, 479);
            attention_btn_database.Name = "attention_btn_database";
            attention_btn_database.Size = new Size(94, 29);
            attention_btn_database.TabIndex = 19;
            attention_btn_database.Text = "Load";
            attention_btn_database.UseVisualStyleBackColor = true;
            attention_btn_database.Click += attention_btn_database_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(417, 487);
            label2.Name = "label2";
            label2.Size = new Size(248, 21);
            label2.TabIndex = 58;
            label2.Text = "Load The Items Need Attention";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(417, 538);
            label3.Name = "label3";
            label3.Size = new Size(398, 21);
            label3.TabIndex = 59;
            label3.Text = "Export The Items Need Attention To An Excel Sheet";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(417, 592);
            label4.Name = "label4";
            label4.Size = new Size(319, 21);
            label4.TabIndex = 60;
            label4.Text = "Export All of The Items To An Excel Sheet";
            // 
            // refresh_btn_database
            // 
            refresh_btn_database.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            refresh_btn_database.Location = new Point(417, 634);
            refresh_btn_database.Name = "refresh_btn_database";
            refresh_btn_database.Size = new Size(94, 29);
            refresh_btn_database.TabIndex = 61;
            refresh_btn_database.Text = "Refresh";
            refresh_btn_database.UseVisualStyleBackColor = true;
            refresh_btn_database.Click += refresh_btn_database_Click;
            // 
            // Database
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1254, 723);
            Controls.Add(refresh_btn_database);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(attention_btn_database);
            Controls.Add(panel1);
            Controls.Add(pnl_menu_dashboard);
            Controls.Add(search_btn_database);
            Controls.Add(search_txt_database);
            Controls.Add(dataGridView1);
            Controls.Add(export_all_btn4);
            Controls.Add(export_btn);
            Font = new Font("Candara", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Database";
            Text = "Database";
            WindowState = FormWindowState.Maximized;
            Load += Table_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pnl_menu_dashboard.ResumeLayout(false);
            pnl_menu_dashboard.PerformLayout();
            pnl_home.ResumeLayout(false);
            pnl_home.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button export_btn;
        private Button export_all_btn4;
        private DataGridView dataGridView1;
        private TextBox search_txt_database;
        private Button search_btn_database;
        private Panel pnl_menu_dashboard;
        private Button btn_dev_database;
        private Button btn_edit_database;
        private Button btn_adduser_database;
        private Button btn_add_database;
        private Button btn_receive_database;
        private Button btn_distribute_database;
        private Panel pnl_home;
        private Button btn_logout_database;
        private Button btn_exit_database;
        private Panel panel1;
        private Label label7;
        private Label label1;
        private Label user_lbl_database;
        private Button btn_home_database;
        private Button attention_btn_database;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button refresh_btn_database;
        private Label label6;
    }
}