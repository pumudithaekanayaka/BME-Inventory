namespace BME_Inventory
{
    partial class db_conn
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
            server_txt = new TextBox();
            db_txt = new TextBox();
            conn_btn = new Button();
            SuspendLayout();
            // 
            // server_txt
            // 
            server_txt.Location = new Point(131, 72);
            server_txt.Name = "server_txt";
            server_txt.Size = new Size(469, 27);
            server_txt.TabIndex = 0;
            // 
            // db_txt
            // 
            db_txt.Location = new Point(131, 134);
            db_txt.Name = "db_txt";
            db_txt.Size = new Size(469, 27);
            db_txt.TabIndex = 1;
            // 
            // conn_btn
            // 
            conn_btn.Location = new Point(244, 224);
            conn_btn.Name = "conn_btn";
            conn_btn.Size = new Size(192, 62);
            conn_btn.TabIndex = 2;
            conn_btn.Text = "Connect";
            conn_btn.UseVisualStyleBackColor = true;
            conn_btn.Click += conn_btn_Click;
            // 
            // db_conn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(conn_btn);
            Controls.Add(db_txt);
            Controls.Add(server_txt);
            Name = "db_conn";
            Text = "db_conn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox server_txt;
        private TextBox db_txt;
        private Button conn_btn;
    }
}