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
            server_txt = new TextBox();
            database_txt = new TextBox();
            SuspendLayout();
            // 
            // server_txt
            // 
            server_txt.Location = new Point(149, 68);
            server_txt.Name = "server_txt";
            server_txt.Size = new Size(432, 27);
            server_txt.TabIndex = 0;
            // 
            // database_txt
            // 
            database_txt.Location = new Point(149, 140);
            database_txt.Name = "database_txt";
            database_txt.Size = new Size(432, 27);
            database_txt.TabIndex = 1;
            // 
            // ConfigForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(database_txt);
            Controls.Add(server_txt);
            Name = "ConfigForm";
            Text = "ConfigForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox server_txt;
        private TextBox database_txt;
    }
}