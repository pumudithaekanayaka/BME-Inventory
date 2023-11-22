namespace BME_Inventory
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            username_txt = new TextBox();
            password_txt = new TextBox();
            login_btn = new Button();
            panel1 = new Panel();
            label7 = new Label();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            chng_server_btn_login = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // username_txt
            // 
            username_txt.Location = new Point(149, 18);
            username_txt.Name = "username_txt";
            username_txt.Size = new Size(459, 32);
            username_txt.TabIndex = 0;
            // 
            // password_txt
            // 
            password_txt.Location = new Point(149, 79);
            password_txt.Name = "password_txt";
            password_txt.Size = new Size(459, 32);
            password_txt.TabIndex = 1;
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.CornflowerBlue;
            login_btn.Location = new Point(446, 145);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(149, 57);
            login_btn.TabIndex = 2;
            login_btn.Text = "Login";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.GhostWhite;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Google Sans Medium", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
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
            label7.Size = new Size(269, 35);
            label7.TabIndex = 1;
            label7.Text = "Enter Login Deatils";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 25);
            label1.Name = "label1";
            label1.Size = new Size(104, 25);
            label1.TabIndex = 24;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 86);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 25;
            label2.Text = "Password";
            // 
            // panel2
            // 
            panel2.BackColor = Color.GhostWhite;
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.Controls.Add(chng_server_btn_login);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(login_btn);
            panel2.Controls.Add(password_txt);
            panel2.Controls.Add(username_txt);
            panel2.Dock = DockStyle.Top;
            panel2.Font = new Font("Google Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panel2.Location = new Point(0, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 263);
            panel2.TabIndex = 26;
            // 
            // chng_server_btn_login
            // 
            chng_server_btn_login.BackColor = Color.CornflowerBlue;
            chng_server_btn_login.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            chng_server_btn_login.Location = new Point(626, 146);
            chng_server_btn_login.Name = "chng_server_btn_login";
            chng_server_btn_login.Size = new Size(149, 57);
            chng_server_btn_login.TabIndex = 26;
            chng_server_btn_login.Text = "Change Server";
            chng_server_btn_login.UseVisualStyleBackColor = false;
            chng_server_btn_login.Click += chng_server_btn_login_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox username_txt;
        private TextBox password_txt;
        private Button login_btn;
        private Panel panel1;
        private Label label7;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private Button chng_server_btn_login;
    }
}