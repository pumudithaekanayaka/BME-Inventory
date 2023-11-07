namespace BME_Inventory
{
    partial class login
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
            username_txt = new TextBox();
            password_txt = new TextBox();
            login_btn = new Button();
            SuspendLayout();
            // 
            // username_txt
            // 
            username_txt.Location = new Point(170, 76);
            username_txt.Name = "username_txt";
            username_txt.Size = new Size(328, 27);
            username_txt.TabIndex = 0;
            // 
            // password_txt
            // 
            password_txt.Location = new Point(170, 137);
            password_txt.Name = "password_txt";
            password_txt.Size = new Size(328, 27);
            password_txt.TabIndex = 1;
            // 
            // login_btn
            // 
            login_btn.Location = new Point(259, 294);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(149, 57);
            login_btn.TabIndex = 2;
            login_btn.Text = "Login";
            login_btn.UseVisualStyleBackColor = true;
            login_btn.Click += login_btn_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(login_btn);
            Controls.Add(password_txt);
            Controls.Add(username_txt);
            Name = "login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox username_txt;
        private TextBox password_txt;
        private Button login_btn;
    }
}