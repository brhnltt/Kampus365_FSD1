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
    public partial class Form2 : Form
    {


        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> sozluk = new Dictionary<string, string>();

            sozluk.Add("table", "masa");
            sozluk.Add("kod", "code");
            sozluk.Add("code", "kod");
            sozluk.Add("masa", "table");
            sozluk.Add("masa2", "table");

            string metin = sozluk["code"];
            MessageBox.Show(metin);


            Dictionary<int, string> sozluk2 = new Dictionary<int, string>();

            sozluk2.Add(0, "asdsada");
            string abc = sozluk2[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string ad = "Murat";

            //string[] adlar = new string[2];
            //adlar[0] = "Murat";
            //adlar[1] = "Kadir";

            //List<string> adlar2 = new List<string>();
            //adlar2.Add("Murat");
            //adlar2.Add("Kadir");


            Tuple<string, string, int> tuple1 = new Tuple<string, string, int>("Murat", "Başeren", 37);
            //MessageBox.Show(tuple1.Item1);
            //MessageBox.Show(tuple1.Item2);
            //MessageBox.Show(tuple1.Item3.ToString());

            MessageBox.Show(tuple1.Item1 + " " + tuple1.Item2 + " - " + tuple1.Item3.ToString());


            (string ad, string soyad, int yas) tuple2 = ("Kadir", "Başeren", 37);

            //MessageBox.Show(tuple2.ad);
            //MessageBox.Show(tuple2.soyad);
            //MessageBox.Show(tuple2.yas.ToString());

            MessageBox.Show(tuple2.Item1 + " " + tuple2.Item2 + " - " + tuple2.Item3.ToString());
        }
    }

    //class tuple2
    //{
    //    // field..
    //    string ad;
    //    string soyad;
    //    int yas;

    //    public tuple2()
    //    {
    //        // constructor..
    //    }
    //}


}
