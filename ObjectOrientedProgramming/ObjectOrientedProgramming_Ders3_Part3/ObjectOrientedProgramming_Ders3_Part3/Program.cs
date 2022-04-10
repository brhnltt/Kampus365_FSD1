using System;
using System.Collections.Generic;

namespace ObjectOrientedProgramming_Ders3_Part3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KeyValuePair<string, int> urun = new KeyValuePair<string, int>("Elma", 10);
            Console.WriteLine(urun.Key + " : " + urun.Value);

            Kutu<string, decimal> kutu1 = new Kutu<string, decimal>();
            kutu1.Adi = "Elma Kutusu";
            kutu1.Adedi = 20;

            Kutu<string, bool> kutu2 = new Kutu<string, bool>();
            kutu2.Adi = "ElmaVarmi";
            kutu2.Adedi = true;

            Kutu<int, string> kutu3 = new Kutu<int, string>(34, "10 kutu");

        }
    }

    public class Kutu<TAdi, TAdedi>
    {
        public TAdi Adi { get; set; }
        public TAdedi Adedi { get; set; }

        public Kutu()
        {

        }

        public Kutu(TAdi adi, TAdedi adedi)
        {
            Adi = adi;
            Adedi = adedi;
        }
    }
}
