namespace BME_Inventory
{
    partial class Home
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
            distribute_btn = new Button();
            add_btn = new Button();
            edit_btn = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            table_btn6 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // distribute_btn
            // 
            distribute_btn.Location = new Point(7, 26);
            distribute_btn.Name = "distribute_btn";
            distribute_btn.Size = new Size(171, 58);
            distribute_btn.TabIndex = 0;
            distribute_btn.Text = "Distribute";
            distribute_btn.UseVisualStyleBackColor = true;
            distribute_btn.Click += button1_Click;
            // 
            // add_btn
            // 
            add_btn.Location = new Point(184, 26);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(171, 58);
            add_btn.TabIndex = 1;
            add_btn.Text = "Add New";
            add_btn.UseVisualStyleBackColor = true;
            add_btn.Click += button2_Click;
            // 
            // edit_btn
            // 
            edit_btn.Location = new Point(362, 26);
            edit_btn.Name = "edit_btn";
            edit_btn.Size = new Size(171, 58);
            edit_btn.TabIndex = 2;
            edit_btn.Text = "Edit Entries";
            edit_btn.UseVisualStyleBackColor = true;
            edit_btn.Click += button3_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(edit_btn);
            groupBox1.Controls.Add(add_btn);
            groupBox1.Controls.Add(distribute_btn);
            groupBox1.Location = new Point(14, 571);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(724, 95);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Navigation";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nunito", 25.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(35, 34);
            label1.Name = "label1";
            label1.Size = new Size(304, 59);
            label1.TabIndex = 4;
            label1.Text = "DASHBOARD";
            // 
            // table_btn6
            // 
            table_btn6.Location = new Point(554, 597);
            table_btn6.Name = "table_btn6";
            table_btn6.Size = new Size(171, 58);
            table_btn6.TabIndex = 3;
            table_btn6.Text = "Show Table";
            table_btn6.UseVisualStyleBackColor = true;
            table_btn6.Click += table_btn6_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(1287, 689);
            Controls.Add(table_btn6);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Font = new Font("Nunito", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Home";
            Text = "Home";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button distribute_btn;
        private Button add_btn;
        private Button edit_btn;
        private GroupBox groupBox1;
        private Label label1;
        private Button table_btn6;
    }
}