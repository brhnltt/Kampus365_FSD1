using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp_EF_Ders3_Part1.Models;

namespace WinFormsApp_EF_Ders3_Part1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetCustomers_Click(object sender, EventArgs e)
        {
            NorthwindContext db = new NorthwindContext();
            List<Customer> customers = db.Customers.ToList();

            dataGridView1.DataSource = customers;
        }
    }
}
