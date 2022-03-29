using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsProgramming_Ders3_Part2
{
    public partial class frmMesaj : Form
    {
        public frmMesaj()
        {
            InitializeComponent();
        }

        private void btnDetayFormAc_Click(object sender, EventArgs e)
        {
            frmDetay detayForm = new frmDetay();
            detayForm.ShowDialog();

            MessageBox.Show("Hello World!");
        }

        private void btnDetayFormAc2_Click(object sender, EventArgs e)
        {
            frmDetay detayForm = new frmDetay();
            detayForm.Show();

            MessageBox.Show("Hello World!");
        }

        private void btnDetayFormaAktar_Click(object sender, EventArgs e)
        {
           
            frmDetay detayForm = new frmDetay();
            detayForm.Text = "Detay Formu";
            detayForm.BackColor = Color.Red;

            string metin = textBox1.Text;
            detayForm.label1.Text = metin;
            detayForm.label1.ForeColor = Color.White;

            detayForm.LabelText = metin;

            detayForm.ShowDialog();

            MessageBox.Show(detayForm.textBox2.Text);
            textBox1.Text = detayForm.textBox2.Text;
        }

        private void btnDetayFormaAktar2_Click(object sender, EventArgs e)
        {
            frmDetay detayForm = new frmDetay();
            detayForm.Text = "Detay Formu";
            detayForm.BackColor = Color.Red;

            string metin = textBox1.Text;
            detayForm.LabelText = metin;

            detayForm.ShowDialog();

            MessageBox.Show(detayForm.TextboxText);
            textBox1.Text = detayForm.TextboxText;
        }
    }
}
