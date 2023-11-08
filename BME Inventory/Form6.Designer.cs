namespace BME_Inventory
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            btn_distribute = new Button();
            btn_add = new Button();
            btn_edit = new Button();
            btn_exit = new Button();
            label1 = new Label();
            btn_table = new Button();
            panel1 = new Panel();
            btn_receive = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_distribute
            // 
            btn_distribute.FlatAppearance.BorderSize = 0;
            btn_distribute.FlatStyle = FlatStyle.Flat;
            btn_distribute.Image = (Image)resources.GetObject("btn_distribute.Image");
            btn_distribute.ImageAlign = ContentAlignment.MiddleLeft;
            btn_distribute.Location = new Point(16, 94);
            btn_distribute.Name = "btn_distribute";
            btn_distribute.Size = new Size(322, 58);
            btn_distribute.TabIndex = 0;
            btn_distribute.Text = "Distribute";
            btn_distribute.UseVisualStyleBackColor = true;
            btn_distribute.Click += button1_Click;
            // 
            // btn_add
            // 
            btn_add.FlatAppearance.BorderSize = 0;
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.Image = (Image)resources.GetObject("btn_add.Image");
            btn_add.ImageAlign = ContentAlignment.MiddleLeft;
            btn_add.Location = new Point(12, 222);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(319, 58);
            btn_add.TabIndex = 1;
            btn_add.Text = "Add New";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += button2_Click;
            // 
            // btn_edit
            // 
            btn_edit.FlatAppearance.BorderSize = 0;
            btn_edit.FlatStyle = FlatStyle.Flat;
            btn_edit.Image = (Image)resources.GetObject("btn_edit.Image");
            btn_edit.ImageAlign = ContentAlignment.MiddleLeft;
            btn_edit.Location = new Point(16, 286);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(319, 58);
            btn_edit.TabIndex = 2;
            btn_edit.Text = "Edit Entries";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += button3_Click;
            // 
            // btn_exit
            // 
            btn_exit.FlatAppearance.BorderSize = 0;
            btn_exit.FlatStyle = FlatStyle.Flat;
            btn_exit.Image = (Image)resources.GetObject("btn_exit.Image");
            btn_exit.ImageAlign = ContentAlignment.MiddleLeft;
            btn_exit.Location = new Point(12, 423);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(319, 58);
            btn_exit.TabIndex = 5;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += exit_btn6_Click;
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
            // btn_table
            // 
            btn_table.FlatAppearance.BorderSize = 0;
            btn_table.FlatStyle = FlatStyle.Flat;
            btn_table.Image = (Image)resources.GetObject("btn_table.Image");
            btn_table.ImageAlign = ContentAlignment.MiddleLeft;
            btn_table.Location = new Point(12, 359);
            btn_table.Name = "btn_table";
            btn_table.Size = new Size(319, 58);
            btn_table.TabIndex = 3;
            btn_table.Text = "Show Table";
            btn_table.UseVisualStyleBackColor = true;
            btn_table.Click += table_btn6_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.AutoSize = true;
            panel1.BackColor = Color.Azure;
            panel1.Controls.Add(btn_receive);
            panel1.Controls.Add(btn_exit);
            panel1.Controls.Add(btn_distribute);
            panel1.Controls.Add(btn_edit);
            panel1.Controls.Add(btn_add);
            panel1.Controls.Add(btn_table);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(341, 689);
            panel1.TabIndex = 9;
            // 
            // btn_receive
            // 
            btn_receive.FlatAppearance.BorderSize = 0;
            btn_receive.FlatStyle = FlatStyle.Flat;
            btn_receive.Image = (Image)resources.GetObject("btn_receive.Image");
            btn_receive.ImageAlign = ContentAlignment.MiddleLeft;
            btn_receive.Location = new Point(12, 158);
            btn_receive.Name = "btn_receive";
            btn_receive.Size = new Size(322, 58);
            btn_receive.TabIndex = 6;
            btn_receive.Text = "Receive";
            btn_receive.UseVisualStyleBackColor = true;
            btn_receive.Click += btn_receive_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1287, 689);
            Controls.Add(panel1);
            Font = new Font("Nunito", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            TransparencyKey = Color.Cyan;
            WindowState = FormWindowState.Maximized;
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_distribute;
        private Button btn_add;
        private Button btn_edit;
        private Label label1;
        private Button btn_table;
        private Button btn_exit;
        private Panel panel1;
        private Button btn_receive;
    }
}