using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

namespace BME_Inventory
{
    public partial class PrintWindow : Form
    {
        private DatabaseManager dbManager;
        private SqlConnection connection;

        public PrintWindow(DatabaseManager databaseManager)
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
                MessageBox.Show("Error loading data: " + ex.Message);
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

        private void data_load_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT part_name, equip_name, make, model, stock FROM inventory WHERE stock < lower";
                DataTable dataTable = new DataTable();
                LoadDataIntoGrid(query, dataTable);

                using (MemoryStream stream = new MemoryStream())
                {
                    try
                    {
                        string pdfFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Inventory Logs", "biomed.pdf");

                        using (PdfWriter writer = new PdfWriter(stream))
                        using (PdfDocument pdf = new PdfDocument(writer))
                        {
                            Document document = new Document(pdf);

                            foreach (DataColumn column in dataTable.Columns)
                            {
                                document.Add(new Paragraph(column.ColumnName));
                            }

                            foreach (DataRow row in dataTable.Rows)
                            {
                                foreach (var item in row.ItemArray)
                                {
                                    document.Add(new Paragraph(item.ToString()));
                                }
                            }
                        }

                        File.WriteAllBytes(pdfFilePath, stream.ToArray());
                        System.Diagnostics.Process.Start(pdfFilePath);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("Error creating or writing to PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error during PDF processing: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrintWindow_Load(object sender, EventArgs e)
        {
            // Load any initial data or setup
        }
    }
}