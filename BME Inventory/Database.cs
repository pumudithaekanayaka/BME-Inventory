using OfficeOpenXml;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;

namespace BME_Inventory
{
    public partial class Database : Form
    {
        private DatabaseManager dbManager;
        private SqlConnection connection;

        public Database(DatabaseManager databaseManager)
        {
            InitializeComponent();
            dbManager = databaseManager;
            connection = dbManager.GetConnection();
            UpdateUIBasedOnUserRole();
        }

        private void UpdateUIBasedOnUserRole()
        {
            string currentUserRole = UserRoles.CurrentUserRole;

            if (currentUserRole == "user")
            {
                btn_receive_database.Enabled = false;
                btn_receive_database.Visible = false;
                btn_edit_database.Enabled = false;
                btn_edit_database.Visible = false;
                btn_add_database.Enabled = false;
                btn_add_database.Visible = false;
                btn_home_database.Enabled = true;
                btn_dev_database.Enabled = false;
                btn_dev_database.Visible = false;
            }
            else if (currentUserRole == "admin")
            {
                btn_home_database.Enabled = true;
                btn_dev_database.Enabled = false;
                btn_dev_database.Visible = false;
                btn_edit_database.Enabled = true;
                btn_add_database.Enabled = true;
            }
            else if (currentUserRole == "maintenance")
            {
                btn_home_database.Enabled = true;
                btn_dev_database.Enabled = true;
                btn_edit_database.Enabled = true;
                btn_add_database.Enabled = true;
            }
        }

        private void LoadDataIntoGrid(string query, DataTable table)
        {
            try
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(query, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(table);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            if (table.Rows.Count > 0)
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                foreach (DataColumn column in table.Columns)
                {
                    dataGridView1.Columns.Add(column.ColumnName, column.ColumnName);
                }

                foreach (DataRow row in table.Rows)
                {
                    dataGridView1.Rows.Add(row.ItemArray);
                }

                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            else
            {
                MessageBox.Show("Record not found!");
            }
        }

        private void LoadDataForStockCheck()
        {
            string query = "SELECT * FROM inventory WHERE stock < lower";
            DataTable table = new DataTable();
            LoadDataIntoGrid(query, table);
        }

        private void LoadDataAll()
        {
            string query = "SELECT * FROM inventory";
            DataTable table = new DataTable();
            LoadDataIntoGrid(query, table);
        }

        private void mail_btn_Click(object sender, EventArgs e)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            string query = "SELECT * FROM inventory WHERE stock < lower";
            DataTable table = new DataTable();
            LoadDataIntoGrid(query, table);

            if (table.Rows.Count > 0)
            {
                string filePath = "C:\\Inventory Logs\\SparePartsData.xlsx";

                using (var package = new ExcelPackage(new FileInfo(filePath)))
                {
                    string worksheetName = "Spare Parts Data";
                    int worksheetNumber = 1;

                    while (package.Workbook.Worksheets.Any(ws => ws.Name == worksheetName))
                    {
                        worksheetName = "Spare Parts Data " + worksheetNumber;
                        worksheetNumber++;
                    }

                    var worksheet = package.Workbook.Worksheets.Add(worksheetName);

                    for (int i = 1; i <= table.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i].Value = table.Columns[i - 1].ColumnName;
                    }

                    for (int row = 0; row < table.Rows.Count; row++)
                    {
                        for (int col = 0; col < table.Columns.Count; col++)
                        {
                            worksheet.Cells[row + 2, col + 1].Value = table.Rows[row][col];
                        }
                    }

                    package.Save();
                }

                Process.Start(new ProcessStartInfo
                {
                    FileName = filePath,
                    UseShellExecute = true,
                    Verb = "open"
                });
            }
            else
            {
                MessageBox.Show("No records found with stock lower than 'lower'.");
            }
        }

