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
            string query = "SELECT part_name, equip_name, make, model, stock FROM inventory WHERE stock < lower";
            DataTable table = new DataTable();
            LoadDataIntoGrid(query, table);
        }

        private void LoadDataAll()
        {
            string query = "SELECT part_name, equip_name, make, model, stock FROM inventory";
            DataTable table = new DataTable();
            LoadDataIntoGrid(query, table);
        }

        private void mail_btn_Click(object sender, EventArgs e)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            string query = "SELECT part_name, equip_name, make, model, stock FROM inventory WHERE stock < lower";
            DataTable table = new DataTable();
            LoadDataIntoGrid(query, table);

            if (table.Rows.Count > 0)
            {

                string documentsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string FolderPath = Path.Combine(documentsFolder, "Inventory Logs");
                string FilePath = Path.Combine(FolderPath, $"SparePartsData.xlsx");

                using (var package = new ExcelPackage(new FileInfo(FilePath)))
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
                    FileName = FilePath,
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
        }

        private void export_all_btn4_Click(object sender, EventArgs e)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            string query = "SELECT * FROM inventory";
            DataTable table = new DataTable();
            LoadDataIntoGrid(query, table);

            if (table.Rows.Count > 0)
            {
                string documentsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string FolderPath = Path.Combine(documentsFolder, "Inventory Logs");
                string FilePath = Path.Combine(FolderPath, $"SparePartsData.xlsx");

                using (var package = new ExcelPackage(new FileInfo(FilePath)))
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
                    FileName = FilePath,
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

            string[] columnsToSearch = { "part_id", "part_name", "equip_name", "description", "make", "model" };

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

        private void attention_btn_database_Click(object sender, EventArgs e)
        {
            LoadDataForStockCheck();
        }

        private void refresh_btn_database_Click(object sender, EventArgs e)
        {
            LoadDataAll();
        }

        private void print_btn_database_Click(object sender, EventArgs e)
        {
            PrintWindow printWindow = new PrintWindow(dbManager);
            printWindow.Show();
            this.Close();
        }
    }
}
