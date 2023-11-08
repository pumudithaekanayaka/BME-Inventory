using OfficeOpenXml;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace BME_Inventory
{
    public partial class Table : Form
    {
        private DatabaseManager dbManager;
        private SqlConnection connection;

        public Table(DatabaseManager databaseManager)
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
            string query = "SELECT * FROM spare_parts WHERE stock < lower";
            DataTable table = new DataTable();
            LoadDataIntoGrid(query, table);
        }

        private void load_btn3_Click(object sender, EventArgs e)
        {
            LoadDataForStockCheck();
        }

        private void mail_btn_Click(object sender, EventArgs e)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            string query = "SELECT * FROM spare_parts WHERE stock < lower";
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
            string query = "SELECT * FROM spare_parts";
            LoadDataIntoGrid(query, new DataTable());
        }

        private void exit_btn4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit the application?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void home_btn4_Click(object sender, EventArgs e)
        {
            Dashboard home = new Dashboard(dbManager);
            home.Show();
            this.Hide();
        }

        private void export_all_btn4_Click(object sender, EventArgs e)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            string query = "SELECT * FROM spare_parts";
            DataTable table = new DataTable();
            LoadDataIntoGrid(query, table);

            if (table.Rows.Count > 0)
            {
                string filePath = "C:\\Inventory Logs\\SparePartsAllData.xlsx";

                using (var package = new ExcelPackage(new FileInfo(filePath)))
                {
                    string worksheetName = "Spare Parts Data";
                    int worksheetNumber = 1;

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
    }
}
