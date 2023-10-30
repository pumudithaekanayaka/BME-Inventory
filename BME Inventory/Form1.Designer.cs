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
            insert_btn = new Button();
            view_btn = new Button();
            fileSystemWatcher1 = new FileSystemWatcher();
            load_btn = new Button();
            home_btn1 = new Button();
            make_combo1 = new ComboBox();
            model_combo1 = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            make_txt1 = new TextBox();
            model_txt1 = new TextBox();
            make_btn1 = new Button();
            model_btn1 = new Button();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 56);
            label1.Name = "label1";
            label1.Size = new Size(49, 18);
            label1.TabIndex = 0;
            label1.Text = "Part ID";
            // 
            // part_id_txt
            // 
            part_id_txt.Location = new Point(172, 53);
            part_id_txt.Margin = new Padding(3, 2, 3, 2);
            part_id_txt.Name = "part_id_txt";
            part_id_txt.Size = new Size(169, 26);
            part_id_txt.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 98);
            label2.Name = "label2";
            label2.Size = new Size(73, 18);
            label2.TabIndex = 2;
            label2.Text = "Part Name";
            // 
            // part_name_txt
            // 
            part_name_txt.Location = new Point(172, 95);
            part_name_txt.Margin = new Padding(3, 2, 3, 2);
            part_name_txt.Name = "part_name_txt";
            part_name_txt.Size = new Size(169, 26);
            part_name_txt.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 141);
            label3.Name = "label3";
            label3.Size = new Size(116, 18);
            label3.TabIndex = 4;
            label3.Text = "Equipment Name";
            // 
            // equip_name_txt
            // 
            equip_name_txt.Location = new Point(172, 138);
            equip_name_txt.Margin = new Padding(3, 2, 3, 2);
            equip_name_txt.Name = "equip_name_txt";
            equip_name_txt.Size = new Size(169, 26);
            equip_name_txt.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 182);
            label4.Name = "label4";
            label4.Size = new Size(78, 18);
            label4.TabIndex = 6;
            label4.Text = "Upper limit";
            // 
            // upper_txt
            // 
            upper_txt.Location = new Point(172, 179);
            upper_txt.Margin = new Padding(3, 2, 3, 2);
            upper_txt.Name = "upper_txt";
            upper_txt.Size = new Size(169, 26);
            upper_txt.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 228);
            label5.Name = "label5";
            label5.Size = new Size(78, 18);
            label5.TabIndex = 8;
            label5.Text = "Lower limit";
            // 
            // lower_txt
            // 
            lower_txt.Location = new Point(172, 220);
            lower_txt.Margin = new Padding(3, 2, 3, 2);
            lower_txt.Name = "lower_txt";
            lower_txt.Size = new Size(169, 26);
            lower_txt.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(41, 269);
            label6.Name = "label6";
            label6.Size = new Size(91, 18);
            label6.TabIndex = 10;
            label6.Text = "Current Stock";
            // 
            // stock_txt
            // 
            stock_txt.Location = new Point(172, 261);
            stock_txt.Margin = new Padding(3, 2, 3, 2);
            stock_txt.Name = "stock_txt";
            stock_txt.Size = new Size(169, 26);
            stock_txt.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(41, 308);
            label7.Name = "label7";
            label7.Size = new Size(78, 18);
            label7.TabIndex = 12;
            label7.Text = "Description";
            // 
            // desc_txt
            // 
            desc_txt.Location = new Point(172, 300);
            desc_txt.Margin = new Padding(3, 2, 3, 2);
            desc_txt.Name = "desc_txt";
            desc_txt.Size = new Size(195, 26);
            desc_txt.TabIndex = 13;
            // 
            // insert_btn
            // 
            insert_btn.Location = new Point(29, 458);
            insert_btn.Margin = new Padding(3, 2, 3, 2);
            insert_btn.Name = "insert_btn";
            insert_btn.Size = new Size(90, 39);
            insert_btn.TabIndex = 14;
            insert_btn.Text = "Insert";
            insert_btn.UseVisualStyleBackColor = true;
            insert_btn.Click += insert_btn_Click;
            // 
            // view_btn
            // 
            view_btn.Location = new Point(125, 463);
            view_btn.Margin = new Padding(3, 2, 3, 2);
            view_btn.Name = "view_btn";
            view_btn.Size = new Size(98, 34);
            view_btn.TabIndex = 15;
            view_btn.Text = "View";
            view_btn.UseVisualStyleBackColor = true;
            view_btn.Click += view_btn_Click;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // load_btn
            // 
            load_btn.Location = new Point(229, 463);
            load_btn.Margin = new Padding(3, 2, 3, 2);
            load_btn.Name = "load_btn";
            load_btn.Size = new Size(94, 39);
            load_btn.TabIndex = 37;
            load_btn.Text = "Load";
            load_btn.UseVisualStyleBackColor = true;
            load_btn.Click += load_btn_Click;
            // 
            // home_btn1
            // 
            home_btn1.Location = new Point(329, 463);
            home_btn1.Name = "home_btn1";
            home_btn1.Size = new Size(116, 38);
            home_btn1.TabIndex = 38;
            home_btn1.Text = "Home";
            home_btn1.UseVisualStyleBackColor = true;
            home_btn1.Click += home_btn1_Click;
            // 
            // make_combo1
            // 
            make_combo1.FormattingEnabled = true;
            make_combo1.Location = new Point(607, 56);
            make_combo1.Name = "make_combo1";
            make_combo1.Size = new Size(133, 26);
            make_combo1.TabIndex = 39;
            // 
            // model_combo1
            // 
            model_combo1.FormattingEnabled = true;
            model_combo1.Location = new Point(607, 98);
            model_combo1.Name = "model_combo1";
            model_combo1.Size = new Size(133, 26);
            model_combo1.TabIndex = 40;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(495, 64);
            label8.Name = "label8";
            label8.Size = new Size(42, 18);
            label8.TabIndex = 41;
            label8.Text = "Make";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(495, 106);
            label9.Name = "label9";
            label9.Size = new Size(48, 18);
            label9.TabIndex = 42;
            label9.Text = "Model";
            // 
            // make_txt1
            // 
            make_txt1.Location = new Point(768, 56);
            make_txt1.Margin = new Padding(3, 2, 3, 2);
            make_txt1.Name = "make_txt1";
            make_txt1.Size = new Size(169, 26);
            make_txt1.TabIndex = 43;
            // 
            // model_txt1
            // 
            model_txt1.Location = new Point(768, 98);
            model_txt1.Margin = new Padding(3, 2, 3, 2);
            model_txt1.Name = "model_txt1";
            model_txt1.Size = new Size(169, 26);
            model_txt1.TabIndex = 44;
            // 
            // make_btn1
            // 
            make_btn1.Location = new Point(961, 51);
            make_btn1.Margin = new Padding(3, 2, 3, 2);
            make_btn1.Name = "make_btn1";
            make_btn1.Size = new Size(99, 31);
            make_btn1.TabIndex = 45;
            make_btn1.Text = "Add";
            make_btn1.UseVisualStyleBackColor = true;
            make_btn1.Click += make_btn1_Click;
            // 
            // model_btn1
            // 
            model_btn1.Location = new Point(961, 93);
            model_btn1.Margin = new Padding(3, 2, 3, 2);
            model_btn1.Name = "model_btn1";
            model_btn1.Size = new Size(99, 31);
            model_btn1.TabIndex = 46;
            model_btn1.Text = "Add";
            model_btn1.UseVisualStyleBackColor = true;
            // 
            // Insert
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1149, 648);
            Controls.Add(model_btn1);
            Controls.Add(make_btn1);
            Controls.Add(model_txt1);
            Controls.Add(make_txt1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(model_combo1);
            Controls.Add(make_combo1);
            Controls.Add(home_btn1);
            Controls.Add(load_btn);
            Controls.Add(view_btn);
            Controls.Add(insert_btn);
            Controls.Add(desc_txt);
            Controls.Add(label7);
            Controls.Add(stock_txt);
            Controls.Add(label6);
            Controls.Add(lower_txt);
            Controls.Add(label5);
            Controls.Add(upper_txt);
            Controls.Add(label4);
            Controls.Add(equip_name_txt);
            Controls.Add(label3);
            Controls.Add(part_name_txt);
            Controls.Add(label2);
            Controls.Add(part_id_txt);
            Controls.Add(label1);
            Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Insert";
            Text = "Insert Data";
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
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
        private Button insert_btn;
        private Button view_btn;
        private FileSystemWatcher fileSystemWatcher1;
        private Button load_btn;
        private Button home_btn1;
        private Label label9;
        private Label label8;
        private ComboBox model_combo1;
        private ComboBox make_combo1;
        private Button model_btn1;
        private Button make_btn1;
        private TextBox model_txt1;
        private TextBox make_txt1;
    }
}