using System;

namespace ObjectOrientedProgramming_Ders3_Part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EkranaYaz("Merhaba Dünya!", Renk.Mavi);
            EkranaYaz("Hello World", Renk.Sari);
            EkranaYaz("Hello World 2", ConsoleColor.Magenta);
            EkranaYaz("Hello World 3", ConsoleColor.Cyan);

            Renk renk = Renk.Sari;
            int i = (int)renk;                      // 10

            string enumStr = renk.ToString();       // Sari
            string enumStr2 = Renk.Mavi.ToString(); // Mavi

            EkranaYaz("Hello World", renk);

            Hesapla(0, 1, 2, "baslik", 3, 4);

            HesaplaParametreleri hesaplaParametreleri = new HesaplaParametreleri();
            hesaplaParametreleri.kenarA = 10;
            hesaplaParametreleri.maxDeger = 2;
            hesaplaParametreleri.minDeger = 3;
            hesaplaParametreleri.aci = 10;
            hesaplaParametreleri.boyut = 11;
            hesaplaParametreleri.baslik = "test";

            //HesaplaParametreleri hesaplaParametreleri = new HesaplaParametreleri(10,1,2,"testt",3,4);


            Hesapla(hesaplaParametreleri);
        }

        static void EkranaYaz(string s, Renk renk)
        {
            switch (renk)
            {
                case Renk.Sari:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case Renk.Kirmizi:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case Renk.Mavi:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                default:
                    break;
            }

            Console.WriteLine(s);
            Console.ResetColor();
        }

        static void EkranaYaz(string s, ConsoleColor renk)
        {
            Console.ForegroundColor = renk;
            Console.WriteLine(s);
            Console.ResetColor();
        }

        static decimal Hesapla(int kenarA, decimal boyut, int aci, string baslik, int minDeger, int maxDeger)
        {
            Console.WriteLine("Hesapla metodu v1 çalıştı.");
            return 0;
        }

        static decimal Hesapla(HesaplaParametreleri parametreler)
        {
            Console.WriteLine("Hesapla metodu v2 çalıştı.");
            decimal result = parametreler.aci * parametreler.kenarA / parametreler.minDeger;
            return 0;
        }

    }

    public struct HesaplaParametreleri
    {
        public int kenarA;
        public int boyut;
        public int aci;
        public string baslik;
        public int minDeger;
        public int maxDeger;


        //public HesaplaParametreleri()
        //{
        //    kenarA = 0;
        //    boyut = 0;
        //    aci = 0;
        //    baslik = "";
        //    minDeger = 0;
        //    maxDeger = 0;
        //}

        public HesaplaParametreleri(int _kenarA, int _boyut, int _aci, string _baslik, int _minDeger, int _maxDeger)
        {
            kenarA = _kenarA;
            boyut = _boyut;
            aci = _aci;
            baslik = _baslik;
            minDeger = _minDeger;
            maxDeger = _maxDeger;
        }
    }

    public enum Renk
    {
        Sari = 10,
        Kirmizi = 15,
        Mavi = 20
    }
}
