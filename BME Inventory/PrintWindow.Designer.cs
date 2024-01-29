namespace BME_Inventory
{
    partial class PrintWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintWindow));
            printDialog1 = new PrintDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            dataGridView1 = new DataGridView();
            pageSetupDialog1 = new PageSetupDialog();
            printPreviewDialog1 = new PrintPreviewDialog();
            data_load_btn = new MaterialSkin.Controls.MaterialButton();
            print_data_btn = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(32, 36);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(271, 461);
            dataGridView1.TabIndex = 1;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // data_load_btn
            // 
            data_load_btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            data_load_btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            data_load_btn.Depth = 0;
            data_load_btn.HighEmphasis = true;
            data_load_btn.Icon = null;
            data_load_btn.Location = new Point(32, 518);
            data_load_btn.Margin = new Padding(4, 6, 4, 6);
            data_load_btn.MouseState = MaterialSkin.MouseState.HOVER;
            data_load_btn.Name = "data_load_btn";
            data_load_btn.NoAccentTextColor = Color.Empty;
            data_load_btn.Size = new Size(100, 36);
            data_load_btn.TabIndex = 2;
            data_load_btn.Text = "Load Data";
            data_load_btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            data_load_btn.UseAccentColor = false;
            data_load_btn.UseVisualStyleBackColor = true;
            data_load_btn.Click += data_load_btn_Click;
            // 
            // print_data_btn
            // 
            print_data_btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            print_data_btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            print_data_btn.Depth = 0;
            print_data_btn.HighEmphasis = true;
            print_data_btn.Icon = null;
            print_data_btn.Location = new Point(158, 518);
            print_data_btn.Margin = new Padding(4, 6, 4, 6);
            print_data_btn.MouseState = MaterialSkin.MouseState.HOVER;
            print_data_btn.Name = "print_data_btn";
            print_data_btn.NoAccentTextColor = Color.Empty;
            print_data_btn.Size = new Size(105, 36);
            print_data_btn.TabIndex = 3;
            print_data_btn.Text = "Print Data";
            print_data_btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            print_data_btn.UseAccentColor = false;
            print_data_btn.UseVisualStyleBackColor = true;
            // 
            // PrintWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1313, 649);
            Controls.Add(print_data_btn);
            Controls.Add(data_load_btn);
            Controls.Add(dataGridView1);
            Name = "PrintWindow";
            Text = "PrintWindow";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private DataGridView dataGridView1;
        private PageSetupDialog pageSetupDialog1;
        private PrintPreviewDialog printPreviewDialog1;
        private MaterialSkin.Controls.MaterialButton data_load_btn;
        private MaterialSkin.Controls.MaterialButton print_data_btn;
    }
}