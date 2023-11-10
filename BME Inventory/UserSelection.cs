using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BME_Inventory
{
    public partial class UserSelection : Form
    {
        private DatabaseManager dbManager;

        public UserSelection(DatabaseManager databaseManager)
        {
            InitializeComponent();
            dbManager = databaseManager;
        }

        private void cont_btn_select_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login(dbManager);
            login.Show();
        }
    }
}

