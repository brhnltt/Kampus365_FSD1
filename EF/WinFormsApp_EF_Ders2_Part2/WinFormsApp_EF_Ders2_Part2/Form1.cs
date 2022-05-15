using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WinFormsApp_EF_Ders2_Part2.Models;

namespace WinFormsApp_EF_Ders2_Part2
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

        private void button1_Click(object sender, EventArgs e)
        {
            MyShopEntities db = new MyShopEntities();
            Customer customer = new Customer();
            customer.Id = 1000;
            customer.Name = "aaa";
            customer.Surname = "asd";
            customer.Age = 12;
            customer.IsActive = true;

            db.Customers.Add(customer);
            db.SaveChanges();
        }
    }
}
