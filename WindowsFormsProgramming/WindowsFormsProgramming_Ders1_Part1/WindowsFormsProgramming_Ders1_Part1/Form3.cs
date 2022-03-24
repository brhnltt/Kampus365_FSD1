using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsProgramming_Ders1_Part1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "Click Me!";
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.Text = "Mouse Hover";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            string soyad = textBox2.Text;
            //string adSoyad = textBox1.Text + " " + textBox2.Text;

            string adSoyad = ad + " " + soyad;
            label1.Text = adSoyad;
        }
    }
}
