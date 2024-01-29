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
            password_txt_add = new TextBox();
            confirm_password_txt_add = new TextBox();
            user_level_add = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            username_txt_add = new TextBox();
            label1 = new Label();
            user_save_btn = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // password_txt_add
            // 
            password_txt_add.BorderStyle = BorderStyle.FixedSingle;
            password_txt_add.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            password_txt_add.Location = new Point(215, 69);
            password_txt_add.Name = "password_txt_add";
            password_txt_add.Size = new Size(328, 29);
            password_txt_add.TabIndex = 12;
            // 
            // confirm_password_txt_add
            // 
            confirm_password_txt_add.BorderStyle = BorderStyle.FixedSingle;
            confirm_password_txt_add.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            confirm_password_txt_add.Location = new Point(215, 119);
            confirm_password_txt_add.Name = "confirm_password_txt_add";
            confirm_password_txt_add.Size = new Size(328, 29);
            confirm_password_txt_add.TabIndex = 14;
            // 
            // user_level_add
            // 
            user_level_add.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            user_level_add.FormattingEnabled = true;
            user_level_add.Items.AddRange(new object[] { "user", "admin" });
            user_level_add.Location = new Point(215, 169);
            user_level_add.Name = "user_level_add";
            user_level_add.Size = new Size(145, 29);
            user_level_add.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(15, 69);
            label3.Name = "label3";
            label3.Size = new Size(83, 21);
            label3.TabIndex = 17;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(15, 119);
            label4.Name = "label4";
            label4.Size = new Size(150, 21);
            label4.TabIndex = 18;
            label4.Text = "Re-Type Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(15, 169);
            label5.Name = "label5";
            label5.Size = new Size(136, 21);
            label5.TabIndex = 19;
            label5.Text = "Select User Role";
            // 
            // username_txt_add
            // 
            username_txt_add.BorderStyle = BorderStyle.FixedSingle;
            username_txt_add.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            username_txt_add.Location = new Point(215, 19);
            username_txt_add.Name = "username_txt_add";
            username_txt_add.Size = new Size(328, 29);
            username_txt_add.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(15, 19);
            label1.Name = "label1";
            label1.Size = new Size(89, 21);
            label1.TabIndex = 22;
            label1.Text = "Username";
            // 
            // user_save_btn
            // 
            user_save_btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            user_save_btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            user_save_btn.Depth = 0;
            user_save_btn.FlatStyle = FlatStyle.Flat;
            user_save_btn.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            user_save_btn.HighEmphasis = true;
            user_save_btn.Icon = null;
            user_save_btn.Location = new Point(215, 219);
            user_save_btn.Margin = new Padding(4, 6, 4, 6);
            user_save_btn.MouseState = MaterialSkin.MouseState.HOVER;
            user_save_btn.Name = "user_save_btn";
            user_save_btn.NoAccentTextColor = Color.Empty;
            user_save_btn.Size = new Size(97, 36);
            user_save_btn.TabIndex = 20;
            user_save_btn.Text = "Save User";
            user_save_btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            user_save_btn.UseAccentColor = false;
            user_save_btn.UseVisualStyleBackColor = true;
            user_save_btn.Click += user_save_btn_Click;
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(569, 285);
            Controls.Add(username_txt_add);
            Controls.Add(label1);
            Controls.Add(confirm_password_txt_add);
            Controls.Add(user_save_btn);
            Controls.Add(label4);
            Controls.Add(user_level_add);
            Controls.Add(label5);
            Controls.Add(password_txt_add);
            Controls.Add(label3);
            Font = new Font("Google Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddUser";
            Text = "Add New User";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox password_txt_add;
        private TextBox confirm_password_txt_add;
        private ComboBox user_level_add;
        private Label label3;
        private Label label4;
        private Label label5;
        private MaterialSkin.Controls.MaterialButton user_save_btn;
        private Label label1;
        private TextBox username_txt_add;
    }
}