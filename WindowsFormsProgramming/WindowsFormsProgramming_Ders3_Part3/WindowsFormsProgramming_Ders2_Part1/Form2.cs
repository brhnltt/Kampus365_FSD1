using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsProgramming_Ders2_Part1
{
    public partial class Form2 : Form
    {
        List<string> liste = new List<string>();
        TextBoxBase lastTextbox = null;

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
            //lstKisiler.Items.Clear();

            DosyadanOku();
            ListeYukle();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            string dosyaAdi = "kisiler.txt";
            string klasorYolu = Application.StartupPath;
            //string klasorYolu = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);


            //string dosyaYolu = klasorYolu + dosyaAdi;
            string dosyaYolu = Path.Combine(klasorYolu, dosyaAdi);

            FileStream stream = new FileStream(dosyaYolu, FileMode.Create);
            StreamWriter streamWriter = new StreamWriter(stream);

            //foreach (string item in lstKisiler.Items)
            foreach (string item in liste)
            {
                streamWriter.WriteLine(item);
            }

            streamWriter.Close();   // dosya yazıcısını kapatır.
            stream.Close(); // dosya kapatır.

            MessageBox.Show("Kişiler kaydedildi.", "Kaydedildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void DosyadanOku()
        {
            string dosyaAdi = "kisiler.txt";
            string klasorYolu = Application.StartupPath;
            //string klasorYolu = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            //string dosyaYolu = klasorYolu + dosyaAdi;
            string dosyaYolu = Path.Combine(klasorYolu, dosyaAdi);

            // Directory, File İşlemleri

            if (File.Exists(dosyaYolu) == true)
            {
                FileStream stream = new FileStream(dosyaYolu, FileMode.Open);
                StreamReader streamReader = new StreamReader(stream);

                while (streamReader.EndOfStream == false)
                {
                    string deger = streamReader.ReadLine();
                    liste.Add(deger);
                }

                streamReader.Close();
                stream.Close();
            }

            // kisiler.txt dosyasını silin ve programı çalıştırın. Alınan hata olursa, nasıl aşarsınız, uygulayın!
            // kes - kopyala- yapıştır düğmelerini Ad Soyad textbox ı için kullanılır hale getirin!
            // kes - kopyala- yapıştır düğmelerinin tüm textbox lar için tek tek yazılarak DEĞİL genel kodlayarak çalışır hale getirin!
        }

        private void btnCut_Click(object sender, EventArgs e)
        {
            //txtAdSoyad.Cut();
            lastTextbox.Cut();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            //txtAdSoyad.Copy();
            lastTextbox.Copy();
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            //txtAdSoyad.Paste();
            lastTextbox.Paste();
        }

        private void txtAdSoyad_Enter(object sender, EventArgs e)
        {
            lastTextbox = txtAdSoyad;
        }

        private void txtEPosta_Enter(object sender, EventArgs e)
        {
            lastTextbox = txtEPosta;
        }

        private void txtNot_Enter(object sender, EventArgs e)
        {
            lastTextbox = txtNot;
        }

        private void mtxtTelefon_Enter(object sender, EventArgs e)
        {
            lastTextbox = mtxtTelefon;
        }


        private void WhatIsStringBuilder()
        {
            StringBuilder sb = new StringBuilder(); // "";
            sb.Append("Murat");                     // "" + "Murat"
            sb.Append(" ");                         // "" + "Murat" + " "
            sb.Append("Başeren");                   // "" + "Murat" + " " + "Başeren"
        }
    }
}
