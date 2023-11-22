using System;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BME_Inventory
{
    public partial class Dashboard : Form
    {
        private DatabaseManager dbManager;
        private SqlConnection connection;

        public Dashboard(DatabaseManager databaseManager)
        {
            InitializeComponent();
            dbManager = databaseManager;
            connection = dbManager.GetConnection();
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            log_lbl_dashboard.AutoSize = true;
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

        private void refresh_btn_dashboard_Click_1(object sender, EventArgs e)
        {
            string query = "SELECT * FROM inventory WHERE stock < lower";
            LoadDataIntoGrid(query, new DataTable());
        }

        private void btn_distribute_logs_Click(object sender, EventArgs e)
        {
            try
            {
                string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string distributionLogsPath = Path.Combine(documentsPath, "Inventory Logs", "Distribution Logs");

                string selectedDate = dateTimePicker1.Value.ToString("yyyyMMdd");
                string searchPattern = $"Distribution_log_{selectedDate}.txt";

                string[] logFiles = Directory.GetFiles(distributionLogsPath, searchPattern);

                if (logFiles.Length > 0)
                {
                    string logContents = File.ReadAllText(logFiles[0]);
                    log_lbl_dashboard.Text = $"Distribution logs for {selectedDate}:\n{logContents}";
                }
                else
                {
                    log_lbl_dashboard.Text = $"No distribution logs found for {selectedDate}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btn_received_logs_Click(object sender, EventArgs e)
        {
            try
            {
                string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string receivedLogsPath = Path.Combine(documentsPath, "Inventory Logs", "Received Logs");

                string selectedDate = dateTimePicker1.Value.ToString("yyyyMMdd");
                string searchPattern = $"Received_log_{selectedDate}.txt";

                string[] logFiles = Directory.GetFiles(receivedLogsPath, searchPattern);

                if (logFiles.Length > 0)
                {
                    string logContents = File.ReadAllText(logFiles[0]);
                    log_lbl_dashboard.Text = $"Received logs for {selectedDate}:\n{logContents}";
                }
                else
                {
                    log_lbl_dashboard.Text = $"No Received logs found for {selectedDate}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
