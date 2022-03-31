using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsProgramming_Ders4_Part2
{
    public class Kisi
    {
        // fields..
        public string Ad;
        public string Soyad;
        public int Yas;

        public string Yaz()
        {
            string sonuc = Ad + " " + Soyad + " " + Yas;
            return sonuc;
        }
    }
}
