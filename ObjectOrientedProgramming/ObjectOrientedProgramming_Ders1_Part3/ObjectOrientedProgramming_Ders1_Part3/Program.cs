using System;

namespace ObjectOrientedProgramming_Ders1_Part3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kare kare = new Kare();
            

            Dikdortgen dikdortgen = new Dikdortgen();
            dikdortgen.TumKenarlariYaz();

            Kare dikdortgen2 = new Dikdortgen();
            dikdortgen2.KenarA = 3;

            Dikdortgen dd = (Dikdortgen)dikdortgen2;
            dd.TumKenarlariYaz();
        }
    }
}
