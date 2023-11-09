namespace BME_Inventory
{
    partial class Insert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Insert));
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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            panel1 = new Panel();
            exit_btn6 = new Button();
            distribute_btn = new Button();
            edit_btn = new Button();
            home_btn1 = new Button();
            table_btn6 = new Button();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(25, 29);
            label1.Name = "label1";
            label1.Size = new Size(75, 23);
            label1.TabIndex = 0;
            label1.Text = "Part ID";
            // 
            // part_id_txt
            // 
            part_id_txt.Location = new Point(204, 32);
            part_id_txt.Name = "part_id_txt";
            part_id_txt.Size = new Size(392, 29);
            part_id_txt.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(25, 204);
            label2.Name = "label2";
            label2.Size = new Size(116, 23);
            label2.TabIndex = 2;
            label2.Text = "Part Name";
            // 
            // part_name_txt
            // 
            part_name_txt.Location = new Point(206, 207);
            part_name_txt.Name = "part_name_txt";
            part_name_txt.Size = new Size(392, 29);
            part_name_txt.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(25, 262);
            label3.Name = "label3";
            label3.Size = new Size(182, 23);
            label3.TabIndex = 4;
            label3.Text = "Equipment Name";
            // 
            // equip_name_txt
            // 
            equip_name_txt.Location = new Point(206, 262);
            equip_name_txt.Name = "equip_name_txt";
            equip_name_txt.Size = new Size(392, 29);
            equip_name_txt.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(20, 39);
            label4.Name = "label4";
            label4.Size = new Size(113, 23);
            label4.TabIndex = 6;
            label4.Text = "Upper limit";
            // 
            // upper_txt
            // 
            upper_txt.Location = new Point(192, 32);
            upper_txt.Name = "upper_txt";
            upper_txt.Size = new Size(392, 29);
            upper_txt.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(20, 96);
            label5.Name = "label5";
            label5.Size = new Size(112, 23);
            label5.TabIndex = 8;
            label5.Text = "Lower limit";
            // 
            // lower_txt
            // 
            lower_txt.Location = new Point(192, 93);
            lower_txt.Name = "lower_txt";
            lower_txt.Size = new Size(392, 29);
            lower_txt.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(20, 155);
            label6.Name = "label6";
            label6.Size = new Size(141, 23);
            label6.TabIndex = 10;
            label6.Text = "Current Stock";
            // 
            // stock_txt
            // 
            stock_txt.Location = new Point(190, 153);
            stock_txt.Name = "stock_txt";
            stock_txt.Size = new Size(392, 29);
            stock_txt.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(25, 318);
            label7.Name = "label7";
            label7.Size = new Size(117, 23);
            label7.TabIndex = 12;
            label7.Text = "Description";
            // 
            // desc_txt
            // 
            desc_txt.Location = new Point(206, 317);
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
            make_combo1.FormattingEnabled = true;
            make_combo1.Location = new Point(206, 87);
            make_combo1.Name = "make_combo1";
            make_combo1.Size = new Size(336, 29);
            make_combo1.TabIndex = 39;
            // 
            // model_combo1
            // 
            model_combo1.FormattingEnabled = true;
            model_combo1.Location = new Point(206, 145);
            model_combo1.Name = "model_combo1";
            model_combo1.Size = new Size(336, 29);
            model_combo1.TabIndex = 40;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(25, 87);
            label8.Name = "label8";
            label8.Size = new Size(64, 23);
            label8.TabIndex = 41;
            label8.Text = "Make";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(25, 146);
            label9.Name = "label9";
            label9.Size = new Size(72, 23);
            label9.TabIndex = 42;
            label9.Text = "Model";
            // 
            // make_txt1
            // 
            make_txt1.Location = new Point(585, 90);
            make_txt1.Name = "make_txt1";
            make_txt1.Size = new Size(316, 29);
            make_txt1.TabIndex = 43;
            // 
            // model_txt1
            // 
            model_txt1.Location = new Point(585, 148);
            model_txt1.Name = "model_txt1";
            model_txt1.Size = new Size(316, 29);
            model_txt1.TabIndex = 44;
            // 
            // add_btn1
            // 
            add_btn1.Location = new Point(969, 96);
            add_btn1.Name = "add_btn1";
            add_btn1.Size = new Size(118, 83);
            add_btn1.TabIndex = 46;
            add_btn1.Text = "Add";
            add_btn1.UseVisualStyleBackColor = true;
            add_btn1.Click += model_btn1_Click;
            // 
            // insert_btn
            // 
            insert_btn.BackColor = SystemColors.Window;
            insert_btn.BackgroundImageLayout = ImageLayout.Zoom;
            insert_btn.Image = (Image)resources.GetObject("insert_btn.Image");
            insert_btn.Location = new Point(1101, 403);
            insert_btn.Name = "insert_btn";
            insert_btn.Size = new Size(78, 70);
            insert_btn.TabIndex = 14;
            insert_btn.Text = "\r\n";
            insert_btn.TextAlign = ContentAlignment.MiddleRight;
            insert_btn.UseVisualStyleBackColor = false;
            insert_btn.Click += insert_btn_Click;
            // 
            // success_lbl1
            // 
            success_lbl1.AutoSize = true;
            success_lbl1.BackColor = Color.PaleGreen;
            success_lbl1.Location = new Point(818, 561);
            success_lbl1.Name = "success_lbl1";
            success_lbl1.Size = new Size(0, 21);
            success_lbl1.TabIndex = 48;
            success_lbl1.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(add_btn1);
            groupBox1.Controls.Add(model_txt1);
            groupBox1.Controls.Add(make_txt1);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(desc_txt);
            groupBox1.Controls.Add(model_combo1);
            groupBox1.Controls.Add(make_combo1);
            groupBox1.Controls.Add(equip_name_txt);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(part_name_txt);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(part_id_txt);
            groupBox1.Controls.Add(label1);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(349, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1103, 374);
            groupBox1.TabIndex = 49;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Spare Part Details";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveCaption;
            groupBox2.Controls.Add(stock_txt);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(lower_txt);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(upper_txt);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(349, 403);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(713, 203);
            groupBox2.TabIndex = 50;
            groupBox2.TabStop = false;
            groupBox2.Text = "Add Stock Details";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.AutoSize = true;
            panel1.BackColor = Color.Azure;
            panel1.Controls.Add(exit_btn6);
            panel1.Controls.Add(distribute_btn);
            panel1.Controls.Add(edit_btn);
            panel1.Controls.Add(home_btn1);
            panel1.Controls.Add(table_btn6);
            panel1.Controls.Add(label10);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(341, 712);
            panel1.TabIndex = 51;
            // 
            // exit_btn6
            // 
            exit_btn6.FlatAppearance.BorderSize = 0;
            exit_btn6.FlatStyle = FlatStyle.Flat;
            exit_btn6.Image = (Image)resources.GetObject("exit_btn6.Image");
            exit_btn6.ImageAlign = ContentAlignment.MiddleLeft;
            exit_btn6.Location = new Point(16, 350);
            exit_btn6.Name = "exit_btn6";
            exit_btn6.Size = new Size(319, 58);
            exit_btn6.TabIndex = 5;
            exit_btn6.Text = "Exit";
            exit_btn6.UseVisualStyleBackColor = true;
            exit_btn6.Click += exit_btn6_Click;
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
            distribute_btn.Click += distribute_btn_Click;
            // 
            // edit_btn
            // 
            edit_btn.FlatAppearance.BorderSize = 0;
            edit_btn.FlatStyle = FlatStyle.Flat;
            edit_btn.Image = (Image)resources.GetObject("edit_btn.Image");
            edit_btn.ImageAlign = ContentAlignment.MiddleLeft;
            edit_btn.Location = new Point(16, 222);
            edit_btn.Name = "edit_btn";
            edit_btn.Size = new Size(319, 58);
            edit_btn.TabIndex = 2;
            edit_btn.Text = "Edit Entries";
            edit_btn.UseVisualStyleBackColor = true;
            edit_btn.Click += edit_btn_Click;
            // 
            // home_btn1
            // 
            home_btn1.FlatAppearance.BorderSize = 0;
            home_btn1.FlatStyle = FlatStyle.Flat;
            home_btn1.Image = (Image)resources.GetObject("home_btn1.Image");
            home_btn1.ImageAlign = ContentAlignment.MiddleLeft;
            home_btn1.Location = new Point(16, 158);
            home_btn1.Name = "home_btn1";
            home_btn1.Size = new Size(319, 58);
            home_btn1.TabIndex = 1;
            home_btn1.Text = "Home";
            home_btn1.UseVisualStyleBackColor = true;
            home_btn1.Click += home_btn1_Click_1;
            // 
            // table_btn6
            // 
            table_btn6.FlatAppearance.BorderSize = 0;
            table_btn6.FlatStyle = FlatStyle.Flat;
            table_btn6.Image = (Image)resources.GetObject("table_btn6.Image");
            table_btn6.ImageAlign = ContentAlignment.MiddleLeft;
            table_btn6.Location = new Point(16, 286);
            table_btn6.Name = "table_btn6";
            table_btn6.Size = new Size(319, 58);
            table_btn6.TabIndex = 3;
            table_btn6.Text = "Show Table";
            table_btn6.UseVisualStyleBackColor = true;
            table_btn6.Click += table_btn6_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Nunito", 25.8F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(3, 32);
            label10.Name = "label10";
            label10.Size = new Size(304, 59);
            label10.TabIndex = 4;
            label10.Text = "DASHBOARD";
            // 
            // Insert
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1481, 712);
            Controls.Add(panel1);
            Controls.Add(success_lbl1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(insert_btn);
            Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Insert";
            Text = "Insert Data";
            TransparencyKey = Color.FromArgb(255, 255, 128);
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Button home_btn1;
        private Button insert_btn;
        private Label success_lbl1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Panel panel1;
        private Button exit_btn6;
        private Button distribute_btn;
        private Button edit_btn;
        private Button home_btn;
        private Button table_btn6;
        private Label label10;
    }
}