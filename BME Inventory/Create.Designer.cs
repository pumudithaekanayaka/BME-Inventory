using System.IO;
namespace BME_Inventory
{
    partial class Create
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Create));
            label1 = new Label();
            part_id_txt = new TextBox();
            label2 = new Label();
            part_name_txt = new TextBox();
            label3 = new Label();
            equip_name_txt = new TextBox();
            label4 = new Label();
            upper_txt = new TextBox();
            label5 = new Label();
            lower_txt = new TextBox();
            label6 = new Label();
            stock_txt = new TextBox();
            label7 = new Label();
            desc_txt = new TextBox();
            fileSystemWatcher1 = new FileSystemWatcher();
            make_combo1 = new ComboBox();
            model_combo1 = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            make_txt1 = new TextBox();
            model_txt1 = new TextBox();
            add_btn1 = new Button();
            insert_btn = new Button();
            success_lbl1 = new Label();
            pnl_menu_dashboard = new Panel();
            btn_home_create = new Button();
            btn_dev_create = new Button();
            btn_edit_create = new Button();
            btn_adduser_create = new Button();
            btn_receive_create = new Button();
            btn_distribute_create = new Button();
            btn_database_create = new Button();
            pnl_home = new Panel();
            label10 = new Label();
            btn_logout_create = new Button();
            btn_exit_create = new Button();
            panel1 = new Panel();
            label18 = new Label();
            label16 = new Label();
            user_lbl_create = new Label();
            panel2 = new Panel();
            label14 = new Label();
            panel3 = new Panel();
            label12 = new Label();
            label11 = new Label();
            label13 = new Label();
            panel4 = new Panel();
            label17 = new Label();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            pnl_menu_dashboard.SuspendLayout();
            pnl_home.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(31, 95);
            label1.Name = "label1";
            label1.Size = new Size(62, 21);
            label1.TabIndex = 0;
            label1.Text = "Part ID";
            // 
            // part_id_txt
            // 
            part_id_txt.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            part_id_txt.Location = new Point(210, 98);
            part_id_txt.Name = "part_id_txt";
            part_id_txt.Size = new Size(392, 29);
            part_id_txt.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(31, 270);
            label2.Name = "label2";
            label2.Size = new Size(92, 21);
            label2.TabIndex = 2;
            label2.Text = "Part Name";
            // 
            // part_name_txt
            // 
            part_name_txt.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            part_name_txt.Location = new Point(212, 273);
            part_name_txt.Name = "part_name_txt";
            part_name_txt.Size = new Size(392, 29);
            part_name_txt.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(31, 328);
            label3.Name = "label3";
            label3.Size = new Size(144, 21);
            label3.TabIndex = 4;
            label3.Text = "Equipment Name";
            // 
            // equip_name_txt
            // 
            equip_name_txt.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            equip_name_txt.Location = new Point(212, 328);
            equip_name_txt.Name = "equip_name_txt";
            equip_name_txt.Size = new Size(392, 29);
            equip_name_txt.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(38, 80);
            label4.Name = "label4";
            label4.Size = new Size(94, 21);
            label4.TabIndex = 6;
            label4.Text = "Upper limit";
            // 
            // upper_txt
            // 
            upper_txt.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            upper_txt.Location = new Point(210, 73);
            upper_txt.Name = "upper_txt";
            upper_txt.Size = new Size(392, 29);
            upper_txt.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(38, 137);
            label5.Name = "label5";
            label5.Size = new Size(95, 21);
            label5.TabIndex = 8;
            label5.Text = "Lower limit";
            // 
            // lower_txt
            // 
            lower_txt.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lower_txt.Location = new Point(210, 134);
            lower_txt.Name = "lower_txt";
            lower_txt.Size = new Size(392, 29);
            lower_txt.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(38, 196);
            label6.Name = "label6";
            label6.Size = new Size(117, 21);
            label6.TabIndex = 10;
            label6.Text = "Current Stock";
            // 
            // stock_txt
            // 
            stock_txt.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            stock_txt.Location = new Point(208, 194);
            stock_txt.Name = "stock_txt";
            stock_txt.Size = new Size(392, 29);
            stock_txt.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(31, 384);
            label7.Name = "label7";
            label7.Size = new Size(99, 21);
            label7.TabIndex = 12;
            label7.Text = "Description";
            // 
            // desc_txt
            // 
            desc_txt.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            desc_txt.Location = new Point(212, 383);
            desc_txt.Name = "desc_txt";
            desc_txt.Size = new Size(392, 29);
            desc_txt.TabIndex = 13;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // make_combo1
            // 
            make_combo1.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            make_combo1.FormattingEnabled = true;
            make_combo1.Location = new Point(212, 153);
            make_combo1.Name = "make_combo1";
            make_combo1.Size = new Size(336, 29);
            make_combo1.TabIndex = 39;
            // 
            // model_combo1
            // 
            model_combo1.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            model_combo1.FormattingEnabled = true;
            model_combo1.Location = new Point(212, 211);
            model_combo1.Name = "model_combo1";
            model_combo1.Size = new Size(336, 29);
            model_combo1.TabIndex = 40;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(31, 153);
            label8.Name = "label8";
            label8.Size = new Size(53, 21);
            label8.TabIndex = 41;
            label8.Text = "Make";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(31, 212);
            label9.Name = "label9";
            label9.Size = new Size(59, 21);
            label9.TabIndex = 42;
            label9.Text = "Model";
            // 
            // make_txt1
            // 
            make_txt1.Location = new Point(135, 67);
            make_txt1.Name = "make_txt1";
            make_txt1.Size = new Size(316, 29);
            make_txt1.TabIndex = 43;
            // 
            // model_txt1
            // 
            model_txt1.Location = new Point(135, 127);
            model_txt1.Name = "model_txt1";
            model_txt1.Size = new Size(316, 29);
            model_txt1.TabIndex = 44;
            model_txt1.TextChanged += model_txt1_TextChanged;
            // 
            // add_btn1
            // 
            add_btn1.FlatStyle = FlatStyle.System;
            add_btn1.Location = new Point(135, 173);
            add_btn1.Name = "add_btn1";
            add_btn1.Size = new Size(118, 37);
            add_btn1.TabIndex = 46;
            add_btn1.Text = "Add";
            add_btn1.UseVisualStyleBackColor = true;
            add_btn1.Click += model_btn1_Click;
            // 
            // insert_btn
            // 
            insert_btn.AutoSize = true;
            insert_btn.BackColor = SystemColors.Window;
            insert_btn.BackgroundImageLayout = ImageLayout.Zoom;
            insert_btn.FlatStyle = FlatStyle.System;
            insert_btn.ImageAlign = ContentAlignment.MiddleLeft;
            insert_btn.Location = new Point(642, 166);
            insert_btn.Name = "insert_btn";
            insert_btn.Size = new Size(170, 51);
            insert_btn.TabIndex = 14;
            insert_btn.Text = "\r\nSave Details";
            insert_btn.UseVisualStyleBackColor = false;
            insert_btn.Click += insert_btn_Click;
            // 
            // success_lbl1
            // 
            success_lbl1.AutoSize = true;
            success_lbl1.BackColor = Color.PaleGreen;
            success_lbl1.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            success_lbl1.Location = new Point(812, 339);
            success_lbl1.Name = "success_lbl1";
            success_lbl1.Size = new Size(0, 21);
            success_lbl1.TabIndex = 48;
            success_lbl1.Visible = false;
            // 
            // pnl_menu_dashboard
            // 
            pnl_menu_dashboard.BackColor = Color.GhostWhite;
            pnl_menu_dashboard.BackgroundImageLayout = ImageLayout.None;
            pnl_menu_dashboard.Controls.Add(btn_home_create);
            pnl_menu_dashboard.Controls.Add(btn_dev_create);
            pnl_menu_dashboard.Controls.Add(btn_edit_create);
            pnl_menu_dashboard.Controls.Add(btn_adduser_create);
            pnl_menu_dashboard.Controls.Add(btn_receive_create);
            pnl_menu_dashboard.Controls.Add(btn_distribute_create);
            pnl_menu_dashboard.Controls.Add(btn_database_create);
            pnl_menu_dashboard.Controls.Add(pnl_home);
            pnl_menu_dashboard.Controls.Add(btn_logout_create);
            pnl_menu_dashboard.Controls.Add(btn_exit_create);
            pnl_menu_dashboard.Dock = DockStyle.Left;
            pnl_menu_dashboard.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            pnl_menu_dashboard.Location = new Point(0, 0);
            pnl_menu_dashboard.Name = "pnl_menu_dashboard";
            pnl_menu_dashboard.Size = new Size(333, 750);
            pnl_menu_dashboard.TabIndex = 51;
            // 
            // btn_home_create
            // 
            btn_home_create.AutoSize = true;
            btn_home_create.Dock = DockStyle.Bottom;
            btn_home_create.FlatAppearance.BorderSize = 0;
            btn_home_create.FlatStyle = FlatStyle.Flat;
            btn_home_create.Image = (Image)resources.GetObject("btn_home_create.Image");
            btn_home_create.ImageAlign = ContentAlignment.MiddleLeft;
            btn_home_create.Location = new Point(0, 570);
            btn_home_create.Name = "btn_home_create";
            btn_home_create.Size = new Size(333, 60);
            btn_home_create.TabIndex = 19;
            btn_home_create.Text = "Home";
            btn_home_create.UseVisualStyleBackColor = true;
            btn_home_create.Click += btn_home_create_Click;
            // 
            // btn_dev_create
            // 
            btn_dev_create.Dock = DockStyle.Top;
            btn_dev_create.FlatAppearance.BorderSize = 0;
            btn_dev_create.FlatStyle = FlatStyle.Flat;
            btn_dev_create.Image = (Image)resources.GetObject("btn_dev_create.Image");
            btn_dev_create.ImageAlign = ContentAlignment.MiddleLeft;
            btn_dev_create.Location = new Point(0, 342);
            btn_dev_create.Name = "btn_dev_create";
            btn_dev_create.Size = new Size(333, 60);
            btn_dev_create.TabIndex = 17;
            btn_dev_create.Text = "Developer Mode";
            btn_dev_create.UseVisualStyleBackColor = true;
            btn_dev_create.Click += btn_dev_adduser_Click;
            // 
            // btn_edit_create
            // 
            btn_edit_create.Dock = DockStyle.Top;
            btn_edit_create.FlatAppearance.BorderSize = 0;
            btn_edit_create.FlatStyle = FlatStyle.Flat;
            btn_edit_create.Image = (Image)resources.GetObject("btn_edit_create.Image");
            btn_edit_create.ImageAlign = ContentAlignment.MiddleLeft;
            btn_edit_create.Location = new Point(0, 282);
            btn_edit_create.Name = "btn_edit_create";
            btn_edit_create.Size = new Size(333, 60);
            btn_edit_create.TabIndex = 16;
            btn_edit_create.Text = "Edit Entries";
            btn_edit_create.UseVisualStyleBackColor = true;
            // 
            // btn_adduser_create
            // 
            btn_adduser_create.Dock = DockStyle.Top;
            btn_adduser_create.FlatAppearance.BorderSize = 0;
            btn_adduser_create.FlatStyle = FlatStyle.Flat;
            btn_adduser_create.Image = (Image)resources.GetObject("btn_adduser_create.Image");
            btn_adduser_create.ImageAlign = ContentAlignment.MiddleLeft;
            btn_adduser_create.Location = new Point(0, 222);
            btn_adduser_create.Name = "btn_adduser_create";
            btn_adduser_create.Size = new Size(333, 60);
            btn_adduser_create.TabIndex = 15;
            btn_adduser_create.Text = "Add New User";
            btn_adduser_create.UseVisualStyleBackColor = true;
            btn_adduser_create.Click += btn_adduser_adduser_Click;
            // 
            // btn_receive_create
            // 
            btn_receive_create.Dock = DockStyle.Top;
            btn_receive_create.FlatAppearance.BorderSize = 0;
            btn_receive_create.FlatStyle = FlatStyle.Flat;
            btn_receive_create.Image = (Image)resources.GetObject("btn_receive_create.Image");
            btn_receive_create.ImageAlign = ContentAlignment.MiddleLeft;
            btn_receive_create.Location = new Point(0, 162);
            btn_receive_create.Name = "btn_receive_create";
            btn_receive_create.Size = new Size(333, 60);
            btn_receive_create.TabIndex = 13;
            btn_receive_create.Text = "Receive";
            btn_receive_create.UseVisualStyleBackColor = true;
            btn_receive_create.Click += btn_receive_adduser_Click;
            // 
            // btn_distribute_create
            // 
            btn_distribute_create.AutoSize = true;
            btn_distribute_create.Dock = DockStyle.Top;
            btn_distribute_create.FlatAppearance.BorderSize = 0;
            btn_distribute_create.FlatStyle = FlatStyle.Flat;
            btn_distribute_create.Image = (Image)resources.GetObject("btn_distribute_create.Image");
            btn_distribute_create.ImageAlign = ContentAlignment.MiddleLeft;
            btn_distribute_create.Location = new Point(0, 102);
            btn_distribute_create.Name = "btn_distribute_create";
            btn_distribute_create.Size = new Size(333, 60);
            btn_distribute_create.TabIndex = 12;
            btn_distribute_create.Text = "\r\nDistribute";
            btn_distribute_create.TextAlign = ContentAlignment.TopCenter;
            btn_distribute_create.UseVisualStyleBackColor = true;
            btn_distribute_create.Click += btn_distribute_adduser_Click;
            // 
            // btn_database_create
            // 
            btn_database_create.Dock = DockStyle.Top;
            btn_database_create.FlatAppearance.BorderSize = 0;
            btn_database_create.FlatStyle = FlatStyle.Flat;
            btn_database_create.Image = (Image)resources.GetObject("btn_database_create.Image");
            btn_database_create.ImageAlign = ContentAlignment.MiddleLeft;
            btn_database_create.Location = new Point(0, 42);
            btn_database_create.Name = "btn_database_create";
            btn_database_create.Size = new Size(333, 60);
            btn_database_create.TabIndex = 10;
            btn_database_create.Text = "Database";
            btn_database_create.UseVisualStyleBackColor = true;
            btn_database_create.Click += btn_database_adduser_Click;
            // 
            // pnl_home
            // 
            pnl_home.AutoSize = true;
            pnl_home.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnl_home.Controls.Add(label10);
            pnl_home.Dock = DockStyle.Top;
            pnl_home.Location = new Point(0, 0);
            pnl_home.Name = "pnl_home";
            pnl_home.Size = new Size(333, 42);
            pnl_home.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Fira Sans Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(12, 18);
            label10.Name = "label10";
            label10.Size = new Size(182, 24);
            label10.TabIndex = 0;
            label10.Text = "Navigation Panel";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_logout_create
            // 
            btn_logout_create.AutoSize = true;
            btn_logout_create.Dock = DockStyle.Bottom;
            btn_logout_create.FlatAppearance.BorderSize = 0;
            btn_logout_create.FlatStyle = FlatStyle.Flat;
            btn_logout_create.Image = (Image)resources.GetObject("btn_logout_create.Image");
            btn_logout_create.ImageAlign = ContentAlignment.MiddleLeft;
            btn_logout_create.Location = new Point(0, 630);
            btn_logout_create.Name = "btn_logout_create";
            btn_logout_create.Size = new Size(333, 60);
            btn_logout_create.TabIndex = 8;
            btn_logout_create.Text = "Log Out";
            btn_logout_create.UseVisualStyleBackColor = true;
            btn_logout_create.Click += btn_logout_adduser_Click;
            // 
            // btn_exit_create
            // 
            btn_exit_create.AutoSize = true;
            btn_exit_create.Dock = DockStyle.Bottom;
            btn_exit_create.FlatAppearance.BorderSize = 0;
            btn_exit_create.FlatStyle = FlatStyle.Flat;
            btn_exit_create.Image = (Image)resources.GetObject("btn_exit_create.Image");
            btn_exit_create.ImageAlign = ContentAlignment.MiddleLeft;
            btn_exit_create.Location = new Point(0, 690);
            btn_exit_create.Name = "btn_exit_create";
            btn_exit_create.Size = new Size(333, 60);
            btn_exit_create.TabIndex = 9;
            btn_exit_create.Text = "Exit";
            btn_exit_create.UseVisualStyleBackColor = true;
            btn_exit_create.Click += btn_exit_adduser_Click;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = Color.Snow;
            panel1.Controls.Add(label18);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(user_lbl_create);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(333, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1237, 41);
            panel1.TabIndex = 52;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Fira Sans Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(16, 17);
            label18.Name = "label18";
            label18.Size = new Size(334, 24);
            label18.TabIndex = 1;
            label18.Text = "Add New Entry To The Inventory";
            label18.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Google Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(853, 9);
            label16.Name = "label16";
            label16.Size = new Size(128, 25);
            label16.TabIndex = 54;
            label16.Text = "Logged in As";
            // 
            // user_lbl_create
            // 
            user_lbl_create.AutoSize = true;
            user_lbl_create.Font = new Font("Google Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            user_lbl_create.Location = new Point(987, 8);
            user_lbl_create.Name = "user_lbl_create";
            user_lbl_create.Size = new Size(104, 25);
            user_lbl_create.TabIndex = 53;
            user_lbl_create.Text = "Username";
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.BackColor = Color.Ivory;
            panel2.Controls.Add(label14);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(part_id_txt);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(part_name_txt);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(equip_name_txt);
            panel2.Controls.Add(make_combo1);
            panel2.Controls.Add(model_combo1);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(desc_txt);
            panel2.Controls.Add(success_lbl1);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label8);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(333, 41);
            panel2.Name = "panel2";
            panel2.Size = new Size(1237, 415);
            panel2.TabIndex = 53;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Google Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(31, 35);
            label14.Name = "label14";
            label14.Size = new Size(223, 25);
            label14.TabIndex = 52;
            label14.Text = "Add Spare Parts Details";
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(make_txt1);
            panel3.Controls.Add(model_txt1);
            panel3.Controls.Add(add_btn1);
            panel3.Location = new Point(624, 6);
            panel3.Name = "panel3";
            panel3.Size = new Size(469, 213);
            panel3.TabIndex = 49;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(21, 132);
            label12.Name = "label12";
            label12.Size = new Size(59, 21);
            label12.TabIndex = 51;
            label12.Text = "Model";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Google Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(21, 16);
            label11.Name = "label11";
            label11.Size = new Size(445, 25);
            label11.TabIndex = 47;
            label11.Text = "If Make and Model Not Available Add Them Here";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(21, 73);
            label13.Name = "label13";
            label13.Size = new Size(53, 21);
            label13.TabIndex = 50;
            label13.Text = "Make";
            // 
            // panel4
            // 
            panel4.AutoSize = true;
            panel4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel4.BackColor = Color.Ivory;
            panel4.Controls.Add(label17);
            panel4.Controls.Add(lower_txt);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(upper_txt);
            panel4.Controls.Add(insert_btn);
            panel4.Controls.Add(stock_txt);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label6);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(333, 456);
            panel4.Name = "panel4";
            panel4.Size = new Size(1237, 226);
            panel4.TabIndex = 54;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Google Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(38, 20);
            label17.Name = "label17";
            label17.Size = new Size(170, 25);
            label17.TabIndex = 53;
            label17.Text = "Add Stock Details";
            // 
            // Create
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            AutoScroll = true;
            BackColor = Color.MintCream;
            ClientSize = new Size(1570, 750);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pnl_menu_dashboard);
            Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Create";
            Text = "Insert Data";
            TransparencyKey = Color.FromArgb(255, 255, 128);
            WindowState = FormWindowState.Maximized;
            Load += Create_Load;
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            pnl_menu_dashboard.ResumeLayout(false);
            pnl_menu_dashboard.PerformLayout();
            pnl_home.ResumeLayout(false);
            pnl_home.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox part_id_txt;
        private Label label2;
        private TextBox part_name_txt;
        private Label label3;
        private TextBox equip_name_txt;
        private Label label4;
        private TextBox upper_txt;
        private Label label5;
        private TextBox lower_txt;
        private Label label6;
        private TextBox stock_txt;
        private Label label7;
        private TextBox desc_txt;
        private FileSystemWatcher fileSystemWatcher1;
        private Label label9;
        private Label label8;
        private ComboBox model_combo1;
        private ComboBox make_combo1;
        private Button add_btn1;
        private TextBox model_txt1;
        private TextBox make_txt1;
        private Button insert_btn;
        private Label success_lbl1;
        private Panel pnl_menu_dashboard;
        private Button btn_dev_create;
        private Button btn_edit_create;
        private Button btn_adduser_create;
        private Button btn_receive_create;
        private Button btn_distribute_create;
        private Button btn_database_create;
        private Panel pnl_home;
        private Label label10;
        private Button btn_logout_create;
        private Button btn_exit_create;
        private Button btn_home_create;
        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
        private Label label12;
        private Label label11;
        private Label label13;
        private Panel panel4;
        private Label label17;
        private Label label14;
        private Label label16;
        private Label user_lbl_create;
        private Label label18;
    }
}