using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_EF_Ders1_Part2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string appName = ConfigurationManager.AppSettings["AppName"];
            string version = ConfigurationManager.AppSettings["Version"];

            Text = $"{appName} - {version}";
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            NorthwindEntities db = new NorthwindEntities();

            List<Category> categories = db.Categories.ToList();

            listBox1.DataSource = categories;
            listBox1.DisplayMember = nameof(Category.Description); // CategoryName
            listBox1.ValueMember = nameof(Category.CategoryID); // CategoryID

            dataGridView1.DataSource = categories;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            NorthwindEntities db = new NorthwindEntities();

            Category category = new Category();
            category.CategoryName = txtInsCatName.Text;

            db.Categories.Add(category);
            db.SaveChanges();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int catId = (int)dataGridView1.CurrentRow.Cells["CategoryID"].Value;
            //int catId = (int)dataGridView1.SelectedRows[0].Cells["CategoryID"].Value;

            NorthwindEntities db = new NorthwindEntities();

            Category category = db.Categories.Where(c => c.CategoryID == catId).FirstOrDefault();
            category.CategoryName = txtUpdCatName.Text;

            db.SaveChanges();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int catId = (int)dataGridView1.CurrentRow.Cells["CategoryID"].Value;

            NorthwindEntities db = new NorthwindEntities();
            Category category = db.Categories.Where(c => c.CategoryID == catId).FirstOrDefault();

            db.Categories.Remove(category);
            db.SaveChanges();
        }
    }
}
