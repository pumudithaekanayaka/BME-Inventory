namespace BME_Inventory
{
    partial class Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit));
            load_btn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            update_btn = new Button();
            part_id_txt_edit = new TextBox();
            part_name_txt_edit = new TextBox();
            equip_name_txt_edit = new TextBox();
            desc_txt_edit = new TextBox();
            upper_lbl = new Label();
            lower_lbl = new Label();
            upper_lbl_edit = new Label();
            lower_lbl_edit = new Label();
            delete_btn = new Button();
            pnl_home = new Panel();
            label8 = new Label();
            stock_lbl_edit = new Label();
            make_combo1 = new ComboBox();
            model_combo1 = new ComboBox();
            label14 = new Label();
            label15 = new Label();
            model_lbl_edit = new Label();
            make_lbl_edit = new Label();
            pnl_home.SuspendLayout();
            SuspendLayout();
            // 
            // load_btn
            // 
            load_btn.BackColor = Color.CornflowerBlue;
            load_btn.FlatAppearance.BorderSize = 0;
            load_btn.FlatStyle = FlatStyle.Flat;
            load_btn.Location = new Point(422, 15);
            load_btn.Name = "load_btn";
            load_btn.Size = new Size(95, 40);
            load_btn.TabIndex = 1;
            load_btn.Text = "Load";
            load_btn.UseVisualStyleBackColor = false;
            load_btn.Click += load_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 15);
            label1.Name = "label1";
            label1.Size = new Size(64, 22);
            label1.TabIndex = 3;
            label1.Text = "Part ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 65);
            label2.Name = "label2";
            label2.Size = new Size(96, 22);
            label2.TabIndex = 4;
            label2.Text = "Part Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 115);
            label3.Name = "label3";
            label3.Size = new Size(152, 22);
            label3.TabIndex = 5;
            label3.Text = "Equipment Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 265);
            label4.Name = "label4";
            label4.Size = new Size(105, 22);
            label4.TabIndex = 6;
            label4.Text = "Upper Limit";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 315);
            label5.Name = "label5";
            label5.Size = new Size(105, 22);
            label5.TabIndex = 7;
            label5.Text = "Lower Limit";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 365);
            label6.Name = "label6";
            label6.Size = new Size(123, 22);
            label6.TabIndex = 8;
            label6.Text = "Current Stock";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 415);
            label7.Name = "label7";
            label7.Size = new Size(106, 22);
            label7.TabIndex = 9;
            label7.Text = "Description";
            // 
            // update_btn
            // 
            update_btn.BackColor = Color.CornflowerBlue;
            update_btn.FlatAppearance.BorderSize = 0;
            update_btn.FlatStyle = FlatStyle.Flat;
            update_btn.Location = new Point(13, 540);
            update_btn.Name = "update_btn";
            update_btn.Size = new Size(95, 40);
            update_btn.TabIndex = 10;
            update_btn.Text = "Update";
            update_btn.UseVisualStyleBackColor = false;
            update_btn.Click += update_btn_Click;
            // 
            // part_id_txt_edit
            // 
            part_id_txt_edit.BorderStyle = BorderStyle.FixedSingle;
            part_id_txt_edit.Location = new Point(183, 15);
            part_id_txt_edit.Name = "part_id_txt_edit";
            part_id_txt_edit.Size = new Size(211, 30);
            part_id_txt_edit.TabIndex = 11;
            // 
            // part_name_txt_edit
            // 
            part_name_txt_edit.BorderStyle = BorderStyle.FixedSingle;
            part_name_txt_edit.Location = new Point(183, 65);
            part_name_txt_edit.Name = "part_name_txt_edit";
            part_name_txt_edit.Size = new Size(211, 30);
            part_name_txt_edit.TabIndex = 12;
            // 
            // equip_name_txt_edit
            // 
            equip_name_txt_edit.BorderStyle = BorderStyle.FixedSingle;
            equip_name_txt_edit.Location = new Point(183, 115);
            equip_name_txt_edit.Name = "equip_name_txt_edit";
            equip_name_txt_edit.Size = new Size(211, 30);
            equip_name_txt_edit.TabIndex = 13;
            // 
            // desc_txt_edit
            // 
            desc_txt_edit.BorderStyle = BorderStyle.FixedSingle;
            desc_txt_edit.Location = new Point(183, 415);
            desc_txt_edit.Multiline = true;
            desc_txt_edit.Name = "desc_txt_edit";
            desc_txt_edit.Size = new Size(394, 119);
            desc_txt_edit.TabIndex = 15;
            // 
            // upper_lbl
            // 
            upper_lbl.AutoSize = true;
            upper_lbl.Location = new Point(120, 372);
            upper_lbl.Name = "upper_lbl";
            upper_lbl.Size = new Size(0, 22);
            upper_lbl.TabIndex = 16;
            // 
            // lower_lbl
            // 
            lower_lbl.AutoSize = true;
            lower_lbl.Location = new Point(120, 405);
            lower_lbl.Name = "lower_lbl";
            lower_lbl.Size = new Size(0, 22);
            lower_lbl.TabIndex = 17;
            // 
            // upper_lbl_edit
            // 
            upper_lbl_edit.AutoSize = true;
            upper_lbl_edit.Location = new Point(183, 265);
            upper_lbl_edit.Name = "upper_lbl_edit";
            upper_lbl_edit.Size = new Size(105, 22);
            upper_lbl_edit.TabIndex = 18;
            upper_lbl_edit.Text = "Upper Limit";
            // 
            // lower_lbl_edit
            // 
            lower_lbl_edit.AutoSize = true;
            lower_lbl_edit.Location = new Point(183, 315);
            lower_lbl_edit.Name = "lower_lbl_edit";
            lower_lbl_edit.Size = new Size(105, 22);
            lower_lbl_edit.TabIndex = 19;
            lower_lbl_edit.Text = "Lower Limit";
            // 
            // delete_btn
            // 
            delete_btn.BackColor = Color.CornflowerBlue;
            delete_btn.FlatAppearance.BorderSize = 0;
            delete_btn.FlatStyle = FlatStyle.Flat;
            delete_btn.Location = new Point(142, 540);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(95, 40);
            delete_btn.TabIndex = 20;
            delete_btn.Text = "Delete";
            delete_btn.UseVisualStyleBackColor = false;
            delete_btn.Click += delete_btn_Click;
            // 
            // pnl_home
            // 
            pnl_home.Controls.Add(label8);
            pnl_home.Dock = DockStyle.Top;
            pnl_home.Location = new Point(0, 0);
            pnl_home.Name = "pnl_home";
            pnl_home.Size = new Size(333, 60);
            pnl_home.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Fira Sans Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(75, 18);
            label8.Name = "label8";
            label8.Size = new Size(182, 24);
            label8.TabIndex = 1;
            label8.Text = "Navigation Panel";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // stock_lbl_edit
            // 
            stock_lbl_edit.AutoSize = true;
            stock_lbl_edit.Location = new Point(183, 365);
            stock_lbl_edit.Name = "stock_lbl_edit";
            stock_lbl_edit.Size = new Size(57, 22);
            stock_lbl_edit.TabIndex = 29;
            stock_lbl_edit.Text = "Stock";
            // 
            // make_combo1
            // 
            make_combo1.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            make_combo1.FormattingEnabled = true;
            make_combo1.Location = new Point(303, 165);
            make_combo1.Name = "make_combo1";
            make_combo1.Size = new Size(336, 29);
            make_combo1.TabIndex = 43;
            // 
            // model_combo1
            // 
            model_combo1.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            model_combo1.FormattingEnabled = true;
            model_combo1.Location = new Point(303, 215);
            model_combo1.Name = "model_combo1";
            model_combo1.Size = new Size(336, 29);
            model_combo1.TabIndex = 44;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(18, 215);
            label14.Name = "label14";
            label14.Size = new Size(59, 21);
            label14.TabIndex = 46;
            label14.Text = "Model";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(18, 165);
            label15.Name = "label15";
            label15.Size = new Size(53, 21);
            label15.TabIndex = 45;
            label15.Text = "Make";
            // 
            // model_lbl_edit
            // 
            model_lbl_edit.AutoSize = true;
            model_lbl_edit.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            model_lbl_edit.Location = new Point(183, 215);
            model_lbl_edit.Name = "model_lbl_edit";
            model_lbl_edit.Size = new Size(59, 21);
            model_lbl_edit.TabIndex = 48;
            model_lbl_edit.Text = "Model";
            // 
            // make_lbl_edit
            // 
            make_lbl_edit.AutoSize = true;
            make_lbl_edit.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            make_lbl_edit.Location = new Point(183, 165);
            make_lbl_edit.Name = "make_lbl_edit";
            make_lbl_edit.Size = new Size(53, 21);
            make_lbl_edit.TabIndex = 47;
            make_lbl_edit.Text = "Make";
            // 
            // Edit
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(662, 609);
            Controls.Add(model_lbl_edit);
            Controls.Add(label1);
            Controls.Add(model_combo1);
            Controls.Add(make_lbl_edit);
            Controls.Add(desc_txt_edit);
            Controls.Add(load_btn);
            Controls.Add(equip_name_txt_edit);
            Controls.Add(make_combo1);
            Controls.Add(upper_lbl);
            Controls.Add(label2);
            Controls.Add(part_name_txt_edit);
            Controls.Add(lower_lbl);
            Controls.Add(label3);
            Controls.Add(part_id_txt_edit);
            Controls.Add(label14);
            Controls.Add(upper_lbl_edit);
            Controls.Add(label4);
            Controls.Add(update_btn);
            Controls.Add(label15);
            Controls.Add(lower_lbl_edit);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(stock_lbl_edit);
            Controls.Add(delete_btn);
            Controls.Add(label6);
            Font = new Font("Google Sans", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Edit";
            Text = "Edit Data";
            WindowState = FormWindowState.Maximized;
            pnl_home.ResumeLayout(false);
            pnl_home.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button load_btn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button update_btn;
        private TextBox part_id_txt_edit;
        private TextBox part_name_txt_edit;
        private TextBox equip_name_txt_edit;
        private TextBox stock_txt1;
        private TextBox desc_txt_edit;
        private Label upper_lbl;
        private Label lower_lbl;
        private Label upper_lbl_edit;
        private Label lower_lbl_edit;
        private Button delete_btn;
        private Panel pnl_home;
        private Label label8;
        private Label stock_lbl_edit;
        private ComboBox make_combo1;
        private ComboBox model_combo1;
        private Label label14;
        private Label label15;
        private Label make_lbl_edit;
        private Label model_lbl_edit;
    }
}