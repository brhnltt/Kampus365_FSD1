using System;

namespace MyFirstConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string isim = "Kampüs 365";
            int sayi1 = 10;
            decimal para = 100.20m;
            double para2 = 10.5;
            float para3 = 5.4f;
            char karakter = 'a';
            bool evetMi = true;
            bool evetMi2 = false;

            //Console.WriteLine("Hello World!");
            //Console.Write("Hello World!");
            //Console.Write("Hello World!");

            int toplam = 4 + 5;
            int toplam2 = sayi1 + 3 + 6 + 4;
            int fark = 5 - 3;
            int carpim = 3 * 2;
            int bolum = 4 / 2;
            int kalan = 5 % 3;

            //Console.WriteLine(toplam);

            //string ekrandanOkunan = Console.ReadLine();
            //Console.WriteLine(ekrandanOkunan);




            //string yasStr = Console.ReadLine();
            //int yas = int.Parse(yasStr);

            //int yas2 = yas + 10;
            //Console.WriteLine(yas2);



            Console.Write("Lütfen yaşınızı giriniz : ");
            string ageStr = Console.ReadLine();
            int age = int.Parse(ageStr);
            int age2 = age + 10;

            Console.Write("Lütfen adınızı yazınız : ");
            string name = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine(name + " " + age2 + " yaşındadır.");


            // comment - yorum bloğu

            //Console.Beep();
            //Console.Beep(100, 2000);

        }
    }
}
