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
            save_btn = new MaterialSkin.Controls.MaterialButton();
            part_id_txt = new TextBox();
            label14 = new Label();
            add_btn = new MaterialSkin.Controls.MaterialButton();
            label12 = new Label();
            label11 = new Label();
            label13 = new Label();
            panel4 = new Panel();
            success_lbl1 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 50);
            label1.Name = "label1";
            label1.Size = new Size(62, 21);
            label1.TabIndex = 0;
            label1.Text = "Part ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 210);
            label2.Name = "label2";
            label2.Size = new Size(92, 21);
            label2.TabIndex = 2;
            label2.Text = "Part Name";
            // 
            // part_name_txt
            // 
            part_name_txt.AutoCompleteMode = AutoCompleteMode.Suggest;
            part_name_txt.BorderStyle = BorderStyle.FixedSingle;
            part_name_txt.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            part_name_txt.Location = new Point(160, 210);
            part_name_txt.Name = "part_name_txt";
            part_name_txt.Size = new Size(336, 29);
            part_name_txt.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 90);
            label3.Name = "label3";
            label3.Size = new Size(144, 21);
            label3.TabIndex = 4;
            label3.Text = "Equipment Name";
            // 
            // equip_name_txt
            // 
            equip_name_txt.AutoCompleteMode = AutoCompleteMode.Suggest;
            equip_name_txt.BorderStyle = BorderStyle.FixedSingle;
            equip_name_txt.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            equip_name_txt.Location = new Point(160, 90);
            equip_name_txt.Name = "equip_name_txt";
            equip_name_txt.Size = new Size(336, 29);
            equip_name_txt.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(513, 183);
            label4.Name = "label4";
            label4.Size = new Size(94, 21);
            label4.TabIndex = 6;
            label4.Text = "Upper limit";
            // 
            // upper_txt
            // 
            upper_txt.BorderStyle = BorderStyle.FixedSingle;
            upper_txt.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            upper_txt.Location = new Point(633, 183);
            upper_txt.Name = "upper_txt";
            upper_txt.Size = new Size(336, 29);
            upper_txt.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(513, 223);
            label5.Name = "label5";
            label5.Size = new Size(95, 21);
            label5.TabIndex = 8;
            label5.Text = "Lower limit";
            // 
            // lower_txt
            // 
            lower_txt.BorderStyle = BorderStyle.FixedSingle;
            lower_txt.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lower_txt.Location = new Point(633, 223);
            lower_txt.Name = "lower_txt";
            lower_txt.Size = new Size(336, 29);
            lower_txt.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(513, 263);
            label6.Name = "label6";
            label6.Size = new Size(117, 21);
            label6.TabIndex = 10;
            label6.Text = "Current Stock";
            // 
            // stock_txt
            // 
            stock_txt.BorderStyle = BorderStyle.FixedSingle;
            stock_txt.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            stock_txt.Location = new Point(633, 263);
            stock_txt.Name = "stock_txt";
            stock_txt.Size = new Size(338, 29);
            stock_txt.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(12, 250);
            label7.Name = "label7";
            label7.Size = new Size(99, 21);
            label7.TabIndex = 12;
            label7.Text = "Description";
            // 
            // desc_txt
            // 
            desc_txt.AutoCompleteMode = AutoCompleteMode.Suggest;
            desc_txt.BorderStyle = BorderStyle.FixedSingle;
            desc_txt.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            desc_txt.Location = new Point(160, 248);
            desc_txt.Multiline = true;
            desc_txt.Name = "desc_txt";
            desc_txt.Size = new Size(336, 166);
            desc_txt.TabIndex = 13;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // make_combo1
            // 
            make_combo1.FlatStyle = FlatStyle.System;
            make_combo1.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            make_combo1.FormattingEnabled = true;
            make_combo1.Location = new Point(160, 130);
            make_combo1.Name = "make_combo1";
            make_combo1.Size = new Size(336, 29);
            make_combo1.TabIndex = 39;
            // 
            // model_combo1
            // 
            model_combo1.FlatStyle = FlatStyle.System;
            model_combo1.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            model_combo1.FormattingEnabled = true;
            model_combo1.Location = new Point(160, 170);
            model_combo1.Name = "model_combo1";
            model_combo1.Size = new Size(336, 29);
            model_combo1.TabIndex = 40;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(12, 134);
            label8.Name = "label8";
            label8.Size = new Size(53, 21);
            label8.TabIndex = 41;
            label8.Text = "Make";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(12, 170);
            label9.Name = "label9";
            label9.Size = new Size(59, 21);
            label9.TabIndex = 42;
            label9.Text = "Model";
            // 
            // make_txt1
            // 
            make_txt1.AutoCompleteMode = AutoCompleteMode.Suggest;
            make_txt1.BorderStyle = BorderStyle.FixedSingle;
            make_txt1.Location = new Point(590, 53);
            make_txt1.Name = "make_txt1";
            make_txt1.Size = new Size(316, 30);
            make_txt1.TabIndex = 43;
            // 
            // model_txt1
            // 
            model_txt1.AutoCompleteMode = AutoCompleteMode.Suggest;
            model_txt1.BorderStyle = BorderStyle.FixedSingle;
            model_txt1.Location = new Point(590, 93);
            model_txt1.Name = "model_txt1";
            model_txt1.Size = new Size(316, 30);
            model_txt1.TabIndex = 44;
            // 
            // save_btn
            // 
            save_btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            save_btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            save_btn.Depth = 0;
            save_btn.HighEmphasis = true;
            save_btn.Icon = null;
            save_btn.Location = new Point(160, 435);
            save_btn.Margin = new Padding(4, 6, 4, 6);
            save_btn.MouseState = MaterialSkin.MouseState.HOVER;
            save_btn.Name = "save_btn";
            save_btn.NoAccentTextColor = Color.Empty;
            save_btn.Size = new Size(119, 36);
            save_btn.TabIndex = 53;
            save_btn.Text = "Save Details";
            save_btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            save_btn.UseAccentColor = false;
            save_btn.UseVisualStyleBackColor = true;
            save_btn.Click += save_btn_Click;
            // 
            // part_id_txt
            // 
            part_id_txt.AutoCompleteMode = AutoCompleteMode.Suggest;
            part_id_txt.BorderStyle = BorderStyle.FixedSingle;
            part_id_txt.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            part_id_txt.Location = new Point(160, 50);
            part_id_txt.Name = "part_id_txt";
            part_id_txt.Size = new Size(336, 29);
            part_id_txt.TabIndex = 53;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Google Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(12, 9);
            label14.Name = "label14";
            label14.Size = new Size(223, 25);
            label14.TabIndex = 52;
            label14.Text = "Add Spare Parts Details";
            // 
            // add_btn
            // 
            add_btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            add_btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            add_btn.Depth = 0;
            add_btn.HighEmphasis = true;
            add_btn.Icon = null;
            add_btn.Location = new Point(590, 136);
            add_btn.Margin = new Padding(4, 6, 4, 6);
            add_btn.MouseState = MaterialSkin.MouseState.HOVER;
            add_btn.Name = "add_btn";
            add_btn.NoAccentTextColor = Color.Empty;
            add_btn.Size = new Size(119, 36);
            add_btn.TabIndex = 52;
            add_btn.Text = "Save Details";
            add_btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            add_btn.UseAccentColor = false;
            add_btn.UseVisualStyleBackColor = true;
            add_btn.Click += materialButton1_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(515, 93);
            label12.Name = "label12";
            label12.Size = new Size(59, 21);
            label12.TabIndex = 51;
            label12.Text = "Model";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Google Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(513, 9);
            label11.Name = "label11";
            label11.Size = new Size(445, 25);
            label11.TabIndex = 47;
            label11.Text = "If Make and Model Not Available Add Them Here";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(515, 53);
            label13.Name = "label13";
            label13.Size = new Size(53, 21);
            label13.TabIndex = 50;
            label13.Text = "Make";
            // 
            // panel4
            // 
            panel4.AutoSize = true;
            panel4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel4.BackColor = Color.GhostWhite;
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(996, 0);
            panel4.TabIndex = 54;
            // 
            // success_lbl1
            // 
            success_lbl1.AutoSize = true;
            success_lbl1.Depth = 0;
            success_lbl1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            success_lbl1.Location = new Point(614, 343);
            success_lbl1.MouseState = MaterialSkin.MouseState.HOVER;
            success_lbl1.Name = "success_lbl1";
            success_lbl1.Size = new Size(1, 0);
            success_lbl1.TabIndex = 54;
            // 
            // Create
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(996, 500);
            Controls.Add(add_btn);
            Controls.Add(success_lbl1);
            Controls.Add(panel4);
            Controls.Add(label12);
            Controls.Add(desc_txt);
            Controls.Add(lower_txt);
            Controls.Add(label9);
            Controls.Add(label11);
            Controls.Add(model_combo1);
            Controls.Add(label4);
            Controls.Add(label8);
            Controls.Add(label13);
            Controls.Add(make_combo1);
            Controls.Add(save_btn);
            Controls.Add(label2);
            Controls.Add(make_txt1);
            Controls.Add(part_name_txt);
            Controls.Add(model_txt1);
            Controls.Add(label1);
            Controls.Add(upper_txt);
            Controls.Add(label3);
            Controls.Add(part_id_txt);
            Controls.Add(equip_name_txt);
            Controls.Add(stock_txt);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label14);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Create";
            Text = "Insert Data";
            TransparencyKey = Color.FromArgb(255, 255, 128);
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
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
        private TextBox model_txt1;
        private TextBox make_txt1;
        private Label label12;
        private Label label11;
        private Label label13;
        private Panel panel4;
        private Label label14;
        private TextBox part_id_txt;
        private MaterialSkin.Controls.MaterialButton add_btn;
        private MaterialSkin.Controls.MaterialButton save_btn;
        private MaterialSkin.Controls.MaterialLabel success_lbl1;
    }
}