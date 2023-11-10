using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BME_Inventory
{
    public partial class EULA : Form
    {
        private DatabaseManager dbManager;

        public EULA(DatabaseManager databaseManager)
        {
            InitializeComponent();
            dbManager = databaseManager;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserSelection userSelection = new UserSelection(dbManager);
            userSelection.Show();
            this.Hide();
        }

        private void accept_check_eula_CheckedChanged(object sender, EventArgs e)
        {
            if(accept_check_eula.Checked)
            {
                next_btn_eula.Enabled = true;
            }
            else
            {
                next_btn_eula.Enabled = false;
            }
        }
    }
}
