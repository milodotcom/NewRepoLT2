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
using System.Xml.Linq;

namespace D032310396
{
    public partial class FormAuthor : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DITP2123\LabTest2\D032310396\D032310396\AdmiralBookstoreDatabase.mdf;Integrated Security=True;Connect Timeout=30";

        public FormAuthor()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Author", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewAuthor.DataSource = dt;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "INSERT INTO Author (AuthorID, Name, BirthYear) VALUES (@id, @name, @year)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", textBoxAuthorID.Text);
                cmd.Parameters.AddWithValue("@name", textBoxName.Text);
                cmd.Parameters.AddWithValue("@year", textBoxBirthYear.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            LoadData();
        }

        private void buttonBook_Click(object sender, EventArgs e)
        {
            new FormBook().Show();
            this.Hide();
        }

        private void buttonStock_Click(object sender, EventArgs e)
        {
            new FormStock().Show();
            this.Hide();
        }
    }
}
