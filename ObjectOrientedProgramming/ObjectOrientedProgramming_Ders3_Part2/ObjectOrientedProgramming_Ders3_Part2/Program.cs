using System;
using System.Collections.Generic;

namespace ObjectOrientedProgramming_Ders3_Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> sayilar = new List<int>();
            sayilar.Add(1);
            sayilar.Add(2);
            sayilar.Add(3);

            //List<ConsoleColor> consoleColors = new List<ConsoleColor>();

            Dictionary<string, string> sozluk = new Dictionary<string, string>();
            sozluk.Add("masa", "table");
            //sozluk.Add("masa", "table");
            sozluk.Add("table", "masa");

            //Tuple<int, string, bool> row = new Tuple<int, string, bool>(3, "test", true);
            (int yas, string adSoyad, bool emekliMi) parametreler = (3, "test", true);
            Console.WriteLine(parametreler.yas);

            //MyNesne myNesne = new MyNesne(3, "test", true);

            (string ad, string soyad) adSoyad = ("Murat", "Başeren");
            KeyValuePair<string, string> adSoyad2 = new KeyValuePair<string, string>("Murat", "Başeren");
        }
    }

    public class MyNesne
    {
        public int Yas;
        public string AdSoyad;
        public bool CalisiyorMu;

        public MyNesne(int yas, string adSoyad, bool calisiyorMu)
        {
            Yas = yas;
            AdSoyad = adSoyad;
            CalisiyorMu = calisiyorMu;
        }
    }
}
