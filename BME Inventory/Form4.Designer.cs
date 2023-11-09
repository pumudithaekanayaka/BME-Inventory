namespace BME_Inventory
{
    partial class Table
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Table));
            export_btn = new Button();
            exit_btn4 = new Button();
            export_all_btn4 = new Button();
            home_btn4 = new Button();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            btn_dev6 = new Button();
            btn_receive = new Button();
            btn_exit = new Button();
            btn_distribute = new Button();
            btn_edit = new Button();
            btn_add = new Button();
            btn_table = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // export_btn
            // 
            export_btn.Location = new Point(673, 355);
            export_btn.Name = "export_btn";
            export_btn.Size = new Size(93, 38);
            export_btn.TabIndex = 2;
            export_btn.Text = "Export";
            export_btn.UseVisualStyleBackColor = true;
            export_btn.Click += mail_btn_Click;
            // 
            // exit_btn4
            // 
            exit_btn4.Location = new Point(871, 355);
            exit_btn4.Name = "exit_btn4";
            exit_btn4.Size = new Size(93, 38);
            exit_btn4.TabIndex = 3;
            exit_btn4.Text = "Exit";
            exit_btn4.UseVisualStyleBackColor = true;
            exit_btn4.Click += exit_btn4_Click;
            // 
            // export_all_btn4
            // 
            export_all_btn4.Location = new Point(574, 355);
            export_all_btn4.Name = "export_all_btn4";
            export_all_btn4.Size = new Size(93, 38);
            export_all_btn4.TabIndex = 4;
            export_all_btn4.Text = "Export All";
            export_all_btn4.UseVisualStyleBackColor = true;
            export_all_btn4.Click += export_all_btn4_Click;
            // 
            // home_btn4
            // 
            home_btn4.Location = new Point(772, 355);
            home_btn4.Name = "home_btn4";
            home_btn4.Size = new Size(93, 38);
            home_btn4.TabIndex = 5;
            home_btn4.Text = "Home";
            home_btn4.UseVisualStyleBackColor = true;
            home_btn4.Click += home_btn4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(345, 12);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(897, 284);
            dataGridView1.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.AutoSize = true;
            panel1.BackColor = Color.Azure;
            panel1.Controls.Add(btn_dev6);
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
            panel1.Size = new Size(341, 723);
            panel1.TabIndex = 10;
            // 
            // btn_dev6
            // 
            btn_dev6.FlatAppearance.BorderSize = 0;
            btn_dev6.FlatStyle = FlatStyle.Flat;
            btn_dev6.Image = (Image)resources.GetObject("btn_dev6.Image");
            btn_dev6.ImageAlign = ContentAlignment.MiddleLeft;
            btn_dev6.Location = new Point(15, 414);
            btn_dev6.Name = "btn_dev6";
            btn_dev6.Size = new Size(319, 58);
            btn_dev6.TabIndex = 7;
            btn_dev6.Text = "Developer Mode";
            btn_dev6.UseVisualStyleBackColor = true;
            // 
            // btn_receive
            // 
            btn_receive.FlatAppearance.BorderSize = 0;
            btn_receive.FlatStyle = FlatStyle.Flat;
            btn_receive.Image = (Image)resources.GetObject("btn_receive.Image");
            btn_receive.ImageAlign = ContentAlignment.MiddleLeft;
            btn_receive.Location = new Point(16, 222);
            btn_receive.Name = "btn_receive";
            btn_receive.Size = new Size(322, 58);
            btn_receive.TabIndex = 6;
            btn_receive.Text = "Receive";
            btn_receive.UseVisualStyleBackColor = true;
            // 
            // btn_exit
            // 
            btn_exit.FlatAppearance.BorderSize = 0;
            btn_exit.FlatStyle = FlatStyle.Flat;
            btn_exit.Image = (Image)resources.GetObject("btn_exit.Image");
            btn_exit.ImageAlign = ContentAlignment.MiddleLeft;
            btn_exit.Location = new Point(12, 619);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(319, 58);
            btn_exit.TabIndex = 5;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = true;
            // 
            // btn_distribute
            // 
            btn_distribute.FlatAppearance.BorderSize = 0;
            btn_distribute.FlatStyle = FlatStyle.Flat;
            btn_distribute.Image = (Image)resources.GetObject("btn_distribute.Image");
            btn_distribute.ImageAlign = ContentAlignment.MiddleLeft;
            btn_distribute.Location = new Point(12, 157);
            btn_distribute.Name = "btn_distribute";
            btn_distribute.Size = new Size(322, 58);
            btn_distribute.TabIndex = 0;
            btn_distribute.Text = "Distribute";
            btn_distribute.UseVisualStyleBackColor = true;
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
            // 
            // btn_add
            // 
            btn_add.FlatAppearance.BorderSize = 0;
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.Image = (Image)resources.GetObject("btn_add.Image");
            btn_add.ImageAlign = ContentAlignment.MiddleLeft;
            btn_add.Location = new Point(16, 350);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(319, 58);
            btn_add.TabIndex = 1;
            btn_add.Text = "Add New";
            btn_add.UseVisualStyleBackColor = true;
            // 
            // btn_table
            // 
            btn_table.FlatAppearance.BorderSize = 0;
            btn_table.FlatStyle = FlatStyle.Flat;
            btn_table.Image = (Image)resources.GetObject("btn_table.Image");
            btn_table.ImageAlign = ContentAlignment.MiddleLeft;
            btn_table.Location = new Point(12, 104);
            btn_table.Name = "btn_table";
            btn_table.Size = new Size(319, 58);
            btn_table.TabIndex = 3;
            btn_table.Text = "Show Table";
            btn_table.UseVisualStyleBackColor = true;
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
            // Table
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1254, 723);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(home_btn4);
            Controls.Add(export_all_btn4);
            Controls.Add(exit_btn4);
            Controls.Add(export_btn);
            Font = new Font("Candara", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Table";
            Text = "Table";
            WindowState = FormWindowState.Maximized;
            Load += Table_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button export_btn;
        private Button exit_btn4;
        private Button export_all_btn4;
        private Button home_btn4;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Button btn_dev6;
        private Button btn_receive;
        private Button btn_exit;
        private Button btn_distribute;
        private Button btn_edit;
        private Button btn_add;
        private Button btn_table;
        private Label label1;
    }
}