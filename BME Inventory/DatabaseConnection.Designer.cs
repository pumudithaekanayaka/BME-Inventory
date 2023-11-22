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
            label2 = new Label();
            label1 = new Label();
            conn_sql_btn = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // server_txt
            // 
            server_txt.Location = new Point(204, 37);
            server_txt.Name = "server_txt";
            server_txt.Size = new Size(469, 32);
            server_txt.TabIndex = 0;
            // 
            // db_txt
            // 
            db_txt.Location = new Point(204, 99);
            db_txt.Name = "db_txt";
            db_txt.Size = new Size(469, 32);
            db_txt.TabIndex = 1;
            // 
            // conn_btn
            // 
            conn_btn.BackColor = Color.CornflowerBlue;
            conn_btn.Location = new Point(477, 156);
            conn_btn.Name = "conn_btn";
            conn_btn.Size = new Size(192, 62);
            conn_btn.TabIndex = 2;
            conn_btn.Text = "Connect";
            conn_btn.UseVisualStyleBackColor = false;
            conn_btn.Click += conn_btn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.GhostWhite;
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
            label7.Font = new Font("Google Sans", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(12, 9);
            label7.Name = "label7";
            label7.Size = new Size(461, 35);
            label7.TabIndex = 1;
            label7.Text = "Enter Server Name and Database";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.GhostWhite;
            panel2.Controls.Add(conn_sql_btn);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(conn_btn);
            panel2.Controls.Add(db_txt);
            panel2.Controls.Add(server_txt);
            panel2.Dock = DockStyle.Top;
            panel2.Font = new Font("Google Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panel2.Location = new Point(0, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 244);
            panel2.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 106);
            label2.Name = "label2";
            label2.Size = new Size(157, 25);
            label2.TabIndex = 4;
            label2.Text = "Database Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 36);
            label1.Name = "label1";
            label1.Size = new Size(130, 25);
            label1.TabIndex = 3;
            label1.Text = "Server Name";
            // 
            // conn_sql_btn
            // 
            conn_sql_btn.BackColor = Color.CornflowerBlue;
            conn_sql_btn.Font = new Font("Google Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            conn_sql_btn.Location = new Point(279, 156);
            conn_sql_btn.Name = "conn_sql_btn";
            conn_sql_btn.Size = new Size(192, 62);
            conn_sql_btn.TabIndex = 5;
            conn_sql_btn.Text = "Connect to a different Sql Database";
            conn_sql_btn.UseVisualStyleBackColor = false;
            conn_sql_btn.Visible = false;
            // 
            // DatabaseConnection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
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
        private Button conn_sql_btn;
    }
}