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
            // ConfigForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1000, 472);
            Controls.Add(create_tables_btn_config);
            Controls.Add(cont_btn_select);
            Font = new Font("Google Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "ConfigForm";
            Text = "Configuration";
            ResumeLayout(false);
        }

        #endregion

        private Button cont_btn_select;
        private Button create_tables_btn_config;
    }
}