        private void Table_Load(object sender, EventArgs e)
        {
            string query = "SELECT part_id, part_name, equip_name, upper, lower, stock, description, make, model FROM inventory";
            LoadDataIntoGrid(query, new DataTable());

            string username = CurrentUser.Username;

            if (username != null)
            {
                user_lbl_database.Text = $"{username}";
            }
            else
            {
                user_lbl_database.Text = $"Unable to retrieve username.";
            }
        }

        private void export_all_btn4_Click(object sender, EventArgs e)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            string query = "SELECT * FROM inventory";
            DataTable table = new DataTable();
            LoadDataIntoGrid(query, table);

            if (table.Rows.Count > 0)
            {
                string filePath = "C:\\Inventory Logs\\SparePartsAllData.xlsx";

                using (var package = new ExcelPackage(new FileInfo(filePath)))
                {
                    string worksheetName = "Spare Parts Data";

                    worksheetName = "All Parts Data";

                    var worksheet = package.Workbook.Worksheets.Add(worksheetName);

                    for (int i = 1; i <= table.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i].Value = table.Columns[i - 1].ColumnName;
                    }

                    for (int row = 0; row < table.Rows.Count; row++)
                    {
                        for (int col = 0; col < table.Columns.Count; col++)
                        {
                            worksheet.Cells[row + 2, col + 1].Value = table.Rows[row][col];
                        }
                    }

                    package.Save();
                }

                Process.Start(new ProcessStartInfo
                {
                    FileName = filePath,
                    UseShellExecute = true,
                    Verb = "open"
                });
            }
            else
            {
                MessageBox.Show("No records found.");
            }


        }

        private void search_btn_database_Click(object sender, EventArgs e)
        {
            string searchtext = search_txt_database.Text;
            dbManager.OpenConnection();

            string query = "SELECT * FROM inventory WHERE ";
            bool firstColumn = true;

            string[] columnsToSearch = { "part_id", "part_name", "equip_name", "upper", "lower", "stock", "description", "make", "model" };

            foreach (string columnName in columnsToSearch)
            {
                if (!firstColumn)
                {
                    query += " OR ";
                }

                query += columnName + " LIKE '%' + @searchText + '%'";
                firstColumn = false;
            }

            using (SqlCommand cmd = new SqlCommand(query, dbManager.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@searchText", searchtext);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    dataGridView1.Rows.Clear();

                    while (reader.Read())
                    {
                        object[] rowValues = new object[reader.FieldCount];
                        reader.GetValues(rowValues);
                        dataGridView1.Rows.Add(rowValues);
                    }
                }
            }

            dbManager.CloseConnection();


        }

        private void btn_distribute_database_Click(object sender, EventArgs e)
        {
            Distribute distribute = new Distribute(dbManager);
            distribute.Show();
            this.Close();

        }

        private void btn_receive_database_Click(object sender, EventArgs e)
        {
            Recieve recieve = new Recieve(dbManager);
            recieve.Show();
            this.Close();
        }

        private void btn_add_database_Click(object sender, EventArgs e)
        {
            Create create = new Create(dbManager);
            create.Show();
            this.Close();
        }

        private void btn_adduser_database_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser(dbManager);
            addUser.Show();
            this.Close();
        }

        private void btn_edit_database_Click(object sender, EventArgs e)
        {
            Edit edit = new Edit(dbManager);
            edit.Show();
            this.Close();
        }

        private void btn_dev_database_Click(object sender, EventArgs e)
        {
            DeveloperDashboard developerDashboard = new DeveloperDashboard(dbManager);
            developerDashboard.Show();
            this.Close();
        }

        private void btn_home_database_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(dbManager);
            dashboard.Show();
            this.Close();
        }

        private void btn_logout_database_Click(object sender, EventArgs e)
        {
            this.Close();
            Login loginForm = new Login(dbManager);
            loginForm.Show();
        }

        private void btn_exit_database_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit the application?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void attention_btn_database_Click(object sender, EventArgs e)
        {
            LoadDataForStockCheck();
        }

        private void refresh_btn_database_Click(object sender, EventArgs e)
        {
            LoadDataAll();
        }
    }
}
