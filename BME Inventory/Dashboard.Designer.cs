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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            btn_distribute_dashboard = new Button();
            btn_add_dashboard = new Button();
            btn_edit_dashboard = new Button();
            btn_exit_dashboard = new Button();
            label1 = new Label();
            btn_table_dashboard = new Button();
            panel1 = new Panel();
            btn_dev_dashboard = new Button();
            btn_receive_dashboard = new Button();
            user_lbl_dashboard = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_distribute_dashboard
            // 
            btn_distribute_dashboard.FlatAppearance.BorderSize = 0;
            btn_distribute_dashboard.FlatStyle = FlatStyle.Flat;
            btn_distribute_dashboard.Image = (Image)resources.GetObject("btn_distribute_dashboard.Image");
            btn_distribute_dashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btn_distribute_dashboard.Location = new Point(12, 157);
            btn_distribute_dashboard.Name = "btn_distribute_dashboard";
            btn_distribute_dashboard.Size = new Size(322, 58);
            btn_distribute_dashboard.TabIndex = 0;
            btn_distribute_dashboard.Text = "Distribute";
            btn_distribute_dashboard.UseVisualStyleBackColor = true;
            btn_distribute_dashboard.Click += button1_Click;
            // 
            // btn_add_dashboard
            // 
            btn_add_dashboard.FlatAppearance.BorderSize = 0;
            btn_add_dashboard.FlatStyle = FlatStyle.Flat;
            btn_add_dashboard.Image = (Image)resources.GetObject("btn_add_dashboard.Image");
            btn_add_dashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btn_add_dashboard.Location = new Point(16, 350);
            btn_add_dashboard.Name = "btn_add_dashboard";
            btn_add_dashboard.Size = new Size(319, 58);
            btn_add_dashboard.TabIndex = 1;
            btn_add_dashboard.Text = "Add New";
            btn_add_dashboard.UseVisualStyleBackColor = true;
            btn_add_dashboard.Click += button2_Click;
            // 
            // btn_edit_dashboard
            // 
            btn_edit_dashboard.FlatAppearance.BorderSize = 0;
            btn_edit_dashboard.FlatStyle = FlatStyle.Flat;
            btn_edit_dashboard.Image = (Image)resources.GetObject("btn_edit_dashboard.Image");
            btn_edit_dashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btn_edit_dashboard.Location = new Point(16, 286);
            btn_edit_dashboard.Name = "btn_edit_dashboard";
            btn_edit_dashboard.Size = new Size(319, 58);
            btn_edit_dashboard.TabIndex = 2;
            btn_edit_dashboard.Text = "Edit Entries";
            btn_edit_dashboard.UseVisualStyleBackColor = true;
            btn_edit_dashboard.Click += button3_Click;
            // 
            // btn_exit_dashboard
            // 
            btn_exit_dashboard.FlatAppearance.BorderSize = 0;
            btn_exit_dashboard.FlatStyle = FlatStyle.Flat;
            btn_exit_dashboard.Image = (Image)resources.GetObject("btn_exit_dashboard.Image");
            btn_exit_dashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btn_exit_dashboard.Location = new Point(12, 619);
            btn_exit_dashboard.Name = "btn_exit_dashboard";
            btn_exit_dashboard.Size = new Size(319, 58);
            btn_exit_dashboard.TabIndex = 5;
            btn_exit_dashboard.Text = "Exit";
            btn_exit_dashboard.UseVisualStyleBackColor = true;
            btn_exit_dashboard.Click += exit_btn6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nunito", 25.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 32);
            label1.Name = "label1";
            label1.Size = new Size(304, 59);
            label1.TabIndex = 4;
            label1.Text = "DASHBOARD";
            // 
            // btn_table_dashboard
            // 
            btn_table_dashboard.FlatAppearance.BorderSize = 0;
            btn_table_dashboard.FlatStyle = FlatStyle.Flat;
            btn_table_dashboard.Image = (Image)resources.GetObject("btn_table_dashboard.Image");
            btn_table_dashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btn_table_dashboard.Location = new Point(12, 104);
            btn_table_dashboard.Name = "btn_table_dashboard";
            btn_table_dashboard.Size = new Size(319, 58);
            btn_table_dashboard.TabIndex = 3;
            btn_table_dashboard.Text = "Show Table";
            btn_table_dashboard.UseVisualStyleBackColor = true;
            btn_table_dashboard.Click += table_btn6_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.AutoSize = true;
            panel1.BackColor = Color.Azure;
            panel1.Controls.Add(btn_dev_dashboard);
            panel1.Controls.Add(btn_receive_dashboard);
            panel1.Controls.Add(btn_exit_dashboard);
            panel1.Controls.Add(btn_distribute_dashboard);
            panel1.Controls.Add(btn_edit_dashboard);
            panel1.Controls.Add(btn_add_dashboard);
            panel1.Controls.Add(btn_table_dashboard);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(341, 689);
            panel1.TabIndex = 9;
            // 
            // btn_dev_dashboard
            // 
            btn_dev_dashboard.FlatAppearance.BorderSize = 0;
            btn_dev_dashboard.FlatStyle = FlatStyle.Flat;
            btn_dev_dashboard.Image = (Image)resources.GetObject("btn_dev_dashboard.Image");
            btn_dev_dashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btn_dev_dashboard.Location = new Point(15, 414);
            btn_dev_dashboard.Name = "btn_dev_dashboard";
            btn_dev_dashboard.Size = new Size(319, 58);
            btn_dev_dashboard.TabIndex = 7;
            btn_dev_dashboard.Text = "Developer Mode";
            btn_dev_dashboard.UseVisualStyleBackColor = true;
            btn_dev_dashboard.Click += btn_dev6_Click;
            // 
            // btn_receive_dashboard
            // 
            btn_receive_dashboard.FlatAppearance.BorderSize = 0;
            btn_receive_dashboard.FlatStyle = FlatStyle.Flat;
            btn_receive_dashboard.Image = (Image)resources.GetObject("btn_receive_dashboard.Image");
            btn_receive_dashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btn_receive_dashboard.Location = new Point(16, 222);
            btn_receive_dashboard.Name = "btn_receive_dashboard";
            btn_receive_dashboard.Size = new Size(322, 58);
            btn_receive_dashboard.TabIndex = 6;
            btn_receive_dashboard.Text = "Receive";
            btn_receive_dashboard.UseVisualStyleBackColor = true;
            btn_receive_dashboard.Click += btn_receive_Click;
            // 
            // user_lbl_dashboard
            // 
            user_lbl_dashboard.AutoSize = true;
            user_lbl_dashboard.Location = new Point(693, 44);
            user_lbl_dashboard.Name = "user_lbl_dashboard";
            user_lbl_dashboard.Size = new Size(80, 20);
            user_lbl_dashboard.TabIndex = 10;
            user_lbl_dashboard.Text = "UserName";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1287, 689);
            Controls.Add(user_lbl_dashboard);
            Controls.Add(panel1);
            Font = new Font("Nunito", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            TransparencyKey = Color.Cyan;
            WindowState = FormWindowState.Maximized;
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_distribute_dashboard;
        private Button btn_add_dashboard;
        private Button btn_edit_dashboard;
        private Label label1;
        private Button btn_table_dashboard;
        private Button btn_exit_dashboard;
        private Panel panel1;
        private Button btn_receive_dashboard;
        private Button btn_dev_dashboard;
        private Label user_lbl_dashboard;
    }
}