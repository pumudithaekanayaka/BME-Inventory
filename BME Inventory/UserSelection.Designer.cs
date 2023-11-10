namespace BME_Inventory
{
    partial class UserSelection
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
            cont_btn_select = new Button();
            SuspendLayout();
            // 
            // cont_btn_select
            // 
            cont_btn_select.Location = new Point(388, 72);
            cont_btn_select.Name = "cont_btn_select";
            cont_btn_select.Size = new Size(186, 40);
            cont_btn_select.TabIndex = 0;
            cont_btn_select.Text = "Continue";
            cont_btn_select.UseVisualStyleBackColor = true;
            cont_btn_select.Click += cont_btn_select_Click;
            // 
            // UserSelection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cont_btn_select);
            Name = "UserSelection";
            Text = "UserSelection";
            ResumeLayout(false);
        }

        #endregion

        private Button cont_btn_select;
    }
}