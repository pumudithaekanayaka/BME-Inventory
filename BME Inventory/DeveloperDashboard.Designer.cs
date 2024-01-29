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
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 17);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(695, 334);
            dataGridView1.TabIndex = 0;
            // 
            // firstrun_reset_btn_dev
            // 
            firstrun_reset_btn_dev.BackColor = Color.CornflowerBlue;
            firstrun_reset_btn_dev.FlatAppearance.BorderSize = 0;
            firstrun_reset_btn_dev.FlatStyle = FlatStyle.Flat;
            firstrun_reset_btn_dev.Location = new Point(17, 381);
            firstrun_reset_btn_dev.Name = "firstrun_reset_btn_dev";
            firstrun_reset_btn_dev.Size = new Size(122, 32);
            firstrun_reset_btn_dev.TabIndex = 24;
            firstrun_reset_btn_dev.Text = "Reset";
            firstrun_reset_btn_dev.UseVisualStyleBackColor = false;
            firstrun_reset_btn_dev.Click += firstrun_reset_btn_dev_Click;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(dataGridView1);
            materialCard1.Controls.Add(firstrun_reset_btn_dev);
            materialCard1.Depth = 0;
            materialCard1.Dock = DockStyle.Fill;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(0, 0);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(795, 474);
            materialCard1.TabIndex = 25;
            // 
            // DeveloperDashboard
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            BackColor = Color.MintCream;
            ClientSize = new Size(795, 474);
            Controls.Add(materialCard1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DeveloperDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Developer Dashboard";
            WindowState = FormWindowState.Maximized;
            Load += MaintenanceHome_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            materialCard1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button firstrun_reset_btn_dev;
        private MaterialSkin.Controls.MaterialCard materialCard1;
    }
}