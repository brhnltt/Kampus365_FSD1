using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSQLConnectionOpenClose_Click(object sender, EventArgs e)
        {
            // Windows Auth
            string connectionString = @"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=True;";
            //string connectionString = @"Server=(localdb)\mssqllocaldb;Database=Northwind;Integrated Security=SSPI;";
            //string connectionString = Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;

            // SQL Auth
            //string connectionString = @"Server=(localdb)\mssqllocaldb;Database=Northwind;User Id=sa;Password=123456;";
            System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString);


            connection.Open();

            MessageBox.Show("Bağlantı açıldı.");



            connection.Close();

            MessageBox.Show("Bağlantı kapatıldı.");
        }
    }
}
