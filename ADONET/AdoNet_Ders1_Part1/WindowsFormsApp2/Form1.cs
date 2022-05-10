using AdoHelper;
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

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=True;";
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            List<Category> list = new AdoHelper<Category>(connection)
                .Query("SELECT * FROM Categories")
                .ExecuteReader()
                .ToList();

            connection.Close();

            listBox1.DataSource = null;
            listBox1.DataSource = list;
            listBox1.DisplayMember = "Name";
            listBox1.ValueMember = "Id";
        }
    }

    public class Category
    {
        [Field(Name ="categoryid")]
        public int Id { get; set; }

        [Field(Name = "categoryname")]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
