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
            dataGridView1 = new DataGridView();
            export_btn = new Button();
            exit_btn4 = new Button();
            mail_btn4 = new Button();
            home_btn4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(889, 260);
            dataGridView1.TabIndex = 0;
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
            // mail_btn4
            // 
            mail_btn4.Location = new Point(92, 336);
            mail_btn4.Name = "mail_btn4";
            mail_btn4.Size = new Size(93, 38);
            mail_btn4.TabIndex = 4;
            mail_btn4.Text = "Mail";
            mail_btn4.UseVisualStyleBackColor = true;
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
            // Table
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1082, 630);
            Controls.Add(home_btn4);
            Controls.Add(mail_btn4);
            Controls.Add(exit_btn4);
            Controls.Add(export_btn);
            Controls.Add(dataGridView1);
            Font = new Font("Candara", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Table";
            Text = "Table";
            Load += Table_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button export_btn;
        private Button exit_btn4;
        private Button mail_btn4;
        private Button home_btn4;
    }
}