namespace BME_Inventory
{
    partial class AddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            user_add_btn_add = new Button();
            password_txt_add = new TextBox();
            username_txt_add = new TextBox();
            confirm_password_txt_add = new TextBox();
            user_level_add = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pnl_desktop_adduser = new Panel();
            pnl_desktop_adduser.SuspendLayout();
            SuspendLayout();
            // 
            // user_add_btn_add
            // 
            user_add_btn_add.BackColor = Color.CornflowerBlue;
            user_add_btn_add.FlatAppearance.BorderSize = 0;
            user_add_btn_add.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            user_add_btn_add.Location = new Point(223, 240);
            user_add_btn_add.Name = "user_add_btn_add";
            user_add_btn_add.Size = new Size(145, 55);
            user_add_btn_add.TabIndex = 13;
            user_add_btn_add.Text = "Save User";
            user_add_btn_add.UseVisualStyleBackColor = false;
            user_add_btn_add.Click += login_btn_Click;
            // 
            // password_txt_add
            // 
            password_txt_add.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            password_txt_add.Location = new Point(223, 80);
            password_txt_add.Name = "password_txt_add";
            password_txt_add.Size = new Size(328, 29);
            password_txt_add.TabIndex = 12;
            // 
            // username_txt_add
            // 
            username_txt_add.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            username_txt_add.Location = new Point(223, 30);
            username_txt_add.Name = "username_txt_add";
            username_txt_add.Size = new Size(328, 29);
            username_txt_add.TabIndex = 11;
            // 
            // confirm_password_txt_add
            // 
            confirm_password_txt_add.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            confirm_password_txt_add.Location = new Point(223, 130);
            confirm_password_txt_add.Name = "confirm_password_txt_add";
            confirm_password_txt_add.Size = new Size(328, 29);
            confirm_password_txt_add.TabIndex = 14;
            // 
            // user_level_add
            // 
            user_level_add.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            user_level_add.FormattingEnabled = true;
            user_level_add.Items.AddRange(new object[] { "user", "admin" });
            user_level_add.Location = new Point(223, 180);
            user_level_add.Name = "user_level_add";
            user_level_add.Size = new Size(145, 29);
            user_level_add.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(23, 30);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 16;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(23, 80);
            label3.Name = "label3";
            label3.Size = new Size(83, 21);
            label3.TabIndex = 17;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(23, 130);
            label4.Name = "label4";
            label4.Size = new Size(150, 21);
            label4.TabIndex = 18;
            label4.Text = "Re-Type Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(23, 180);
            label5.Name = "label5";
            label5.Size = new Size(136, 21);
            label5.TabIndex = 19;
            label5.Text = "Select User Role";
            // 
            // pnl_desktop_adduser
            // 
            pnl_desktop_adduser.BackColor = Color.GhostWhite;
            pnl_desktop_adduser.Controls.Add(label5);
            pnl_desktop_adduser.Controls.Add(confirm_password_txt_add);
            pnl_desktop_adduser.Controls.Add(password_txt_add);
            pnl_desktop_adduser.Controls.Add(label4);
            pnl_desktop_adduser.Controls.Add(username_txt_add);
            pnl_desktop_adduser.Controls.Add(user_add_btn_add);
            pnl_desktop_adduser.Controls.Add(label3);
            pnl_desktop_adduser.Controls.Add(user_level_add);
            pnl_desktop_adduser.Controls.Add(label2);
            pnl_desktop_adduser.Dock = DockStyle.Top;
            pnl_desktop_adduser.Location = new Point(0, 0);
            pnl_desktop_adduser.Name = "pnl_desktop_adduser";
            pnl_desktop_adduser.Size = new Size(1173, 727);
            pnl_desktop_adduser.TabIndex = 22;
            // 
            // AddUser
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            AutoScroll = true;
            AutoSize = true;
            BackColor = Color.MintCream;
            ClientSize = new Size(1173, 787);
            Controls.Add(pnl_desktop_adduser);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddUser";
            Text = "Add New User";
            WindowState = FormWindowState.Maximized;
            pnl_desktop_adduser.ResumeLayout(false);
            pnl_desktop_adduser.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button user_add_btn_add;
        private TextBox password_txt_add;
        private TextBox username_txt_add;
        private TextBox confirm_password_txt_add;
        private ComboBox user_level_add;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel pnl_desktop_adduser;
    }
}