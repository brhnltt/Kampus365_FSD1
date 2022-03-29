using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsProgramming_Ders3_Part1
{
    public partial class Form1 : Form
    {

        List<string> metinler = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string metin = txtMetin.Text;
            metinler.Add(metin);


            Listele();
        }

        void Listele()
        {
            lstMetinler.Items.Clear();

            foreach (string m in metinler)
            {
                lstMetinler.Items.Add(m);
            }
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            int index = lstMetinler.SelectedIndex;

            if(index < 0)
            {
                MessageBox.Show("Lütfen bir item seçiniz.");
            }
            else
            {
                string metin = metinler[index];

                MessageBox.Show(metin);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            metinler.Add("Kampüs 365");
            metinler.Add("NET Core Eğitimi");
            metinler.Add("Windows Forms Application");

            Listele();
        }
    }
}
