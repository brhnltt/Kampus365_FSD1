using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming_Ders1_Part3
{
    class Kare
    {
        public int KenarA { get; set; }

        protected void KenarADegerYaz()
        {
            Console.WriteLine("Kenar A : " + KenarA);
        }
    }

    class Dikdortgen : Kare
    {
        public int KenarB { get; set; }

        public void KenarBDegerYaz()
        {
            Console.WriteLine("Kenar B : " + KenarB);
        }

        public void TumKenarlariYaz()
        {
            //KenarADegerYaz();
            base.KenarADegerYaz();
            KenarBDegerYaz();
        }
    }

    class Ucgen:Dikdortgen
    {
        public int KenarC { get; set; }

        public void KenarCDegerYaz()
        {
            Console.WriteLine("Kenar C : " + KenarC);
        }
    }
}
