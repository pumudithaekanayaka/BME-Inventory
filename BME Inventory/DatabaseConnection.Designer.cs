namespace BME_Inventory
{
    partial class DatabaseConnection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseConnection));
            server_txt = new TextBox();
            db_txt = new TextBox();
            conn_btn = new Button();
            panel1 = new Panel();
            label7 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // server_txt
            // 
            server_txt.Location = new Point(250, 37);
            server_txt.Name = "server_txt";
            server_txt.Size = new Size(469, 29);
            server_txt.TabIndex = 0;
            // 
            // db_txt
            // 
            db_txt.Location = new Point(250, 99);
            db_txt.Name = "db_txt";
            db_txt.Size = new Size(469, 29);
            db_txt.TabIndex = 1;
            // 
            // conn_btn
            // 
            conn_btn.Location = new Point(363, 156);
            conn_btn.Name = "conn_btn";
            conn_btn.Size = new Size(192, 62);
            conn_btn.TabIndex = 2;
            conn_btn.Text = "Connect";
            conn_btn.UseVisualStyleBackColor = true;
            conn_btn.Click += conn_btn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Snow;
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 60);
            panel1.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Fira Sans Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(17, 18);
            label7.Name = "label7";
            label7.Size = new Size(343, 24);
            label7.TabIndex = 1;
            label7.Text = "Enter Server Name and Database";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FloralWhite;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(conn_btn);
            panel2.Controls.Add(db_txt);
            panel2.Controls.Add(server_txt);
            panel2.Dock = DockStyle.Top;
            panel2.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            panel2.Location = new Point(0, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 244);
            panel2.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 36);
            label1.Name = "label1";
            label1.Size = new Size(111, 21);
            label1.TabIndex = 3;
            label1.Text = "Server Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 106);
            label2.Name = "label2";
            label2.Size = new Size(133, 21);
            label2.TabIndex = 4;
            label2.Text = "Database Name";
            // 
            // DatabaseConnection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DatabaseConnection";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Connection Details";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox server_txt;
        private TextBox db_txt;
        private Button conn_btn;
        private Panel panel1;
        private Label label7;
        private Panel panel2;
        private Label label2;
        private Label label1;
    }
}