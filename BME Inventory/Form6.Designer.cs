namespace BME_Inventory
{
    partial class Home
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
            distribute_btn = new Button();
            add_btn = new Button();
            edit_btn = new Button();
            SuspendLayout();
            // 
            // distribute_btn
            // 
            distribute_btn.Location = new Point(72, 94);
            distribute_btn.Name = "distribute_btn";
            distribute_btn.Size = new Size(152, 58);
            distribute_btn.TabIndex = 0;
            distribute_btn.Text = "Distribute";
            distribute_btn.UseVisualStyleBackColor = true;
            distribute_btn.Click += button1_Click;
            // 
            // add_btn
            // 
            add_btn.Location = new Point(290, 94);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(152, 58);
            add_btn.TabIndex = 1;
            add_btn.Text = "Add New";
            add_btn.UseVisualStyleBackColor = true;
            add_btn.Click += button2_Click;
            // 
            // edit_btn
            // 
            edit_btn.Location = new Point(499, 94);
            edit_btn.Name = "edit_btn";
            edit_btn.Size = new Size(152, 58);
            edit_btn.TabIndex = 2;
            edit_btn.Text = "Edit Entries";
            edit_btn.UseVisualStyleBackColor = true;
            edit_btn.Click += button3_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(edit_btn);
            Controls.Add(add_btn);
            Controls.Add(distribute_btn);
            Name = "Home";
            Text = "Home";
            ResumeLayout(false);
        }

        #endregion

        private Button distribute_btn;
        private Button add_btn;
        private Button edit_btn;
    }
}