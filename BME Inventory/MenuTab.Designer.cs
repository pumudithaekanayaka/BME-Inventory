namespace BME_Inventory
{
    partial class MenuTab
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
            materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            materialTextBox21 = new MaterialSkin.Controls.MaterialTextBox2();
            materialTextBox22 = new MaterialSkin.Controls.MaterialTextBox2();
            materialTextBox23 = new MaterialSkin.Controls.MaterialTextBox2();
            materialTabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(tabPage1);
            materialTabControl1.Controls.Add(tabPage2);
            materialTabControl1.Depth = 0;
            materialTabControl1.Location = new Point(0, 2);
            materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(1192, 490);
            materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(materialButton1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1184, 457);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Userdata";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(materialTextBox23);
            tabPage2.Controls.Add(materialTextBox22);
            tabPage2.Controls.Add(materialTextBox21);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1184, 457);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "AppData";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(430, 87);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(158, 36);
            materialButton1.TabIndex = 0;
            materialButton1.Text = "materialButton1";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            // 
            // materialTextBox21
            // 
            materialTextBox21.AnimateReadOnly = false;
            materialTextBox21.BackgroundImageLayout = ImageLayout.None;
            materialTextBox21.CharacterCasing = CharacterCasing.Normal;
            materialTextBox21.Depth = 0;
            materialTextBox21.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            materialTextBox21.HideSelection = true;
            materialTextBox21.LeadingIcon = null;
            materialTextBox21.LeaveOnEnterKey = true;
            materialTextBox21.Location = new Point(411, 55);
            materialTextBox21.MaxLength = 32767;
            materialTextBox21.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox21.Name = "materialTextBox21";
            materialTextBox21.PasswordChar = '\0';
            materialTextBox21.PrefixSuffixText = null;
            materialTextBox21.ReadOnly = false;
            materialTextBox21.RightToLeft = RightToLeft.No;
            materialTextBox21.SelectedText = "";
            materialTextBox21.SelectionLength = 0;
            materialTextBox21.SelectionStart = 0;
            materialTextBox21.ShortcutsEnabled = true;
            materialTextBox21.Size = new Size(494, 48);
            materialTextBox21.TabIndex = 0;
            materialTextBox21.TabStop = false;
            materialTextBox21.TextAlign = HorizontalAlignment.Left;
            materialTextBox21.TrailingIcon = null;
            materialTextBox21.UseSystemPasswordChar = false;
            // 
            // materialTextBox22
            // 
            materialTextBox22.AnimateReadOnly = false;
            materialTextBox22.BackgroundImageLayout = ImageLayout.None;
            materialTextBox22.CharacterCasing = CharacterCasing.Normal;
            materialTextBox22.Depth = 0;
            materialTextBox22.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            materialTextBox22.HideSelection = true;
            materialTextBox22.LeadingIcon = null;
            materialTextBox22.Location = new Point(411, 137);
            materialTextBox22.MaxLength = 32767;
            materialTextBox22.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox22.Name = "materialTextBox22";
            materialTextBox22.PasswordChar = '\0';
            materialTextBox22.PrefixSuffixText = null;
            materialTextBox22.ReadOnly = false;
            materialTextBox22.RightToLeft = RightToLeft.No;
            materialTextBox22.SelectedText = "";
            materialTextBox22.SelectionLength = 0;
            materialTextBox22.SelectionStart = 0;
            materialTextBox22.ShortcutsEnabled = true;
            materialTextBox22.Size = new Size(494, 48);
            materialTextBox22.TabIndex = 1;
            materialTextBox22.TabStop = false;
            materialTextBox22.TextAlign = HorizontalAlignment.Left;
            materialTextBox22.TrailingIcon = null;
            materialTextBox22.UseSystemPasswordChar = false;
            // 
            // materialTextBox23
            // 
            materialTextBox23.AnimateReadOnly = false;
            materialTextBox23.BackgroundImageLayout = ImageLayout.None;
            materialTextBox23.CharacterCasing = CharacterCasing.Normal;
            materialTextBox23.Depth = 0;
            materialTextBox23.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            materialTextBox23.HideSelection = true;
            materialTextBox23.LeadingIcon = null;
            materialTextBox23.Location = new Point(411, 206);
            materialTextBox23.MaxLength = 32767;
            materialTextBox23.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox23.Name = "materialTextBox23";
            materialTextBox23.PasswordChar = '\0';
            materialTextBox23.PrefixSuffixText = null;
            materialTextBox23.ReadOnly = false;
            materialTextBox23.RightToLeft = RightToLeft.No;
            materialTextBox23.SelectedText = "";
            materialTextBox23.SelectionLength = 0;
            materialTextBox23.SelectionStart = 0;
            materialTextBox23.ShortcutsEnabled = true;
            materialTextBox23.Size = new Size(494, 48);
            materialTextBox23.TabIndex = 2;
            materialTextBox23.TabStop = false;
            materialTextBox23.TextAlign = HorizontalAlignment.Left;
            materialTextBox23.TrailingIcon = null;
            materialTextBox23.UseSystemPasswordChar = false;
            // 
            // MenuTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1188, 486);
            Controls.Add(materialTabControl1);
            Name = "MenuTab";
            Text = "MenuTab";
            materialTabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox23;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox22;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox21;
    }
}