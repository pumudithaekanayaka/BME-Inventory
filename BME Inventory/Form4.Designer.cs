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
            load_btn3 = new Button();
            mail_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 39);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(621, 246);
            dataGridView1.TabIndex = 0;
            // 
            // load_btn3
            // 
            load_btn3.Location = new Point(74, 317);
            load_btn3.Name = "load_btn3";
            load_btn3.Size = new Size(93, 36);
            load_btn3.TabIndex = 1;
            load_btn3.Text = "Load";
            load_btn3.UseVisualStyleBackColor = true;
            load_btn3.Click += load_btn3_Click;
            // 
            // mail_btn
            // 
            mail_btn.Location = new Point(191, 317);
            mail_btn.Name = "mail_btn";
            mail_btn.Size = new Size(93, 36);
            mail_btn.TabIndex = 2;
            mail_btn.Text = "E-Mail";
            mail_btn.UseVisualStyleBackColor = true;
            mail_btn.Click += mail_btn_Click;
            // 
            // Table
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(686, 390);
            Controls.Add(mail_btn);
            Controls.Add(load_btn3);
            Controls.Add(dataGridView1);
            Font = new Font("Berlin Sans FB", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Table";
            Text = "Table";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button load_btn3;
        private Button mail_btn;
    }
}