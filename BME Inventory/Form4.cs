using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BME_Inventory
{
    public partial class Table : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=ASUS_X512JA\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=Truee");

        public Table()
        {
            InitializeComponent();
        }

        private void load_btn3_Click(object sender, EventArgs e)
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
                StringBuilder sb = new StringBuilder();
                foreach (DataRow row in table.Rows)
                {
                    foreach (DataColumn col in table.Columns)
                    {
                        sb.Append(row[col].ToString() + "\t");
                    }
                    sb.Append("\n");
                }

                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("your_email_address@gmail.com");
                mail.To.Add("to_address@example.com");
                mail.Subject = "Spare Parts Data";
                mail.Body = sb.ToString();

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("your_email_address@gmail.com", "your_email_password");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
            }
            else
            {
                MessageBox.Show("Record not found!");
            }
            connection.Close();
        }
    }
}
