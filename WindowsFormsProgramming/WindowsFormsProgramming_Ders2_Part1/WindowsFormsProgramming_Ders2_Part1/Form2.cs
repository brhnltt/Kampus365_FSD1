using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsProgramming_Ders2_Part1
{
    public partial class Form2 : Form
    {
        List<string> liste = new List<string>();

        public Form2()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string item = txtAdSoyad.Text + " | " + mtxtTelefon.Text;
            liste.Add(item);

            ListeYukle();
        }

        void ListeYukle()
        {
            lstKisiler.Items.Clear();

            foreach (string listitem in liste)
            {
                lstKisiler.Items.Add(listitem);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lstKisiler.Items.Clear();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            //txtAdSoyad.Text = "";
            //txtAdSoyad.Text = string.Empty;
            //txtAdSoyad.Text = null;
            txtAdSoyad.Clear();
            txtEPosta.Clear();
            mtxtTelefon.Clear();
            txtNot.Clear();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if(lstKisiler.SelectedIndex > -1)
            {
                int index = lstKisiler.SelectedIndex;
                liste.RemoveAt(index);


                ListeYukle();
            }
            else
            {
                MessageBox.Show("Lütfen listeden bir seçim yapınız.");
            }
        }

        private void lstKisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstKisiler.SelectedIndex;
            string item = liste[index]; // aaaaa | (555) 777 88 66

            string[] items = item.Split('|');
            string adSoyad = items[0].Trim();
            string tel = items[1].Trim();

            txtAdSoyad.Text = adSoyad;
            mtxtTelefon.Text = tel;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (lstKisiler.SelectedIndex > -1)
            {
                string item = txtAdSoyad.Text + " | " + mtxtTelefon.Text;
                int index = lstKisiler.SelectedIndex;

                liste[index] = item;

                ListeYukle();
            }
            else
            {
                MessageBox.Show("Lütfen listeden bir seçim yapınız.");
            }
                
        }
    }
}
