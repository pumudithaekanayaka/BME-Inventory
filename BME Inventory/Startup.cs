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
    public partial class Startup : Form
    {

        private DatabaseManager dbManager;
        public Startup(DatabaseManager dbManager)
        {
            InitializeComponent();
            this.dbManager = dbManager;
        }

        private void go_btn_start_Click(object sender, EventArgs e)
        {
            EULA eula = new EULA(dbManager);
            eula.Show();
            this.Hide();
        }
    }
}
