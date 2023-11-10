﻿namespace BME_Inventory
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
            exit_btn6 = new Button();
            distribute_btn = new Button();
            edit_btn = new Button();
            add_btn = new Button();
            table_btn6 = new Button();
            label1 = new Label();
            panel1 = new Panel();
            receive_btn6 = new Button();
            user_add_btn_add = new Button();
            password_txt_add = new TextBox();
            username_txt_add = new TextBox();
            confirm_password_txt_add = new TextBox();
            user_level_add = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // exit_btn6
            // 
            exit_btn6.FlatAppearance.BorderSize = 0;
            exit_btn6.FlatStyle = FlatStyle.Flat;
            exit_btn6.Image = (Image)resources.GetObject("exit_btn6.Image");
            exit_btn6.ImageAlign = ContentAlignment.MiddleLeft;
            exit_btn6.Location = new Point(12, 423);
            exit_btn6.Name = "exit_btn6";
            exit_btn6.Size = new Size(319, 58);
            exit_btn6.TabIndex = 5;
            exit_btn6.Text = "Exit";
            exit_btn6.UseVisualStyleBackColor = true;
            // 
            // distribute_btn
            // 
            distribute_btn.FlatAppearance.BorderSize = 0;
            distribute_btn.FlatStyle = FlatStyle.Flat;
            distribute_btn.Image = (Image)resources.GetObject("distribute_btn.Image");
            distribute_btn.ImageAlign = ContentAlignment.MiddleLeft;
            distribute_btn.Location = new Point(16, 94);
            distribute_btn.Name = "distribute_btn";
            distribute_btn.Size = new Size(322, 58);
            distribute_btn.TabIndex = 0;
            distribute_btn.Text = "Distribute";
            distribute_btn.UseVisualStyleBackColor = true;
            // 
            // edit_btn
            // 
            edit_btn.FlatAppearance.BorderSize = 0;
            edit_btn.FlatStyle = FlatStyle.Flat;
            edit_btn.Image = (Image)resources.GetObject("edit_btn.Image");
            edit_btn.ImageAlign = ContentAlignment.MiddleLeft;
            edit_btn.Location = new Point(16, 286);
            edit_btn.Name = "edit_btn";
            edit_btn.Size = new Size(319, 58);
            edit_btn.TabIndex = 2;
            edit_btn.Text = "Edit Entries";
            edit_btn.UseVisualStyleBackColor = true;
            // 
            // add_btn
            // 
            add_btn.FlatAppearance.BorderSize = 0;
            add_btn.FlatStyle = FlatStyle.Flat;
            add_btn.Image = (Image)resources.GetObject("add_btn.Image");
            add_btn.ImageAlign = ContentAlignment.MiddleLeft;
            add_btn.Location = new Point(12, 222);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(319, 58);
            add_btn.TabIndex = 1;
            add_btn.Text = "Add New";
            add_btn.UseVisualStyleBackColor = true;
            // 
            // table_btn6
            // 
            table_btn6.FlatAppearance.BorderSize = 0;
            table_btn6.FlatStyle = FlatStyle.Flat;
            table_btn6.Image = (Image)resources.GetObject("table_btn6.Image");
            table_btn6.ImageAlign = ContentAlignment.MiddleLeft;
            table_btn6.Location = new Point(12, 359);
            table_btn6.Name = "table_btn6";
            table_btn6.Size = new Size(319, 58);
            table_btn6.TabIndex = 3;
            table_btn6.Text = "Show Table";
            table_btn6.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nunito", 25.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 32);
            label1.Name = "label1";
            label1.Size = new Size(304, 59);
            label1.TabIndex = 4;
            label1.Text = "DASHBOARD";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.AutoSize = true;
            panel1.BackColor = Color.Azure;
            panel1.Controls.Add(receive_btn6);
            panel1.Controls.Add(exit_btn6);
            panel1.Controls.Add(distribute_btn);
            panel1.Controls.Add(edit_btn);
            panel1.Controls.Add(add_btn);
            panel1.Controls.Add(table_btn6);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(341, 724);
            panel1.TabIndex = 10;
            // 
            // receive_btn6
            // 
            receive_btn6.FlatAppearance.BorderSize = 0;
            receive_btn6.FlatStyle = FlatStyle.Flat;
            receive_btn6.Image = (Image)resources.GetObject("receive_btn6.Image");
            receive_btn6.ImageAlign = ContentAlignment.MiddleLeft;
            receive_btn6.Location = new Point(12, 158);
            receive_btn6.Name = "receive_btn6";
            receive_btn6.Size = new Size(322, 58);
            receive_btn6.TabIndex = 6;
            receive_btn6.Text = "Receive";
            receive_btn6.UseVisualStyleBackColor = true;
            // 
            // user_add_btn_add
            // 
            user_add_btn_add.Location = new Point(678, 300);
            user_add_btn_add.Name = "user_add_btn_add";
            user_add_btn_add.Size = new Size(149, 57);
            user_add_btn_add.TabIndex = 13;
            user_add_btn_add.Text = "Save User";
            user_add_btn_add.UseVisualStyleBackColor = true;
            user_add_btn_add.Click += login_btn_Click;
            // 
            // password_txt_add
            // 
            password_txt_add.Location = new Point(589, 143);
            password_txt_add.Name = "password_txt_add";
            password_txt_add.Size = new Size(328, 27);
            password_txt_add.TabIndex = 12;
            // 
            // username_txt_add
            // 
            username_txt_add.Location = new Point(589, 82);
            username_txt_add.Name = "username_txt_add";
            username_txt_add.Size = new Size(328, 27);
            username_txt_add.TabIndex = 11;
            // 
            // confirm_password_txt_add
            // 
            confirm_password_txt_add.Location = new Point(589, 189);
            confirm_password_txt_add.Name = "confirm_password_txt_add";
            confirm_password_txt_add.Size = new Size(328, 27);
            confirm_password_txt_add.TabIndex = 14;
            // 
            // user_level_add
            // 
            user_level_add.FormattingEnabled = true;
            user_level_add.Items.AddRange(new object[] { "user", "admin", "maintenance" });
            user_level_add.Location = new Point(598, 249);
            user_level_add.Name = "user_level_add";
            user_level_add.Size = new Size(146, 28);
            user_level_add.TabIndex = 15;
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 724);
            Controls.Add(user_level_add);
            Controls.Add(confirm_password_txt_add);
            Controls.Add(user_add_btn_add);
            Controls.Add(password_txt_add);
            Controls.Add(username_txt_add);
            Controls.Add(panel1);
            Name = "AddUser";
            Text = "Add Users";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button exit_btn6;
        private Button distribute_btn;
        private Button edit_btn;
        private Button add_btn;
        private Button table_btn6;
        private Label label1;
        private Panel panel1;
        private Button receive_btn6;
        private Button user_add_btn_add;
        private TextBox password_txt_add;
        private TextBox username_txt_add;
        private TextBox confirm_password_txt_add;
        private ComboBox user_level_add;
    }
}