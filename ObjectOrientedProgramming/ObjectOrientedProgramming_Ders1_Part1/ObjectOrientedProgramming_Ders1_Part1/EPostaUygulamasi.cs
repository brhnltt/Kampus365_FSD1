using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming_Ders1_Part1
{
    internal class EPostaUygulamasi
    {
        // fields..
        public List<string> list = new List<string>();

        // Constructors
        public EPostaUygulamasi()
        {
            
        }


        // Methods
        public void EPostaGonder(string kimden, string kime, string konu, string metin)
        {
            // E-posta gönderme kodları
            EPostaIcerikOku();
        }

        private string EPostaIcerikOku()
        {
            // E-posta okuma kodları

            return "";
        }
    }
}
