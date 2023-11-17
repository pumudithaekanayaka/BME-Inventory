using System;
using System.Windows.Forms;

namespace BME_Inventory
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            string serverName = Properties.Settings.Default.ServerName;
            string databaseName = Properties.Settings.Default.DatabaseName;

            bool isFirstRun = Properties.Settings.Default.IsFirstRun;

            if (isFirstRun)
            {
                DatabaseManager dbManager = new DatabaseManager();

                ShowDatabaseConnectionForm(dbManager);

                Properties.Settings.Default["IsFirstRun"] = false;
                Properties.Settings.Default.Save();
            }
            else
            {
                DatabaseManager dbManager = new DatabaseManager();

                Application.Run(new Login(dbManager));
            }
        }

        private static void ShowDatabaseConnectionForm(DatabaseManager dbManager)
        {
            using (DatabaseConnection databaseConnection = new DatabaseConnection(dbManager, true))
            {
                if (databaseConnection.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.ServerName = databaseConnection.ServerName;
                    Properties.Settings.Default.DatabaseName = databaseConnection.DatabaseName;
                    Properties.Settings.Default["IsFirstRun"] = false;
                    Properties.Settings.Default.Save();

                    Application.Run(new ConfigForm(new DatabaseManager(databaseConnection.ConnectionString)));
                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
}
