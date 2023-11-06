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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            distribute_btn = new Button();
            add_btn = new Button();
            edit_btn = new Button();
            exit_btn6 = new Button();
            label1 = new Label();
            table_btn6 = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
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
            distribute_btn.Click += button1_Click;
            // 
            // add_btn
            // 
            add_btn.FlatAppearance.BorderSize = 0;
            add_btn.FlatStyle = FlatStyle.Flat;
            add_btn.Image = (Image)resources.GetObject("add_btn.Image");
            add_btn.ImageAlign = ContentAlignment.MiddleLeft;
            add_btn.Location = new Point(16, 158);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(319, 58);
            add_btn.TabIndex = 1;
            add_btn.Text = "Add New";
            add_btn.UseVisualStyleBackColor = true;
            add_btn.Click += button2_Click;
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
            edit_btn.Click += button3_Click;
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
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.AutoSize = true;
            panel1.BackColor = Color.Azure;
            panel1.Controls.Add(exit_btn6);
            panel1.Controls.Add(distribute_btn);
            panel1.Controls.Add(edit_btn);
            panel1.Controls.Add(add_btn);
            panel1.Controls.Add(table_btn6);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(341, 689);
            panel1.TabIndex = 9;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1287, 689);
            Controls.Add(panel1);
            Font = new Font("Nunito", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            TransparencyKey = Color.Cyan;
            WindowState = FormWindowState.Maximized;
            Load += Home_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button distribute_btn;
        private Button add_btn;
        private Button edit_btn;
        private Label label1;
        private Button table_btn6;
        private Button exit_btn6;
        private Panel panel1;
    }
}