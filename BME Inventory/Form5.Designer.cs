namespace BME_Inventory
{
    partial class distribute
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
            lower_lbl5 = new Label();
            upper_lbl5 = new Label();
            lower_lbl = new Label();
            upper_lbl = new Label();
            stock_txt5 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            update_btn3 = new Button();
            load_btn = new Button();
            part_name_lbl = new Label();
            equip_name_lbl = new Label();
            description_lbl = new Label();
            part_id_txt5 = new TextBox();
            stock_lbl = new Label();
            stock_txt6 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            home_btn5 = new Button();
            SuspendLayout();
            // 
            // lower_lbl5
            // 
            lower_lbl5.AutoSize = true;
            lower_lbl5.Location = new Point(169, 231);
            lower_lbl5.Name = "lower_lbl5";
            lower_lbl5.Size = new Size(83, 20);
            lower_lbl5.TabIndex = 35;
            lower_lbl5.Text = "Lower Limit";
            // 
            // upper_lbl5
            // 
            upper_lbl5.AutoSize = true;
            upper_lbl5.Location = new Point(169, 187);
            upper_lbl5.Name = "upper_lbl5";
            upper_lbl5.Size = new Size(85, 20);
            upper_lbl5.TabIndex = 34;
            upper_lbl5.Text = "Upper Limit";
            // 
            // lower_lbl
            // 
            lower_lbl.AutoSize = true;
            lower_lbl.Location = new Point(163, 231);
            lower_lbl.Name = "lower_lbl";
            lower_lbl.Size = new Size(0, 20);
            lower_lbl.TabIndex = 33;
            // 
            // upper_lbl
            // 
            upper_lbl.AutoSize = true;
            upper_lbl.Location = new Point(163, 187);
            upper_lbl.Name = "upper_lbl";
            upper_lbl.Size = new Size(0, 20);
            upper_lbl.TabIndex = 32;
            // 
            // stock_txt5
            // 
            stock_txt5.Location = new Point(307, 263);
            stock_txt5.Margin = new Padding(3, 4, 3, 4);
            stock_txt5.Name = "stock_txt5";
            stock_txt5.Size = new Size(241, 27);
            stock_txt5.TabIndex = 30;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(39, 315);
            label7.Name = "label7";
            label7.Size = new Size(82, 20);
            label7.TabIndex = 26;
            label7.Text = "Description";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 273);
            label6.Name = "label6";
            label6.Size = new Size(97, 20);
            label6.TabIndex = 25;
            label6.Text = "Current Stock";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 231);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 24;
            label5.Text = "Lower Limit";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 187);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 23;
            label4.Text = "Upper Limit";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 139);
            label3.Name = "label3";
            label3.Size = new Size(124, 20);
            label3.TabIndex = 22;
            label3.Text = "Equipment Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 93);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 21;
            label2.Text = "Part Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 49);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 20;
            label1.Text = "Part ID";
            // 
            // update_btn3
            // 
            update_btn3.Location = new Point(826, 263);
            update_btn3.Margin = new Padding(3, 4, 3, 4);
            update_btn3.Name = "update_btn3";
            update_btn3.Size = new Size(74, 31);
            update_btn3.TabIndex = 36;
            update_btn3.Text = "Update";
            update_btn3.UseVisualStyleBackColor = true;
            update_btn3.Click += update_btn3_Click;
            // 
            // load_btn
            // 
            load_btn.Location = new Point(445, 39);
            load_btn.Margin = new Padding(3, 4, 3, 4);
            load_btn.Name = "load_btn";
            load_btn.Size = new Size(94, 31);
            load_btn.TabIndex = 37;
            load_btn.Text = "Load";
            load_btn.UseVisualStyleBackColor = true;
            load_btn.Click += load_btn_Click;
            // 
            // part_name_lbl
            // 
            part_name_lbl.AutoSize = true;
            part_name_lbl.Location = new Point(169, 93);
            part_name_lbl.Name = "part_name_lbl";
            part_name_lbl.Size = new Size(79, 20);
            part_name_lbl.TabIndex = 39;
            part_name_lbl.Text = "Part Name";
            // 
            // equip_name_lbl
            // 
            equip_name_lbl.AutoSize = true;
            equip_name_lbl.Location = new Point(169, 139);
            equip_name_lbl.Name = "equip_name_lbl";
            equip_name_lbl.Size = new Size(124, 20);
            equip_name_lbl.TabIndex = 40;
            equip_name_lbl.Text = "Equipment Name";
            // 
            // description_lbl
            // 
            description_lbl.AutoSize = true;
            description_lbl.Location = new Point(169, 315);
            description_lbl.Name = "description_lbl";
            description_lbl.Size = new Size(82, 20);
            description_lbl.TabIndex = 41;
            description_lbl.Text = "Description";
            // 
            // part_id_txt5
            // 
            part_id_txt5.Location = new Point(163, 39);
            part_id_txt5.Margin = new Padding(3, 4, 3, 4);
            part_id_txt5.Name = "part_id_txt5";
            part_id_txt5.Size = new Size(241, 27);
            part_id_txt5.TabIndex = 42;
            // 
            // stock_lbl
            // 
            stock_lbl.AutoSize = true;
            stock_lbl.Location = new Point(169, 273);
            stock_lbl.Name = "stock_lbl";
            stock_lbl.Size = new Size(108, 20);
            stock_lbl.TabIndex = 43;
            stock_lbl.Text = "Stock Available";
            // 
            // stock_txt6
            // 
            stock_txt6.Location = new Point(567, 263);
            stock_txt6.Margin = new Padding(3, 4, 3, 4);
            stock_txt6.Name = "stock_txt6";
            stock_txt6.Size = new Size(241, 27);
            stock_txt6.TabIndex = 44;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(369, 231);
            label8.Name = "label8";
            label8.Size = new Size(33, 20);
            label8.TabIndex = 45;
            label8.Text = "Out";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(635, 231);
            label9.Name = "label9";
            label9.Size = new Size(21, 20);
            label9.TabIndex = 46;
            label9.Text = "In";
            // 
            // home_btn5
            // 
            home_btn5.Location = new Point(39, 471);
            home_btn5.Name = "home_btn5";
            home_btn5.Size = new Size(130, 38);
            home_btn5.TabIndex = 47;
            home_btn5.Text = "Home";
            home_btn5.UseVisualStyleBackColor = true;
            home_btn5.Click += button1_Click;
            // 
            // distribute
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(914, 600);
            Controls.Add(home_btn5);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(stock_txt6);
            Controls.Add(stock_lbl);
            Controls.Add(part_id_txt5);
            Controls.Add(description_lbl);
            Controls.Add(equip_name_lbl);
            Controls.Add(part_name_lbl);
            Controls.Add(load_btn);
            Controls.Add(update_btn3);
            Controls.Add(lower_lbl5);
            Controls.Add(upper_lbl5);
            Controls.Add(lower_lbl);
            Controls.Add(upper_lbl);
            Controls.Add(stock_txt5);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "distribute";
            Text = "Distribution Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lower_lbl5;
        private Label upper_lbl5;
        private Label lower_lbl;
        private Label upper_lbl;
        private TextBox stock_txt5;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button update_btn3;
        private Button load_btn;
        private Label part_name_lbl;
        private Label equip_name_lbl;
        private Label description_lbl;
        private TextBox part_id_txt5;
        private Label stock_lbl;
        private TextBox stock_txt6;
        private Label label8;
        private Label label9;
        private Button home_btn5;
    }
}