using System;

namespace ConsoleProgramming_Ders3_Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BaslikYaz("Merhaba Dünya!");

            //BaslikYaz("Console Programming");

            //BaslikYaz();

            //int sayi = Topla(5);
            //Console.WriteLine(sayi);



            // Array initializer..
            //int[] sayilarim = new int[] { 4, 5, 6 };

            //int toplam = Topla2(sayilarim);
            //int toplam2 = Topla2(new int[] { 4, 5, 6 });


            //int toplam = Topla3(3, 4, 5, 6, 7, 8, 9, 1, 1, 2232, 4456, 7);

            //Console.WriteLine("Toplam : " + toplam);

            // Method overloading..
            //Console.WriteLine(Birlestir("aa", "bb"));
            //Console.WriteLine(Birlestir("aa", "bb", "cc"));



            //string ad = "Murat";
            //Console.WriteLine(ad);


            //char[] karakterler = new char[5];
            //karakterler[0] = 'm';
            //karakterler[1] = 'u';
            //karakterler[2] = 'r';
            //karakterler[3] = 'a';
            //karakterler[4] = 't';

            //for (int i = 0; i < karakterler.Length; i++)
            //{
            //    Console.Write(karakterler[i]);
            //}


            //string ad = "Murat;Nihal;Bora";
            //string ad2 = ad.ToLower();

            //Console.WriteLine(ad);
            //Console.WriteLine(ad2);


           

            DateTime tarih = new DateTime(2022, 1, 30, 12, 30, 20);
            Console.WriteLine(tarih.ToShortDateString());
            Console.WriteLine(tarih.ToLongDateString());

        }



        static void BaslikYaz(string baslik = "başlık")
        {
            Console.WriteLine(baslik);

            for (int i = 0; i < baslik.Length; i++)
            {
                Console.Write("=");
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        static int Topla(int sayi1 = 0, int sayi2 = 0)
        {
            int sonuc = sayi1 + sayi2;
            return sonuc;
        }

        static int Topla2(int[] sayilar)
        {
            int sonuc = 0;

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    sonuc += sayilar[i];
            //}

            foreach (int sayi in sayilar)
            {
                sonuc += sayi;
            }

            return sonuc;
        }

        static int Topla3(params int[] sayilar)
        {
            int sonuc = 0;

            foreach (int sayi in sayilar)
            {
                sonuc += sayi;
            }

            return sonuc;
        }


        static string Birlestir(string metin1, string metin2)
        {
            string sonuc = metin1 + metin2;
            return sonuc;
        }

        static string Birlestir(string metin1, string metin2, string metin3)
        {
            string sonuc = metin1 + metin2 + metin3;
            return sonuc;
        }
    }
}
