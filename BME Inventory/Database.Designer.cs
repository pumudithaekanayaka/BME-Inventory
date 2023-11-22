namespace BME_Inventory
{
    partial class Database
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Database));
            export_btn = new Button();
            export_all_btn4 = new Button();
            dataGridView1 = new DataGridView();
            search_txt_database = new TextBox();
            search_btn_database = new Button();
            attention_btn_database = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            refresh_btn_database = new Button();
            panel1 = new Panel();
            print_btn_database = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // export_btn
            // 
            export_btn.BackColor = Color.CornflowerBlue;
            export_btn.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            export_btn.Location = new Point(457, 454);
            export_btn.Name = "export_btn";
            export_btn.Size = new Size(94, 29);
            export_btn.TabIndex = 2;
            export_btn.Text = "Export";
            export_btn.UseVisualStyleBackColor = false;
            export_btn.Click += mail_btn_Click;
            // 
            // export_all_btn4
            // 
            export_all_btn4.BackColor = Color.CornflowerBlue;
            export_all_btn4.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            export_all_btn4.Location = new Point(457, 508);
            export_all_btn4.Name = "export_all_btn4";
            export_all_btn4.Size = new Size(94, 29);
            export_all_btn4.TabIndex = 4;
            export_all_btn4.Text = "Export All";
            export_all_btn4.UseVisualStyleBackColor = false;
            export_all_btn4.Click += export_all_btn4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 88);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(754, 284);
            dataGridView1.TabIndex = 6;
            // 
            // search_txt_database
            // 
            search_txt_database.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            search_txt_database.Location = new Point(35, 30);
            search_txt_database.Name = "search_txt_database";
            search_txt_database.Size = new Size(450, 29);
            search_txt_database.TabIndex = 54;
            // 
            // search_btn_database
            // 
            search_btn_database.BackColor = Color.CornflowerBlue;
            search_btn_database.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            search_btn_database.Location = new Point(505, 30);
            search_btn_database.Name = "search_btn_database";
            search_btn_database.Size = new Size(110, 30);
            search_btn_database.TabIndex = 55;
            search_btn_database.Text = "Search";
            search_btn_database.UseVisualStyleBackColor = false;
            search_btn_database.Click += search_btn_database_Click;
            // 
            // attention_btn_database
            // 
            attention_btn_database.BackColor = Color.CornflowerBlue;
            attention_btn_database.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            attention_btn_database.Location = new Point(457, 403);
            attention_btn_database.Name = "attention_btn_database";
            attention_btn_database.Size = new Size(94, 29);
            attention_btn_database.TabIndex = 19;
            attention_btn_database.Text = "Load";
            attention_btn_database.UseVisualStyleBackColor = false;
            attention_btn_database.Click += attention_btn_database_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(35, 411);
            label2.Name = "label2";
            label2.Size = new Size(248, 21);
            label2.TabIndex = 58;
            label2.Text = "Load The Items Need Attention";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(35, 462);
            label3.Name = "label3";
            label3.Size = new Size(398, 21);
            label3.TabIndex = 59;
            label3.Text = "Export The Items Need Attention To An Excel Sheet";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(35, 516);
            label4.Name = "label4";
            label4.Size = new Size(319, 21);
            label4.TabIndex = 60;
            label4.Text = "Export All of The Items To An Excel Sheet";
            // 
            // refresh_btn_database
            // 
            refresh_btn_database.BackColor = Color.CornflowerBlue;
            refresh_btn_database.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            refresh_btn_database.Location = new Point(35, 558);
            refresh_btn_database.Name = "refresh_btn_database";
            refresh_btn_database.Size = new Size(94, 29);
            refresh_btn_database.TabIndex = 61;
            refresh_btn_database.Text = "Refresh";
            refresh_btn_database.UseVisualStyleBackColor = false;
            refresh_btn_database.Click += refresh_btn_database_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(print_btn_database);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(refresh_btn_database);
            panel1.Controls.Add(export_btn);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(export_all_btn4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(search_txt_database);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(search_btn_database);
            panel1.Controls.Add(attention_btn_database);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1004, 609);
            panel1.TabIndex = 62;
            // 
            // print_btn_database
            // 
            print_btn_database.BackColor = Color.CornflowerBlue;
            print_btn_database.Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            print_btn_database.Location = new Point(457, 558);
            print_btn_database.Name = "print_btn_database";
            print_btn_database.Size = new Size(94, 29);
            print_btn_database.TabIndex = 62;
            print_btn_database.Text = "Print";
            print_btn_database.UseVisualStyleBackColor = false;
            print_btn_database.Visible = false;
            print_btn_database.Click += print_btn_database_Click;
            // 
            // Database
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(1004, 723);
            Controls.Add(panel1);
            Font = new Font("Candara", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Database";
            Text = "Database";
            WindowState = FormWindowState.Maximized;
            Load += Table_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button export_btn;
        private Button export_all_btn4;
        private DataGridView dataGridView1;
        private TextBox search_txt_database;
        private Button search_btn_database;
        private Button attention_btn_database;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button refresh_btn_database;
        private Panel panel1;
        private Button print_btn_database;
    }
}