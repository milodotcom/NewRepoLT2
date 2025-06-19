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
    public partial class FormStock : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DITP2123\LabTest2\D032310396\D032310396\AdmiralBookstoreDatabase.mdf;Integrated Security=True;Connect Timeout=30";

        public FormStock()
        {
            InitializeComponent();
            LoadData();

        }
        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Stock", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewStock.DataSource = dt;
            }
        }

        private void FormStock_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textBoxStockID.Text = dataGridViewStock.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBoxAuthorID.Text = dataGridViewStock.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBoxISBN.Text = dataGridViewStock.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBoxQuantity.Text = dataGridViewStock.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBoxDateRecorded.Text = Convert.ToDateTime(dataGridViewStock.Rows[e.RowIndex].Cells[4].Value).ToString("yyyy-MM-dd");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "DELETE FROM Stock WHERE StockID = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", textBoxStockID.Text);
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

        private void buttonBook_Click(object sender, EventArgs e)
        {
            new FormBook().Show();
            this.Hide();
        }
    }
}
