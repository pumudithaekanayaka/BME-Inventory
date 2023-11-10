using System.Data.SqlClient;

namespace BME_Inventory
{
    public partial class Insert : Form
    {
        private DatabaseManager dbManager;

        public Insert(DatabaseManager databaseManager)
        {
            InitializeComponent();
            dbManager = databaseManager;
            BindMakeComboBox();
            BindModelComboBox();
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

        private void insert_btn_Click(object sender, EventArgs e)
        {
            try
            {
                dbManager.OpenConnection();

                string partId = part_id_txt.Text;
                string partName = part_name_txt.Text;
                string equipName = equip_name_txt.Text;
                string upper = upper_txt.Text;
                string lower = lower_txt.Text;
                string stock = stock_txt.Text;
                string description = desc_txt.Text;
                string make = make_combo1.SelectedItem?.ToString() ?? "";
                string model = model_combo1.SelectedItem?.ToString() ?? "";

                if (string.IsNullOrEmpty(partId) || string.IsNullOrEmpty(partName) || string.IsNullOrEmpty(equipName) || string.IsNullOrEmpty(upper) || string.IsNullOrEmpty(lower) || string.IsNullOrEmpty(stock) || string.IsNullOrEmpty(description) || string.IsNullOrEmpty(make) || string.IsNullOrEmpty(model))
                {
                    success_lbl1.Text = "Enter All the fields";
                    success_lbl1.ForeColor = Color.White;
                    success_lbl1.BackColor = Color.Red;
                    success_lbl1.Visible = true;
                    return;
                }

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = dbManager.GetConnection();
                    cmd.CommandText = "INSERT INTO inventory(part_id, part_name, equip_name, upper, lower, stock, description, make, model, date_time) " +
                        "VALUES(@part_id, @part_name, @equip_name, @upper, @lower, @stock, @description, @make, @model, GETDATE())";

                    cmd.Parameters.AddWithValue("@part_id", part_id_txt.Text);
                    cmd.Parameters.AddWithValue("@part_name", part_name_txt.Text);
                    cmd.Parameters.AddWithValue("@equip_name", equip_name_txt.Text);
                    cmd.Parameters.AddWithValue("@upper", upper_txt.Text);
                    cmd.Parameters.AddWithValue("@lower", lower_txt.Text);
                    cmd.Parameters.AddWithValue("@stock", stock_txt.Text);
                    cmd.Parameters.AddWithValue("@description", desc_txt.Text);
                    cmd.Parameters.AddWithValue("@make", make_combo1.SelectedItem.ToString() ?? "");
                    cmd.Parameters.AddWithValue("@model", model_combo1.SelectedItem.ToString() ?? "");

                    cmd.ExecuteNonQuery();
                }

                success_lbl1.Text = "Entry Successfully Added";
                success_lbl1.Visible = true;

                ClearTextBoxes(this);
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

        private void ClearTextBoxes(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                else
                {
                    ClearTextBoxes(c);
                }
            }
        }

        private void view_btn_Click(object sender, EventArgs e)
        {
            View view = new View(dbManager);
            view.Show();
            this.Hide();
        }

        private void load_btn_Click(object sender, EventArgs e)
        {
            Recieve show_data = new Recieve(dbManager);
            show_data.Show();
            this.Hide();
        }

        private void home_btn1_Click(object sender, EventArgs e)
        {
            Dashboard home = new Dashboard(dbManager);
            home.Show();
            this.Hide();
        }

        private void model_btn1_Click(object sender, EventArgs e)
        {
            try
            {
                string make = make_txt1.Text;
                string model = model_txt1.Text;

                if (string.IsNullOrEmpty(make) || string.IsNullOrEmpty(model))
                {
                    MessageBox.Show("Both 'Make' and 'Model' fields must be filled.");
                }
                else
                {
                    dbManager.OpenConnection();

                    using (SqlCommand cmd = new SqlCommand("INSERT INTO parts(make, model) VALUES(@make, @model)", dbManager.GetConnection()))
                    {
                        cmd.Parameters.AddWithValue("@make", make);
                        cmd.Parameters.AddWithValue("@model", model);
                        cmd.ExecuteNonQuery();
                    }

                    ClearTextBoxes(this);
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


        private void exit_btn6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit the application?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void home_btn1_Click_1(object sender, EventArgs e)
        {
            Dashboard home = new Dashboard(dbManager);
            home.Show();
            this.Hide();
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            View view = new View(dbManager);
            view.Show();
            this.Hide();
        }

        private void table_btn6_Click(object sender, EventArgs e)
        {
            Table table = new Table(dbManager);
            table.Show();
            this.Hide();
        }

        private void distribute_btn_Click(object sender, EventArgs e)
        {
            Distribute distribute = new Distribute(dbManager);
            distribute.Show();
            this.Hide();
        }
    }
}