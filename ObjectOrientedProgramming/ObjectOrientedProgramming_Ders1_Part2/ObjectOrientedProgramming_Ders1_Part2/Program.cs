using System;

namespace ObjectOrientedProgramming_Ders1_Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MyKonsol myKonsol = new MyKonsol();
            //myKonsol.HelloWorldYaz();

            MyKonsol.HelloWorldYaz();


            MyKonsol myKonsol = new MyKonsol("Murat", "Başeren");
            myKonsol.AdSoyadYaz();
        }
    }
}
