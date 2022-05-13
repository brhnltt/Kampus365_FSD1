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

namespace WinFormsApp_EF_Ders1_Part1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=Northwind;Trusted_Connection=True");
            SqlCommand command = new SqlCommand("SELECT CategoryID, CategoryName FROM Categories", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;

            //int rowCount = dataTable.Rows.Count;
            //label1.Text = $"Kayıt Sayısı : {rowCount}"; // string interpolation

            int rowCount = 0;
            int idTotal = 0;

            foreach (DataRow row in dataTable.Rows)
            {
                rowCount++;
                idTotal += (int)row["CategoryID"];
            }

            label1.Text = $"Kayıt Sayısı : {rowCount} - ID Total : {idTotal}"; // string interpolation

            //command.CommandText = "SELECT COUNT(*) FROM Categories";
            //connection.Open();

            //int rowCount = (int)command.ExecuteScalar();

            //connection.Close();

            //label1.Text = $"Kayıt Sayısı : {rowCount}"; // string interpolation
        }

        private void btnGetAll2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=Northwind;Trusted_Connection=True");
            SqlCommand command = new SqlCommand("SELECT CategoryID, CategoryName, Description FROM Categories", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            List<Category> categories = new List<Category>();

            foreach (DataRow row in dataTable.Rows)
            {
                Category category = new Category();
                category.Id = (int)row["CategoryID"];
                category.Name = (string)row["CategoryName"];
                category.Desc = (string)row["Description"];

                categories.Add(category);
            }

            Category category1 = categories[0];
            //MessageBox.Show(category1.Name);
            //MessageBox.Show(category1.Desc);
            int ids = 0;

            foreach (Category item in categories)
            {
                if (item.Name.StartsWith("C"))
                {
                    ids += item.Id;
                }
            }

            dataGridView1.DataSource = categories;

        }
    }
}
