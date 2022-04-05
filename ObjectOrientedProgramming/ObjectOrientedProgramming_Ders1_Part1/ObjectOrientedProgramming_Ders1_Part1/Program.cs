using System;
using System.IO;

namespace ObjectOrientedProgramming_Ders1_Part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EPostaUygulamasi ePostaUygulamasi = new EPostaUygulamasi();
            //ePostaUygulamasi.EPostaGonder("", "", "", "");
            //ePostaUygulamasi.list.Add("abc");

            //int sayi = 0;
            //bool varmi = true;
            //decimal fiyat = 10;
            //double dd = 20;
            //float f = 10;
            //char c = 'A';
            

            Araba arac1 = new Araba();
            arac1.Markasi = "Opel";
            arac1.Renk = "Beyaz";
            arac1.HibritMi = false;
            arac1.Fiyati = 100;
            arac1.KapiSayisi = 4;
            arac1.Boya("Opak Beyaz");

            //arac1.SetTekerlekSayisi(3);
            //Console.WriteLine(arac1.GetTekerlekSayisi());

            arac1.TekerlekSayisi = 3;
            Console.WriteLine(arac1.TekerlekSayisi);





            Araba arac2 = new Araba();
            arac2.Markasi = "Audi";
            arac2.Renk = "Kırmızı";
            arac2.HibritMi = true;
            arac2.Fiyati = 200;
            arac2.KapiSayisi = 4;
            arac2.TekerlekSayisi = 3;

            Araba arac3 = new Araba();
            arac3.Renk = "Mavi";

            Console.WriteLine(arac1.Renk);
            Console.WriteLine(arac2.Renk);
            Console.WriteLine(arac3.Renk);

            

        }
    }
}
