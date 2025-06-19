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

namespace D032310396
{
    public partial class FormBook : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DITP2123\LabTest2\D032310396\D032310396\AdmiralBookstoreDatabase.mdf;Integrated Security=True;Connect Timeout=30";

        public FormBook()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Book", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewBook.DataSource = dt;
            }
        }

        private void dataGridViewBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textBoxISBN.Text = dataGridViewBook.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBoxTitle.Text = dataGridViewBook.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBoxPublisher.Text = dataGridViewBook.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBoxPublisherDate.Text = Convert.ToDateTime(dataGridViewBook.Rows[e.RowIndex].Cells[3].Value).ToString("yyyy-MM-dd");

            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "UPDATE Book SET Title=@title, Publisher=@pub, PublishDate=@date WHERE [ISBN-13]=@isbn";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@isbn", textBoxISBN.Text);
                cmd.Parameters.AddWithValue("@title", textBoxTitle.Text);
                cmd.Parameters.AddWithValue("@pub", textBoxPublisher.Text);
                cmd.Parameters.AddWithValue("@date", textBoxPublisherDate.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            LoadData();
        }

        private void buttonAuthor_Click(object sender, EventArgs e)
        {
            new FormAuthor().Show();
            this.Hide();
        }

        private void buttonStock_Click(object sender, EventArgs e)
        {
            new FormStock().Show();
            this.Hide();
        }
    }
}
