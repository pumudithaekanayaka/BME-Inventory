using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BME_Inventory
{
    public partial class Edit : Form
    {
        private DatabaseManager dbManager;

        public Edit(DatabaseManager databaseManager)
        {
            InitializeComponent();
            dbManager = databaseManager;
            BindMakeComboBox();
            BindModelComboBox();
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
        }

        private void BindMakeComboBox()
        {
            try
            {
                dbManager.OpenConnection();

                var uniqueMakes = new HashSet<string>();

                string query = "SELECT make FROM parts WHERE make IS NOT NULL";
                using (SqlCommand cmd = new SqlCommand(query, dbManager.GetConnection()))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string makeValue = reader["make"].ToString() ?? string.Empty;

                            if (!uniqueMakes.Contains(makeValue))
                            {
                                make_combo1.Items.Add(makeValue);
                                uniqueMakes.Add(makeValue);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                dbManager.CloseConnection();
            }
        }

        private void BindModelComboBox()
        {
            try
            {
                dbManager.OpenConnection();

                var uniqueModels = new HashSet<string>();

                string query = "SELECT model FROM parts WHERE model IS NOT NULL";
                using (SqlCommand cmd = new SqlCommand(query, dbManager.GetConnection()))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string modelValue = reader["model"].ToString() ?? string.Empty;

                            if (!uniqueModels.Contains(modelValue))
                            {
                                model_combo1.Items.Add(modelValue);
                                uniqueModels.Add(modelValue);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                dbManager.CloseConnection();
            }
        }

        private void load_btn_Click(object sender, EventArgs e)
        {
            try
            {
                dbManager.OpenConnection();

                string query = "SELECT * FROM inventory WHERE part_id LIKE '%' + @part_id + '%'";
                using (SqlCommand cmd = new SqlCommand(query, dbManager.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@part_id", part_id_txt_edit.Text);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            part_name_txt_edit.Text = reader.GetString(1);
                            equip_name_txt_edit.Text = reader.GetString(2);
                            upper_lbl_edit.Text = reader.GetDecimal(3).ToString();
                            lower_lbl_edit.Text = reader.GetDecimal(4).ToString();
                            stock_lbl_edit.Text = reader.GetDecimal(5).ToString();
                            desc_txt_edit.Text = reader.GetString(6);
                            make_lbl_edit.Text = reader.GetString(7);
                            model_lbl_edit.Text = reader.GetString(8);

                            decimal stockValue;
                            if (decimal.TryParse(stock_lbl_edit.Text, out stockValue) && decimal.TryParse(lower_lbl_edit.Text, out decimal lowerValue))
                            {
                                if (stockValue < lowerValue)
                                {
                                    MessageBox.Show("Stock value is less than lower limit!");
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Record not found!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                dbManager.CloseConnection();
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                dbManager.OpenConnection();

                string query = "UPDATE inventory SET part_name = @part_name, equip_name = @equipment_name, stock = @stock, description = @description, make = @make, model = @model WHERE part_id = @part_id";
                using (SqlCommand cmd = new SqlCommand(query, dbManager.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@part_id", part_id_txt_edit.Text);
                    cmd.Parameters.AddWithValue("@part_name", part_name_txt_edit.Text);
                    cmd.Parameters.AddWithValue("@equipment_name", equip_name_txt_edit.Text);
                    cmd.Parameters.AddWithValue("@stock", stock_txt1.Text);
                    cmd.Parameters.AddWithValue("@description", desc_txt_edit.Text);
                    cmd.Parameters.AddWithValue("@make", make_combo1.SelectedItem?.ToString() ?? "");
                    cmd.Parameters.AddWithValue("@model", model_combo1.SelectedItem?.ToString() ?? "");
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Record not found!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                dbManager.CloseConnection();
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                dbManager.OpenConnection();

                string query = "DELETE FROM inventory WHERE part_id = @part_id";
                using (SqlCommand cmd = new SqlCommand(query, dbManager.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@part_id", part_id_txt_edit.Text);

                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record deleted successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Record not found!");
                        }
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        Hide();
                        Create form1 = new Create(dbManager);
                        form1.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                dbManager.CloseConnection();
            }
        }

        private void btn_database_edit_Click(object sender, EventArgs e)
        {
            Database database = new Database(dbManager);
            database.Show();
            this.Hide();
        }

        private void btn_distribute_edit_Click(object sender, EventArgs e)
        {
            Distribute distribute = new Distribute(dbManager);
            distribute.Show();
            this.Hide();
        }

        private void btn_receive_edit_Click(object sender, EventArgs e)
        {
            Recieve receive = new Recieve(dbManager);
            receive.Show();
            this.Hide();
        }

        private void btn_add_edit_Click_1(object sender, EventArgs e)
        {
            Create add = new Create(dbManager);
            add.Show();
            this.Hide();
        }

        private void btn_adduser_edit_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser(dbManager);
            addUser.Show();
            this.Hide();
        }

        private void btn_home_edit_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(dbManager);
            dashboard.Show();
            this.Hide();
        }

        private void btn_dev_edit_Click(object sender, EventArgs e)
        {
            DeveloperDashboard developerDashboard = new DeveloperDashboard(dbManager);
            developerDashboard.Show();
            this.Hide();
        }
    }
}

