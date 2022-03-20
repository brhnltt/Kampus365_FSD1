using System;

namespace ConsoleProgramming_Ders2_Part3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int sayac = 0; sayac < 10; sayac++)
            //{
            //    //if (sayac == 5) continue;

            //    Console.WriteLine("Sayaç : " + (sayac + 1));

            //    //if (sayac == 3) break;
            //}





            //Console.Write("Lütfen ürün adedi giriniz : ");
            //int adet = int.Parse(Console.ReadLine());

            //for (int i = 0; i < adet; i++)
            //{
            //    //if(i % 3 == 0)
            //    //{
            //    //    Console.WriteLine("BOM");
            //    //}
            //    //else
            //    //{
            //    //    Console.WriteLine(i);
            //    //}

            //    Console.Write((i + 1) + ". ürün : ");   // 1. ürün : 
            //    Console.ReadLine();
            //}




            //int k = 0;

            //while (k < 10)
            //{
            //    Console.WriteLine((k + 1) + ". döngü");

            //    // k = k + 1;
            //    k++;

            //    if (k == 5) break;
            //}

            //Console.WriteLine();
            //Console.WriteLine();


            //int j = 0;

            //do
            //{
            //    Console.WriteLine((j + 1) + ". döngü");
            //    j++;

            //    if (j == 7) break;

            //} while (j < 10);






            //int sayi = 10;
            //int[] sayilar = new int[3];

            //sayilar[0] = 5;
            //sayilar[1] = 18;
            //sayilar[2] = 20;





            Console.Write("Lütfen ürün adedi giriniz : ");
            int adet = int.Parse(Console.ReadLine());

            string[] urunler = new string[adet];

            //for (int i = 0; i < urunler.Length; i++)
            for (int i = 0; i < adet; i++)
            {
                Console.Write((i + 1) + ". ürün : ");
                urunler[i] = Console.ReadLine();
            }

            Console.Clear();

            Console.WriteLine("  ÜRÜNLER  ");
            Console.WriteLine("===========");
            Console.WriteLine();

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i]);
            }


            //Console.WriteLine();
            //Console.WriteLine("Lütfen kapamak için bir tuşa basınız...");
            //Console.ReadKey();
        }
    }
}
