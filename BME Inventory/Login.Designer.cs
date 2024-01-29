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
            label7 = new Label();
            label1 = new Label();
            label2 = new Label();
            chng_server_btn_login = new Button();
            SuspendLayout();
            // 
            // username_txt
            // 
            username_txt.AutoCompleteMode = AutoCompleteMode.Suggest;
            username_txt.AutoCompleteSource = AutoCompleteSource.RecentlyUsedList;
            username_txt.BorderStyle = BorderStyle.FixedSingle;
            username_txt.Location = new Point(136, 73);
            username_txt.Name = "username_txt";
            username_txt.PlaceholderText = "Enter Your Username";
            username_txt.Size = new Size(459, 27);
            username_txt.TabIndex = 0;
            // 
            // password_txt
            // 
            password_txt.BorderStyle = BorderStyle.FixedSingle;
            password_txt.Location = new Point(136, 134);
            password_txt.Name = "password_txt";
            password_txt.PlaceholderText = "Enter Your Password";
            password_txt.Size = new Size(459, 27);
            password_txt.TabIndex = 1;
            password_txt.UseSystemPasswordChar = true;
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.CornflowerBlue;
            login_btn.FlatAppearance.BorderSize = 0;
            login_btn.FlatStyle = FlatStyle.Flat;
            login_btn.Location = new Point(433, 200);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(149, 57);
            login_btn.TabIndex = 2;
            login_btn.Text = "Login";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Google Sans", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(12, 13);
            label7.Name = "label7";
            label7.Size = new Size(269, 35);
            label7.TabIndex = 1;
            label7.Text = "Enter Login Deatils";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 80);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 24;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 141);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 25;
            label2.Text = "Password";
            // 
            // chng_server_btn_login
            // 
            chng_server_btn_login.BackColor = Color.CornflowerBlue;
            chng_server_btn_login.FlatAppearance.BorderSize = 0;
            chng_server_btn_login.FlatStyle = FlatStyle.Flat;
            chng_server_btn_login.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            chng_server_btn_login.Location = new Point(613, 201);
            chng_server_btn_login.Name = "chng_server_btn_login";
            chng_server_btn_login.Size = new Size(149, 57);
            chng_server_btn_login.TabIndex = 26;
            chng_server_btn_login.Text = "Change Server";
            chng_server_btn_login.UseVisualStyleBackColor = false;
            chng_server_btn_login.Click += chng_server_btn_login_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(793, 322);
            Controls.Add(label7);
            Controls.Add(chng_server_btn_login);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(password_txt);
            Controls.Add(login_btn);
            Controls.Add(username_txt);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox username_txt;
        private TextBox password_txt;
        private Button login_btn;
        private Label label7;
        private Label label1;
        private Label label2;
        private Button chng_server_btn_login;
    }
}