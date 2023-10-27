namespace BME_Inventory
{
    partial class View
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
            load_btn = new Button();
            exit_btn2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            update_btn = new Button();
            part_id_txt1 = new TextBox();
            part_name_txt1 = new TextBox();
            equip_name_txt1 = new TextBox();
            stock_txt1 = new TextBox();
            desc_txt1 = new TextBox();
            upper_lbl = new Label();
            lower_lbl = new Label();
            upper_lbl1 = new Label();
            lower_lbl1 = new Label();
            delete_btn = new Button();
            dataGridView1 = new DataGridView();
            home_btn2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // load_btn
            // 
            load_btn.Location = new Point(127, 309);
            load_btn.Name = "load_btn";
            load_btn.Size = new Size(94, 40);
            load_btn.TabIndex = 1;
            load_btn.Text = "Load";
            load_btn.UseVisualStyleBackColor = true;
            load_btn.Click += load_btn_Click;
            // 
            // exit_btn2
            // 
            exit_btn2.Location = new Point(365, 312);
            exit_btn2.Name = "exit_btn2";
            exit_btn2.Size = new Size(99, 36);
            exit_btn2.TabIndex = 2;
            exit_btn2.Text = "Exit";
            exit_btn2.UseVisualStyleBackColor = true;
            exit_btn2.Click += back_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 43);
            label1.Name = "label1";
            label1.Size = new Size(52, 17);
            label1.TabIndex = 3;
            label1.Text = "Part ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 76);
            label2.Name = "label2";
            label2.Size = new Size(78, 17);
            label2.TabIndex = 4;
            label2.Text = "Part Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 110);
            label3.Name = "label3";
            label3.Size = new Size(119, 17);
            label3.TabIndex = 5;
            label3.Text = "Equipment Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 146);
            label4.Name = "label4";
            label4.Size = new Size(82, 17);
            label4.TabIndex = 6;
            label4.Text = "Upper Limit";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 179);
            label5.Name = "label5";
            label5.Size = new Size(82, 17);
            label5.TabIndex = 7;
            label5.Text = "Lower Limit";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 211);
            label6.Name = "label6";
            label6.Size = new Size(93, 17);
            label6.TabIndex = 8;
            label6.Text = "Current Stock";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 242);
            label7.Name = "label7";
            label7.Size = new Size(75, 17);
            label7.TabIndex = 9;
            label7.Text = "Description";
            // 
            // update_btn
            // 
            update_btn.Location = new Point(25, 309);
            update_btn.Name = "update_btn";
            update_btn.Size = new Size(78, 40);
            update_btn.TabIndex = 10;
            update_btn.Text = "Update";
            update_btn.UseVisualStyleBackColor = true;
            update_btn.Click += update_btn_Click;
            // 
            // part_id_txt1
            // 
            part_id_txt1.Location = new Point(158, 36);
            part_id_txt1.Name = "part_id_txt1";
            part_id_txt1.Size = new Size(211, 24);
            part_id_txt1.TabIndex = 11;
            // 
            // part_name_txt1
            // 
            part_name_txt1.Location = new Point(158, 66);
            part_name_txt1.Name = "part_name_txt1";
            part_name_txt1.Size = new Size(211, 24);
            part_name_txt1.TabIndex = 12;
            // 
            // equip_name_txt1
            // 
            equip_name_txt1.Location = new Point(158, 103);
            equip_name_txt1.Name = "equip_name_txt1";
            equip_name_txt1.Size = new Size(211, 24);
            equip_name_txt1.TabIndex = 13;
            // 
            // stock_txt1
            // 
            stock_txt1.Location = new Point(158, 199);
            stock_txt1.Name = "stock_txt1";
            stock_txt1.Size = new Size(211, 24);
            stock_txt1.TabIndex = 14;
            // 
            // desc_txt1
            // 
            desc_txt1.Location = new Point(158, 235);
            desc_txt1.Name = "desc_txt1";
            desc_txt1.Size = new Size(211, 24);
            desc_txt1.TabIndex = 15;
            // 
            // upper_lbl
            // 
            upper_lbl.AutoSize = true;
            upper_lbl.Location = new Point(135, 146);
            upper_lbl.Name = "upper_lbl";
            upper_lbl.Size = new Size(0, 17);
            upper_lbl.TabIndex = 16;
            // 
            // lower_lbl
            // 
            lower_lbl.AutoSize = true;
            lower_lbl.Location = new Point(135, 179);
            lower_lbl.Name = "lower_lbl";
            lower_lbl.Size = new Size(0, 17);
            lower_lbl.TabIndex = 17;
            // 
            // upper_lbl1
            // 
            upper_lbl1.AutoSize = true;
            upper_lbl1.Location = new Point(158, 146);
            upper_lbl1.Name = "upper_lbl1";
            upper_lbl1.Size = new Size(82, 17);
            upper_lbl1.TabIndex = 18;
            upper_lbl1.Text = "Upper Limit";
            // 
            // lower_lbl1
            // 
            lower_lbl1.AutoSize = true;
            lower_lbl1.Location = new Point(158, 179);
            lower_lbl1.Name = "lower_lbl1";
            lower_lbl1.Size = new Size(82, 17);
            lower_lbl1.TabIndex = 19;
            lower_lbl1.Text = "Lower Limit";
            lower_lbl1.Click += lower_lbl1_Click;
            // 
            // delete_btn
            // 
            delete_btn.Location = new Point(250, 309);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(94, 40);
            delete_btn.TabIndex = 20;
            delete_btn.Text = "Delete";
            delete_btn.UseVisualStyleBackColor = true;
            delete_btn.Click += delete_btn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(390, 48);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(265, 230);
            dataGridView1.TabIndex = 21;
            // 
            // home_btn2
            // 
            home_btn2.Location = new Point(488, 313);
            home_btn2.Name = "home_btn2";
            home_btn2.Size = new Size(78, 33);
            home_btn2.TabIndex = 22;
            home_btn2.Text = "Home";
            home_btn2.UseVisualStyleBackColor = true;
            home_btn2.Click += home_btn2_Click;
            // 
            // View
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(686, 390);
            Controls.Add(home_btn2);
            Controls.Add(dataGridView1);
            Controls.Add(delete_btn);
            Controls.Add(lower_lbl1);
            Controls.Add(upper_lbl1);
            Controls.Add(lower_lbl);
            Controls.Add(upper_lbl);
            Controls.Add(desc_txt1);
            Controls.Add(stock_txt1);
            Controls.Add(equip_name_txt1);
            Controls.Add(part_name_txt1);
            Controls.Add(part_id_txt1);
            Controls.Add(update_btn);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(exit_btn2);
            Controls.Add(load_btn);
            Font = new Font("Berlin Sans FB", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "View";
            Text = "View Data";
            Load += View_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button load_btn;
        private Button exit_btn2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button update_btn;
        private TextBox part_id_txt1;
        private TextBox part_name_txt1;
        private TextBox equip_name_txt1;
        private TextBox stock_txt1;
        private TextBox desc_txt1;
        private Label upper_lbl;
        private Label lower_lbl;
        private Label upper_lbl1;
        private Label lower_lbl1;
        private Button delete_btn;
        private DataGridView dataGridView1;
        private Button home_btn2;
    }
}