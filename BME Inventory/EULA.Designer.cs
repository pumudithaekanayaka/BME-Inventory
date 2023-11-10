namespace BME_Inventory
{
    partial class EULA
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
            accept_check_eula = new CheckBox();
            decline_check_eula = new CheckBox();
            next_btn_eula = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // accept_check_eula
            // 
            accept_check_eula.AutoSize = true;
            accept_check_eula.Location = new Point(108, 215);
            accept_check_eula.Name = "accept_check_eula";
            accept_check_eula.Size = new Size(77, 24);
            accept_check_eula.TabIndex = 0;
            accept_check_eula.Text = "Accept";
            accept_check_eula.UseVisualStyleBackColor = true;
            accept_check_eula.CheckedChanged += accept_check_eula_CheckedChanged;
            // 
            // decline_check_eula
            // 
            decline_check_eula.AutoSize = true;
            decline_check_eula.Location = new Point(106, 255);
            decline_check_eula.Name = "decline_check_eula";
            decline_check_eula.Size = new Size(78, 24);
            decline_check_eula.TabIndex = 1;
            decline_check_eula.Text = "Decline";
            decline_check_eula.UseVisualStyleBackColor = true;
            // 
            // next_btn_eula
            // 
            next_btn_eula.Location = new Point(464, 322);
            next_btn_eula.Name = "next_btn_eula";
            next_btn_eula.Size = new Size(101, 43);
            next_btn_eula.TabIndex = 2;
            next_btn_eula.Text = "Next";
            next_btn_eula.UseVisualStyleBackColor = true;
            next_btn_eula.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(585, 322);
            button2.Name = "button2";
            button2.Size = new Size(101, 43);
            button2.TabIndex = 3;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            // 
            // EULA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(next_btn_eula);
            Controls.Add(decline_check_eula);
            Controls.Add(accept_check_eula);
            Name = "EULA";
            Text = "EULA";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox accept_check_eula;
        private CheckBox decline_check_eula;
        private Button next_btn_eula;
        private Button button2;
    }
}