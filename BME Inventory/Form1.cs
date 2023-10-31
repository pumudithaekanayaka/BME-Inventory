using System.Data.SqlClient;

namespace BME_Inventory
{
    public partial class Insert : Form
    {
        private const string ConnectionString = "Data Source=ASUS_X512JA\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True";

        private SqlConnection con;
        private SqlCommand cmd;

        public Insert()
        {
            InitializeComponent();

            con = new SqlConnection(ConnectionString);
            cmd = new SqlCommand();
            cmd.Connection = con;
            BindMakeComboBox();
            BindModelComboBox();
        }

        private void BindMakeComboBox()
        {
            try
            {
                con.Open();

                var uniqueMakes = new HashSet<string>();

                string query = "SELECT make FROM parts_data WHERE make IS NOT NULL";
                cmd.CommandText = query;

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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void BindModelComboBox()
        {
            try
            {
                con.Open();

                var uniqueModels = new HashSet<string>();

                string query = "SELECT model FROM parts_data WHERE model IS NOT NULL";
                cmd.CommandText = query;

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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                cmd.CommandText = "INSERT INTO spare_parts(part_id, part_name, equip_name, upper, lower, stock, description, make, model) " + "VALUES(@part_id, @part_name, @equip_name, @upper, @lower, @stock, @description, @make, @model)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@part_id", part_id_txt.Text);
                cmd.Parameters.AddWithValue("@part_name", part_name_txt.Text);
                cmd.Parameters.AddWithValue("@equip_name", equip_name_txt.Text);
                cmd.Parameters.AddWithValue("@upper", upper_txt.Text);
                cmd.Parameters.AddWithValue("@lower", lower_txt.Text);
                cmd.Parameters.AddWithValue("@stock", stock_txt.Text);
                cmd.Parameters.AddWithValue("@description", desc_txt.Text);
                cmd.Parameters.AddWithValue("@make", make_combo1.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@model", model_combo1.SelectedItem.ToString());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Entry Successfully Updated");

                ClearTextBoxes(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
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
            View view = new View();
            view.Show();
            this.Hide();
        }

        private void load_btn_Click(object sender, EventArgs e)
        {
            Show_Data show_data = new Show_Data();
            show_data.Show();
            this.Hide();
        }

        private void home_btn1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void model_btn1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(make_txt1.Text) || string.IsNullOrEmpty(model_txt1.Text))
                {
                    MessageBox.Show("Both 'Make' and 'Model' fields must be filled.");
                }
                else
                {
                    con.Open();
                    cmd.CommandText = "INSERT INTO parts_data(make, model) VALUES(@make, @model)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@make", make_txt1.Text);
                    cmd.Parameters.AddWithValue("@model", model_txt1.Text);
                    cmd.ExecuteNonQuery();
                    ClearTextBoxes(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
