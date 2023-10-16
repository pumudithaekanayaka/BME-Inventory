namespace BME_Inventory
{
    partial class View
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
            load_btn = new Button();
            back_btn = new Button();
            SuspendLayout();
            // 
            // load_btn
            // 
            load_btn.Location = new Point(588, 111);
            load_btn.Name = "load_btn";
            load_btn.Size = new Size(110, 46);
            load_btn.TabIndex = 1;
            load_btn.Text = "Load";
            load_btn.UseVisualStyleBackColor = true;
            load_btn.Click += load_btn_Click;
            // 
            // back_btn
            // 
            back_btn.Location = new Point(585, 168);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(115, 42);
            back_btn.TabIndex = 2;
            back_btn.Text = "Back";
            back_btn.UseVisualStyleBackColor = true;
            back_btn.Click += back_btn_Click;
            // 
            // View
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 450);
            Controls.Add(back_btn);
            Controls.Add(load_btn);
            Name = "View";
            Text = "View Data";
            Load += View_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button load_btn;
        private Button back_btn;
    }
}