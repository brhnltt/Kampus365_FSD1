using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming_Ders1_Part2
{
    internal class MyKonsol
    {
        public static int VarsayilanDeger = 5;

        public static void HelloWorldYaz()
        {
            
            Console.WriteLine("Hello World!");
        }


        private string Ad;
        private string Soyad;

        public MyKonsol(string ad, string soyad)
        {
            Ad = ad;
            Soyad = soyad;
        }

        public void AdSoyadYaz()
        {
            //HelloWorldYaz();
            Console.WriteLine(Ad + " " + Soyad);
        }
    }
}
