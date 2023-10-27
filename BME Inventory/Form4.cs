using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Text;
using OfficeOpenXml;
using System.IO;
using System.Diagnostics;

namespace BME_Inventory
{
    public partial class Table : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=ASUS_X512JA\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True");

        public Table()
        {
            InitializeComponent();
        }

        private void load_btn3_Click(object sender, EventArgs e)
        {
            connection.Open();
            string query = "SELECT * FROM spare_parts WHERE stock < lower";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                dataGridView1.DataSource = table;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            else
            {
                MessageBox.Show("Record not found!");
            }
            connection.Close();
        }

        private void mail_btn_Click(object sender, EventArgs e)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            connection.Open();
            string query = "SELECT * FROM spare_parts WHERE stock < lower";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                string filePath = "C:\\Inventory Logs\\SparePartsData.xlsx";

                using (var package = new ExcelPackage(new FileInfo(filePath)))
                {
                    var worksheet = package.Workbook.Worksheets.Add("Spare Parts Data");

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
            }
            else
            {
                MessageBox.Show("Record not found!");
            }

            connection.Close();
        }

        private void Table_Load(object sender, EventArgs e)
        {
            connection.Open();
            string query = "SELECT * FROM spare_parts";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                dataGridView1.DataSource = table;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            else
            {
                MessageBox.Show("Record not found!");
            }
            connection.Close();
        }

        private void exit_btn4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit the application?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void mail_btn4_Click(object sender, EventArgs e)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            connection.Open();
            string query = "SELECT * FROM spare_parts WHERE stock < lower";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);

            string filePath = "C:\\Inventory Logs\\SparePartsData.xlsx";
            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                string worksheetName = "Spare Parts Data";
                int worksheetNumber = 1;

                // Loop until a unique worksheet name is found
                while (package.Workbook.Worksheets.Any(ws => ws.Name == worksheetName))
                {
                    worksheetName = "Spare Parts Data_" + worksheetNumber;
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

            // Use the default email client to send the email with the attached Excel file
            Process.Start(new ProcessStartInfo
            {
                FileName = filePath, // The path to the Excel file
                UseShellExecute = true,
                Verb = "open"
            });

            connection.Close();
        }
    }
}
