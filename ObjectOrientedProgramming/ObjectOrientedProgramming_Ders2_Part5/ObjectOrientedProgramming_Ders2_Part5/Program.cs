using System;

namespace ObjectOrientedProgramming_Ders2_Part5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICalisan calisan1 = new Personel();
            calisan1.Ad = "John";
            calisan1.Soyad = "Doe";
            calisan1.BilgiVer();

            Console.WriteLine("Hello World!");
        }
    }



    public interface ICalisan
    {
        string Ad { get; set; }
        string Soyad { get; set; }
        void BilgiVer();
    }

    public interface IRapor
    {
        void RaporAl();
    }

    public interface IYonetici : ICalisan, IRapor
    {
        void BilgiVer(string ikinciAd);
    }


    public class Personel : ICalisan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public void BilgiVer()
        {
            throw new NotImplementedException();
        }
    }

    public class TakimLideri : ICalisan, IRapor
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public void BilgiVer()
        {
            throw new NotImplementedException();
        }

        public void RaporAl()
        {
            throw new NotImplementedException();
        }
    }


    public class Koordinator : IYonetici
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public void BilgiVer()
        {
            throw new NotImplementedException();
        }

        public void BilgiVer(string ikinciAd)
        {
            throw new NotImplementedException();
        }

        public void RaporAl()
        {
            throw new NotImplementedException();
        }
    }

    public class GenelMudur : IYonetici
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public void BilgiVer()
        {
            throw new NotImplementedException();
        }

        public void BilgiVer(string ikinciAd)
        {
            throw new NotImplementedException();
        }

        public void RaporAl()
        {
            throw new NotImplementedException();
        }
    }

}
