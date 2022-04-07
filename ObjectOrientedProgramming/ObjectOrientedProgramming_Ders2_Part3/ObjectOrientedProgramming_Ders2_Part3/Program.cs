using System;

namespace ObjectOrientedProgramming_Ders2_Part3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kategori.Ad = "Elektronik";
            Kategori.UrunAdedi = 10;
            Kategori.BilgiVer();
            Kategori.BilgiVer(true);

            Console.WriteLine("Hello World!");
        }
    }   
}
