using System;

namespace ObjectOrientedProgramming_Ders2_Part4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public abstract class Calisan
    {
        public string AdSoyad { get; set; }

        public virtual void BilgiYaz()
        {
            Console.WriteLine("Çalışan : " + AdSoyad);
        }
    }

    public class Personel : Calisan
    {
        public string Bolumu { get; set; }

        public override void BilgiYaz()
        {
            //base.BilgiYaz();
            Console.WriteLine("Personel : " + AdSoyad + " " + Bolumu);
        }
    }


}
