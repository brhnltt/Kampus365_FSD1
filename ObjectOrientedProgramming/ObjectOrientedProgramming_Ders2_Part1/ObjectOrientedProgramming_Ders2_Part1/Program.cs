using System;

namespace ObjectOrientedProgramming_Ders2_Part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            musteri.Ad = "Murat";
            musteri.Soyad = "Başeren";


            Console.Write("Yaşınızı giriniz : ");
            int yas = int.Parse(Console.ReadLine());

            //if(yas < 18)
            //{
            //    throw new Exception("Yaş 18 den küçük olamaz!");
            //}

            musteri.Yas = yas;
            musteri.Yas = yas + 1;
            musteri.Yas = yas - 10;
            musteri.Yas = yas - 20;




            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " : " + musteri.Yas);
            Console.WriteLine(musteri.BilgiVer());
        }
    }


    public class Musteri
    {
        //public string Ad;
        //public string Soyad;
        //public int Yas;

        //private string _Ad;

        //public string Ad
        //{
        //    get
        //    {
        //        return _Ad;
        //    }

        //    set
        //    {
        //        _Ad = value;
        //    }
        //}


        public string Ad { get; set; }
        public string Soyad { get; set; }





        private int _Yas;

        public int Yas
        {
            get
            {
                return _Yas;
            }

            set
            {
                if (value < 18)
                {
                    throw new Exception("Yaş 18 den küçük olamaz!");
                }

                _Yas = value;
            }
        }


        public string BilgiVer()
        {
            string sonuc = Ad + " " + Soyad + " : " + Yas;
            return sonuc;
        }
    }




}
