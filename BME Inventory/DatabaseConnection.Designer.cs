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
            label7 = new Label();
            conn_sql_btn = new Button();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // server_txt
            // 
            server_txt.BorderStyle = BorderStyle.FixedSingle;
            server_txt.Location = new Point(198, 97);
            server_txt.Name = "server_txt";
            server_txt.Size = new Size(469, 27);
            server_txt.TabIndex = 0;
            // 
            // db_txt
            // 
            db_txt.BorderStyle = BorderStyle.FixedSingle;
            db_txt.Location = new Point(198, 159);
            db_txt.Name = "db_txt";
            db_txt.Size = new Size(469, 27);
            db_txt.TabIndex = 1;
            // 
            // conn_btn
            // 
            conn_btn.BackColor = Color.CornflowerBlue;
            conn_btn.FlatAppearance.BorderSize = 0;
            conn_btn.FlatStyle = FlatStyle.Flat;
            conn_btn.Location = new Point(471, 216);
            conn_btn.Name = "conn_btn";
            conn_btn.Size = new Size(192, 62);
            conn_btn.TabIndex = 2;
            conn_btn.Text = "Connect";
            conn_btn.UseVisualStyleBackColor = false;
            conn_btn.Click += conn_btn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Google Sans", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(10, 16);
            label7.Name = "label7";
            label7.Size = new Size(461, 35);
            label7.TabIndex = 1;
            label7.Text = "Enter Server Name and Database";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // conn_sql_btn
            // 
            conn_sql_btn.BackColor = Color.CornflowerBlue;
            conn_sql_btn.FlatAppearance.BorderSize = 0;
            conn_sql_btn.FlatStyle = FlatStyle.Flat;
            conn_sql_btn.Font = new Font("Google Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            conn_sql_btn.Location = new Point(273, 216);
            conn_sql_btn.Name = "conn_sql_btn";
            conn_sql_btn.Size = new Size(192, 62);
            conn_sql_btn.TabIndex = 5;
            conn_sql_btn.Text = "Connect to a different Sql Database";
            conn_sql_btn.UseVisualStyleBackColor = false;
            conn_sql_btn.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 166);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 4;
            label2.Text = "Database Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 96);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 3;
            label1.Text = "Server Name";
            // 
            // DatabaseConnection
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(758, 346);
            Controls.Add(label7);
            Controls.Add(conn_sql_btn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(db_txt);
            Controls.Add(conn_btn);
            Controls.Add(server_txt);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DatabaseConnection";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Connection Details";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox server_txt;
        private TextBox db_txt;
        private Button conn_btn;
        private Label label7;
        private Label label2;
        private Label label1;
        private Button conn_sql_btn;
    }
}