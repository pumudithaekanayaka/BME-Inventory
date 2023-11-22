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
            Desktop_pnl_dashboard = new Panel();
            log_lbl_dashboard = new Label();
            label3 = new Label();
            label1 = new Label();
            btn_received_logs = new Button();
            dateTimePicker1 = new DateTimePicker();
            btn_distribute_logs = new Button();
            refresh_btn_dashboard = new Button();
            dataGridView1 = new DataGridView();
            Desktop_pnl_dashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Desktop_pnl_dashboard
            // 
            Desktop_pnl_dashboard.Controls.Add(log_lbl_dashboard);
            Desktop_pnl_dashboard.Controls.Add(label3);
            Desktop_pnl_dashboard.Controls.Add(label1);
            Desktop_pnl_dashboard.Controls.Add(btn_received_logs);
            Desktop_pnl_dashboard.Controls.Add(dateTimePicker1);
            Desktop_pnl_dashboard.Controls.Add(btn_distribute_logs);
            Desktop_pnl_dashboard.Controls.Add(refresh_btn_dashboard);
            Desktop_pnl_dashboard.Controls.Add(dataGridView1);
            Desktop_pnl_dashboard.Dock = DockStyle.Fill;
            Desktop_pnl_dashboard.Location = new Point(0, 0);
            Desktop_pnl_dashboard.Name = "Desktop_pnl_dashboard";
            Desktop_pnl_dashboard.Size = new Size(1315, 879);
            Desktop_pnl_dashboard.TabIndex = 30;
            // 
            // log_lbl_dashboard
            // 
            log_lbl_dashboard.AutoEllipsis = true;
            log_lbl_dashboard.AutoSize = true;
            log_lbl_dashboard.BorderStyle = BorderStyle.FixedSingle;
            log_lbl_dashboard.FlatStyle = FlatStyle.Flat;
            log_lbl_dashboard.Font = new Font("Google Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            log_lbl_dashboard.Location = new Point(36, 483);
            log_lbl_dashboard.Name = "log_lbl_dashboard";
            log_lbl_dashboard.Size = new Size(70, 27);
            log_lbl_dashboard.TabIndex = 37;
            log_lbl_dashboard.Text = "Log Data";
            log_lbl_dashboard.TextAlign = ContentAlignment.MiddleLeft;
            log_lbl_dashboard.UseCompatibleTextRendering = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(40, 378);
            label3.Name = "label3";
            label3.Size = new Size(261, 21);
            label3.TabIndex = 36;
            label3.Text = "Click Here to Get Recieved Logs";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(40, 333);
            label1.Name = "label1";
            label1.Size = new Size(279, 21);
            label1.TabIndex = 35;
            label1.Text = "Click Here to Get Distribution Logs";
            // 
            // btn_received_logs
            // 
            btn_received_logs.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_received_logs.Location = new Point(325, 372);
            btn_received_logs.Name = "btn_received_logs";
            btn_received_logs.Size = new Size(102, 32);
            btn_received_logs.TabIndex = 34;
            btn_received_logs.Text = "Load";
            btn_received_logs.UseVisualStyleBackColor = true;
            btn_received_logs.Click += btn_received_logs_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(40, 430);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(327, 29);
            dateTimePicker1.TabIndex = 33;
            // 
            // btn_distribute_logs
            // 
            btn_distribute_logs.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_distribute_logs.Location = new Point(325, 326);
            btn_distribute_logs.Name = "btn_distribute_logs";
            btn_distribute_logs.Size = new Size(102, 32);
            btn_distribute_logs.TabIndex = 32;
            btn_distribute_logs.Text = "Load";
            btn_distribute_logs.UseVisualStyleBackColor = true;
            btn_distribute_logs.Click += btn_distribute_logs_Click;
            // 
            // refresh_btn_dashboard
            // 
            refresh_btn_dashboard.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            refresh_btn_dashboard.Location = new Point(66, 222);
            refresh_btn_dashboard.Name = "refresh_btn_dashboard";
            refresh_btn_dashboard.Size = new Size(102, 32);
            refresh_btn_dashboard.TabIndex = 31;
            refresh_btn_dashboard.Text = "Refresh";
            refresh_btn_dashboard.UseVisualStyleBackColor = true;
            refresh_btn_dashboard.Click += refresh_btn_dashboard_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.ControlLightLight;
            dataGridView1.Location = new Point(36, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(904, 153);
            dataGridView1.TabIndex = 30;
            // 
            // Dashboard
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoScroll = true;
            AutoSize = true;
            BackColor = Color.Snow;
            ClientSize = new Size(1315, 879);
            Controls.Add(Desktop_pnl_dashboard);
            Font = new Font("Nunito", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Dashboard";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "Dashboard";
            TransparencyKey = Color.Cyan;
            WindowState = FormWindowState.Maximized;
            Desktop_pnl_dashboard.ResumeLayout(false);
            Desktop_pnl_dashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel Desktop_pnl_dashboard;
        private Label log_lbl_dashboard;
        private Label label3;
        private Label label1;
        private Button btn_received_logs;
        private DateTimePicker dateTimePicker1;
        private Button btn_distribute_logs;
        private Button refresh_btn_dashboard;
        private DataGridView dataGridView1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}