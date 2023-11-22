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
            firstrun_reset_btn_dev = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(695, 334);
            dataGridView1.TabIndex = 0;
            // 
            // firstrun_reset_btn_dev
            // 
            firstrun_reset_btn_dev.BackColor = Color.CornflowerBlue;
            firstrun_reset_btn_dev.Location = new Point(22, 387);
            firstrun_reset_btn_dev.Name = "firstrun_reset_btn_dev";
            firstrun_reset_btn_dev.Size = new Size(122, 32);
            firstrun_reset_btn_dev.TabIndex = 24;
            firstrun_reset_btn_dev.Text = "Reset";
            firstrun_reset_btn_dev.UseVisualStyleBackColor = false;
            firstrun_reset_btn_dev.Click += firstrun_reset_btn_dev_Click;
            // 
            // DeveloperDashboard
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            AutoScroll = true;
            BackColor = Color.MintCream;
            ClientSize = new Size(1250, 669);
            Controls.Add(firstrun_reset_btn_dev);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DeveloperDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Developer Dashboard";
            WindowState = FormWindowState.Maximized;
            Load += MaintenanceHome_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button firstrun_reset_btn_dev;
    }
}