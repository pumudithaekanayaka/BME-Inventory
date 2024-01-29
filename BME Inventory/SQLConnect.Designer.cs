namespace BME_Inventory
{
    partial class SQLConnect
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
            server_add_txt = new TextBox();
            database_txt = new TextBox();
            username_txt = new TextBox();
            password_txt = new TextBox();
            sql_conn_btn = new Button();
            SuspendLayout();
            // 
            // server_add_txt
            // 
            server_add_txt.Location = new Point(180, 85);
            server_add_txt.Name = "server_add_txt";
            server_add_txt.Size = new Size(475, 27);
            server_add_txt.TabIndex = 0;
            // 
            // database_txt
            // 
            database_txt.Location = new Point(180, 139);
            database_txt.Name = "database_txt";
            database_txt.Size = new Size(475, 27);
            database_txt.TabIndex = 1;
            // 
            // username_txt
            // 
            username_txt.Location = new Point(180, 193);
            username_txt.Name = "username_txt";
            username_txt.Size = new Size(475, 27);
            username_txt.TabIndex = 2;
            // 
            // password_txt
            // 
            password_txt.Location = new Point(180, 248);
            password_txt.Name = "password_txt";
            password_txt.Size = new Size(475, 27);
            password_txt.TabIndex = 3;
            // 
            // sql_conn_btn
            // 
            sql_conn_btn.Location = new Point(497, 336);
            sql_conn_btn.Name = "sql_conn_btn";
            sql_conn_btn.Size = new Size(114, 43);
            sql_conn_btn.TabIndex = 4;
            sql_conn_btn.Text = "Connect";
            sql_conn_btn.UseVisualStyleBackColor = true;
            sql_conn_btn.Click += sql_conn_btn_Click;
            // 
            // SQLConnect
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(sql_conn_btn);
            Controls.Add(password_txt);
            Controls.Add(username_txt);
            Controls.Add(database_txt);
            Controls.Add(server_add_txt);
            Name = "SQLConnect";
            Text = "SQLConnect";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox server_add_txt;
        private TextBox database_txt;
        private TextBox username_txt;
        private TextBox password_txt;
        private Button sql_conn_btn;
    }
}