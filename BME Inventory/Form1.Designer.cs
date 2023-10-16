namespace BME_Inventory
{
    partial class Form1
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
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 65);
            label1.Name = "label1";
            label1.Size = new Size(42, 16);
            label1.TabIndex = 0;
            label1.Text = "Part ID";
            // 
            // part_id_txt
            // 
            part_id_txt.Location = new Point(159, 62);
            part_id_txt.Name = "part_id_txt";
            part_id_txt.Size = new Size(197, 23);
            part_id_txt.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 114);
            label2.Name = "label2";
            label2.Size = new Size(63, 16);
            label2.TabIndex = 2;
            label2.Text = "Part Name";
            // 
            // part_name_txt
            // 
            part_name_txt.Location = new Point(159, 111);
            part_name_txt.Name = "part_name_txt";
            part_name_txt.Size = new Size(197, 23);
            part_name_txt.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 164);
            label3.Name = "label3";
            label3.Size = new Size(100, 16);
            label3.TabIndex = 4;
            label3.Text = "Equipment Name";
            // 
            // equip_name_txt
            // 
            equip_name_txt.Location = new Point(159, 161);
            equip_name_txt.Name = "equip_name_txt";
            equip_name_txt.Size = new Size(197, 23);
            equip_name_txt.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 212);
            label4.Name = "label4";
            label4.Size = new Size(66, 16);
            label4.TabIndex = 6;
            label4.Text = "Upper limit";
            // 
            // upper_txt
            // 
            upper_txt.Location = new Point(159, 209);
            upper_txt.Name = "upper_txt";
            upper_txt.Size = new Size(197, 23);
            upper_txt.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 265);
            label5.Name = "label5";
            label5.Size = new Size(66, 16);
            label5.TabIndex = 8;
            label5.Text = "Lower limit";
            // 
            // lower_txt
            // 
            lower_txt.Location = new Point(159, 261);
            lower_txt.Name = "lower_txt";
            lower_txt.Size = new Size(197, 23);
            lower_txt.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(48, 313);
            label6.Name = "label6";
            label6.Size = new Size(79, 16);
            label6.TabIndex = 10;
            label6.Text = "Current Stock";
            // 
            // stock_txt
            // 
            stock_txt.Location = new Point(159, 309);
            stock_txt.Name = "stock_txt";
            stock_txt.Size = new Size(197, 23);
            stock_txt.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(48, 358);
            label7.Name = "label7";
            label7.Size = new Size(67, 16);
            label7.TabIndex = 12;
            label7.Text = "Description";
            // 
            // desc_txt
            // 
            desc_txt.Location = new Point(159, 355);
            desc_txt.Name = "desc_txt";
            desc_txt.Size = new Size(227, 23);
            desc_txt.TabIndex = 13;
            // 
            // insert_btn
            // 
            insert_btn.Location = new Point(152, 405);
            insert_btn.Name = "insert_btn";
            insert_btn.Size = new Size(105, 46);
            insert_btn.TabIndex = 14;
            insert_btn.Text = "Insert";
            insert_btn.UseVisualStyleBackColor = true;
            insert_btn.Click += insert_btn_Click;
            // 
            // view_btn
            // 
            view_btn.Location = new Point(464, 58);
            view_btn.Name = "view_btn";
            view_btn.Size = new Size(137, 39);
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
            // button1
            // 
            button1.Location = new Point(638, 52);
            button1.Name = "button1";
            button1.Size = new Size(106, 46);
            button1.TabIndex = 16;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 480);
            Controls.Add(button1);
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
            Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Insert Data";
            Load += Form1_Load;
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
        private Button button1;
    }
}