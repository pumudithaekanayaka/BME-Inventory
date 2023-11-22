namespace BME_Inventory
{
    partial class ConfigForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm));
            cont_btn_select = new Button();
            create_tables_btn_config = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // cont_btn_select
            // 
            cont_btn_select.Location = new Point(738, 397);
            cont_btn_select.Margin = new Padding(4, 3, 4, 3);
            cont_btn_select.Name = "cont_btn_select";
            cont_btn_select.Size = new Size(232, 42);
            cont_btn_select.TabIndex = 0;
            cont_btn_select.Text = "Continue";
            cont_btn_select.UseVisualStyleBackColor = true;
            cont_btn_select.Click += cont_btn_select_Click;
            // 
            // create_tables_btn_config
            // 
            create_tables_btn_config.Location = new Point(484, 397);
            create_tables_btn_config.Margin = new Padding(4, 3, 4, 3);
            create_tables_btn_config.Name = "create_tables_btn_config";
            create_tables_btn_config.Size = new Size(232, 42);
            create_tables_btn_config.TabIndex = 1;
            create_tables_btn_config.Text = "Create";
            create_tables_btn_config.UseVisualStyleBackColor = true;
            create_tables_btn_config.Click += create_tables_btn_config_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Google Sans", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(47, 64);
            label1.Name = "label1";
            label1.Size = new Size(854, 35);
            label1.TabIndex = 2;
            label1.Text = "Click Create Button to Create All of The Tables and Folders Needed ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Google Sans", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(47, 99);
            label2.Name = "label2";
            label2.Size = new Size(782, 35);
            label2.TabIndex = 3;
            label2.Text = "If the Tables and Folders Already Created Then Click Continue";
            // 
            // ConfigForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(1000, 472);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(create_tables_btn_config);
            Controls.Add(cont_btn_select);
            Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "ConfigForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Configuration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cont_btn_select;
        private Button create_tables_btn_config;
        private Label label1;
        private Label label2;
    }
}