namespace BME_Inventory
{
    partial class Startup
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
            go_btn_start = new Button();
            SuspendLayout();
            // 
            // go_btn_start
            // 
            go_btn_start.Location = new Point(396, 199);
            go_btn_start.Name = "go_btn_start";
            go_btn_start.Size = new Size(114, 70);
            go_btn_start.TabIndex = 0;
            go_btn_start.Text = "Go";
            go_btn_start.UseVisualStyleBackColor = true;
            go_btn_start.Click += go_btn_start_Click;
            // 
            // Startup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(go_btn_start);
            Name = "Startup";
            Text = "Startup";
            ResumeLayout(false);
        }

        #endregion

        private Button go_btn_start;
    }
}