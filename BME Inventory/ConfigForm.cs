using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BME_Inventory
{
    public partial class ConfigForm : Form
    {
        public string ServerName { get; private set; }
        public string DatabaseName { get; private set; }

        public ConfigForm()
        {
            InitializeComponent();
        }

        private void saveConfigButton_Click(object sender, EventArgs e)
        {
            ServerName = server_txt.Text;
            DatabaseName = database_txt.Text;

            // You can save the configuration to a file, registry, or any other storage mechanism.

            DialogResult = DialogResult.OK;
            Close();
        }
    }

}
