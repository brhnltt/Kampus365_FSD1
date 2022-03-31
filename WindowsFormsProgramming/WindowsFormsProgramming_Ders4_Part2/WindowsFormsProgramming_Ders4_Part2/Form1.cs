using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsProgramming_Ders4_Part2
{
    public partial class Form1 : Form
    {
        List<Kisi> kisiler = new List<Kisi>();


        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Kisi kayit = new Kisi();

            kayit.Ad = txtAd.Text;
            kayit.Soyad = txtSoyad.Text;
            kayit.Yas = (int)nudYas.Value;

            kisiler.Add(kayit);

            lstKisiler.Items.Clear();

            foreach (Kisi item in kisiler)
            {
                lstKisiler.Items.Add(item.Yaz());
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.IncludeFields = true;
            options.WriteIndented = true;

            string json = JsonSerializer.Serialize<List<Kisi>>(kisiler, options);
            string path = Application.StartupPath + "\\data.json";

            File.WriteAllText(path, json);

            MessageBox.Show("Dosya kaydedildi.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.IncludeFields = true;
            options.WriteIndented = true;

            string path = Application.StartupPath + "\\data.json";
            string json = File.ReadAllText(path);

            List<Kisi> liste = JsonSerializer.Deserialize<List<Kisi>>(json, options);
            kisiler = liste;

            lstKisiler.Items.Clear();

            foreach (Kisi item in kisiler)
            {
                lstKisiler.Items.Add(item.Yaz());
            }
        }
    }
}
