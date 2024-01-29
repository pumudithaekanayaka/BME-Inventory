using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BME_Inventory
{
    public partial class DeveloperDashboard : Form
    {
        private DatabaseManager dbManager;
        private SqlConnection connection;

        public DeveloperDashboard(DatabaseManager databaseManager)
        {
            InitializeComponent();
            dbManager = databaseManager;
            connection = dbManager.GetConnection();
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
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

        private void MaintenanceHome_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM users";
            LoadDataIntoGrid(query, new DataTable());
        }

        private void firstrun_reset_btn_dev_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to reset the first run status?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Properties.Settings.Default["IsFirstRun"] = true;
                Properties.Settings.Default.Save();

                MessageBox.Show("First run status has been reset.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
