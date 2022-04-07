using System;

namespace ObjectOrientedProgramming_Ders2_Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kategori kategori = new Kategori();
            kategori.Adi = "Elektronik";

            //Calisan calisan1 = new Calisan();

            MaviYakali maviYakali = new MaviYakali();
            maviYakali.CalismaSaati = 10;
            //maviYakali.Ad = "John";
            //maviYakali.Soyad = "Doe";
            //maviYakali.BilgiVer();
            CalisanBilgiGoster(maviYakali);


            BeyazYakali beyazYakali = new BeyazYakali();
            beyazYakali.Departman = "Insan Kaynakları";
            //beyazYakali.Ad = "John";
            //beyazYakali.Soyad = "Doe";
            //beyazYakali.BilgiVer();
            CalisanBilgiGoster(beyazYakali);


            Yonetici yonetici = new Yonetici();
            yonetici.BolgeKodu = 101;
            //yonetici.Ad = "John";
            //yonetici.Soyad = "Doe";
            //yonetici.BilgiVer();
            CalisanBilgiGoster(yonetici);


            GenelMudur ceo = new GenelMudur();
            ceo.Maas = 1000;
            //ceo.Ad = "John";
            //ceo.Soyad = "Doe";
            //ceo.BilgiVer();
            CalisanBilgiGoster(ceo);

            Koordinator koordinator = new Koordinator();
            CalisanBilgiGoster(koordinator);


            Console.Write("Kategori : ");
            Console.WriteLine(kategori.Adi);
        }


        static void CalisanBilgiGoster(Calisan calisan)
        {
            calisan.Ad = "John";
            calisan.Soyad = "Doe";
            calisan.BilgiVer();
        }

    }


    // miras alınamayan class oluşturur. Sadece new ile nesne oluşumu ile kullanılır.
    sealed class Kategori
    {
        public string Adi { get; set; }
    }

    abstract class Calisan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public void AdSoyadYaz()
        {
            Console.WriteLine(Ad + " " + Soyad);
        }

        public string AdSoyadYaz(bool notImportant)
        {
            string s =  Ad + " " + Soyad;
            return s;
        }

        public abstract string BilgiVer();
    }

    class BeyazYakali : Calisan
    {
        public string Departman { get; set; }

        public override string BilgiVer()
        {
            return "Beyaz Yakalı : " + Ad + " " + Soyad + " - Departman : " + Departman;
        }
    }

    class Koordinator : Calisan
    {
        public override string BilgiVer()
        {
            return "Koordinatör : " + Ad + " " + Soyad;
        }
    }

    class MaviYakali : Calisan
    {
        public int CalismaSaati { get; set; }

        public override string BilgiVer()
        {
            return "Mavi Yakalı : " + Ad + " " + Soyad + " - Çalışma Saati : " + CalismaSaati;
        }
    }

    class Yonetici : Calisan
    {
        public int BolgeKodu { get; set; }

        public override string BilgiVer()
        {
            return "Yönetici : " + Ad + " " + Soyad + " - Bölge Kodu : " + BolgeKodu;
        }
    }

    class GenelMudur : Calisan
    {
        public decimal Maas { get; set; }

        public override string BilgiVer()
        {
            return "Genel Müdür : " + Ad + " " + Soyad + " - Maaş: " + Maas;
        }
    }
}
