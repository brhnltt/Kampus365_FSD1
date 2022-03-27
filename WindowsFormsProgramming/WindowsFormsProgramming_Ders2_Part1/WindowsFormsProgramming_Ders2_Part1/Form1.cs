using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsProgramming_Ders2_Part1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void test()
        {
            int sayi = 9;

            ArrayList dizi = new ArrayList();
            dizi.Add(11);
            dizi.Add(10);
            dizi.Add(8);
            dizi.Add(5);
            dizi.Add(12);
            dizi.Add(2);
            dizi.Add("asdda");


            //dizi[2] = "qwewqe";

            foreach (int item in dizi)
            {

            }


            List<string> dizi2 = new List<string>();
            dizi2.Add("asd");

            foreach (string item in dizi2)
            {

            }
        }

    }
}
