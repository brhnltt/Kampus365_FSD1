using MyAdoHelper;
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

namespace WinFormsApp3Core_TestMyAdoHelper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MyAdoNetHelper myAdoNetHelper = new MyAdoNetHelper(@"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=True;");

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = myAdoNetHelper.ExecuteReader("SELECT * FROM Categories");
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Categories WHERE CategoryName=@CatName";
            SqlParameter pCatName = new SqlParameter("@CatName", "Beverages");

            DataTable dt = myAdoNetHelper.ExecuteReader(query, CommandType.Text, pCatName);
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "SalesByCategor";
            SqlParameter pCatName = new SqlParameter("@CategoryName", "Beverages");
            SqlParameter pOrderYear = new SqlParameter("@OrdYear", 1996);

            try
            {
                DataTable dt = myAdoNetHelper.ExecuteReader(query, CommandType.StoredProcedure, pCatName, pOrderYear);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
