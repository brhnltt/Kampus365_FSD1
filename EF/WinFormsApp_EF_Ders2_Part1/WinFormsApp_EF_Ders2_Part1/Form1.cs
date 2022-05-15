using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_EF_Ders2_Part1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            MyShopEntities db = new MyShopEntities();
            List<Customer> customers = db.Customers.ToList();

            dataGridView1.DataSource = customers;
        }

        private void btnInsertCustomer_Click(object sender, EventArgs e)
        {
            string cName = txtCustomerName.Text;
            string cSurname = txtCustomerSurname.Text;
            short cAge = (short)nudCustomerAge.Value;

            MyShopEntities db = new MyShopEntities();

            Customer customer = new Customer
            {
                Name = cName,
                Surname = cSurname,
                Yas = cAge
            };

            db.Customers.Add(customer);
            db.SaveChanges();
        }
    }
}
