using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Text;

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
            connection.Open();
            string query = "SELECT * FROM spare_parts WHERE stock < lower";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                // Export the data to an Excel sheet
                using (var package = new ExcelPackage())
                {
                    var worksheet = package.Workbook.Worksheets.Add("Spare Parts Data");

                    // Add headers
                    for (int i = 1; i <= table.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i].Value = table.Columns[i - 1].ColumnName;
                    }

                    // Add data rows
                    for (int row = 0; row < table.Rows.Count; row++)
                    {
                        for (int col = 0; col < table.Columns.Count; col++)
                        {
                            worksheet.Cells[row + 2, col + 1].Value = table.Rows[row][col];
                        }
                    }

                    // Save the Excel file
                    var excelBytes = package.GetAsByteArray();
                    File.WriteAllBytes("SparePartsData.xlsx", excelBytes);
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
    }
}
