namespace BME_Inventory
{
    partial class Table
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
            export_btn = new Button();
            exit_btn4 = new Button();
            export_all_btn4 = new Button();
            home_btn4 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // export_btn
            // 
            export_btn.Location = new Point(191, 336);
            export_btn.Name = "export_btn";
            export_btn.Size = new Size(93, 38);
            export_btn.TabIndex = 2;
            export_btn.Text = "Export";
            export_btn.UseVisualStyleBackColor = true;
            export_btn.Click += mail_btn_Click;
            // 
            // exit_btn4
            // 
            exit_btn4.Location = new Point(389, 336);
            exit_btn4.Name = "exit_btn4";
            exit_btn4.Size = new Size(93, 38);
            exit_btn4.TabIndex = 3;
            exit_btn4.Text = "Exit";
            exit_btn4.UseVisualStyleBackColor = true;
            exit_btn4.Click += exit_btn4_Click;
            // 
            // export_all_btn4
            // 
            export_all_btn4.Location = new Point(92, 336);
            export_all_btn4.Name = "export_all_btn4";
            export_all_btn4.Size = new Size(93, 38);
            export_all_btn4.TabIndex = 4;
            export_all_btn4.Text = "Export All";
            export_all_btn4.UseVisualStyleBackColor = true;
            export_all_btn4.Click += export_all_btn4_Click;
            // 
            // home_btn4
            // 
            home_btn4.Location = new Point(290, 336);
            home_btn4.Name = "home_btn4";
            home_btn4.Size = new Size(93, 38);
            home_btn4.TabIndex = 5;
            home_btn4.Text = "Home";
            home_btn4.UseVisualStyleBackColor = true;
            home_btn4.Click += home_btn4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(62, 35);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(897, 284);
            dataGridView1.TabIndex = 6;
            // 
            // Table
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1082, 630);
            Controls.Add(dataGridView1);
            Controls.Add(home_btn4);
            Controls.Add(export_all_btn4);
            Controls.Add(exit_btn4);
            Controls.Add(export_btn);
            Font = new Font("Candara", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Table";
            Text = "Table";
            WindowState = FormWindowState.Maximized;
            Load += Table_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button export_btn;
        private Button exit_btn4;
        private Button export_all_btn4;
        private Button home_btn4;
        private DataGridView dataGridView1;
    }
}