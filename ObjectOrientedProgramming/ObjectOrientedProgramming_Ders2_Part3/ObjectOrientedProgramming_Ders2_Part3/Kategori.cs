using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming_Ders2_Part3
{
    static class Kategori
    {
        public static string Ad;

        public static int UrunAdedi { get; set; }

        public static void BilgiVer()
        {
            Console.WriteLine(Ad + " : " + UrunAdedi);
        }

        public static string BilgiVer(bool trueOrFalse)
        {
            return Ad + " : " + UrunAdedi;
        }
    }
}
