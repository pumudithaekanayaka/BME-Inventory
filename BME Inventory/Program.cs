namespace BME_Inventory
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string serverName = Properties.Settings.Default.ServerName;
            string databaseName = Properties.Settings.Default.DatabaseName;
            bool isFirstRun = Properties.Settings.Default.IsFirstRun;

            if (isFirstRun)
            {
                string connectionString = GetConnectionString(serverName, databaseName);
                DatabaseManager dbManager = new DatabaseManager(connectionString);
                Application.Run(new Startup(dbManager));
            }
            else
            {
                string connectionString = GetConnectionString(serverName, databaseName);
                DatabaseManager dbManager = new DatabaseManager(connectionString);
                Application.Run(new UserSelection(dbManager));
            }
        }

        private static string GetConnectionString(string serverName, string databaseName)
        {
            return $"Data Source={serverName};Initial Catalog={databaseName};Integrated Security=True";
        }
    }
}
