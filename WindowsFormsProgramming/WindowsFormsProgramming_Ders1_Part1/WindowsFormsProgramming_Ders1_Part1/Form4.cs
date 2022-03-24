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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnYaz_Click(object sender, EventArgs e)
        {
            IslemYap();
        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            IslemYap();
        }

        private void txtSoyad_TextChanged(object sender, EventArgs e)
        {
            IslemYap();
        }

        void IslemYap()
        {
            lblSonuc.Text = txtAd.Text + " " + txtSoyad.Text + "!";
        }

        private void btnOku_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnOku_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = txtAd.Text + " " + txtSoyad.Text;
        }
    }
}
