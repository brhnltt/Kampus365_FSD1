using System;

namespace ConsoleProgramming_Ders2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int sayi = 1; 
            //string metin = "asdad";

            //Random rastgele = new Random();
            //int rastgeleSayi = rastgele.Next(25, 50);

            //rastgeleSayi = rastgeleSayi + 2;
            //Console.WriteLine(rastgeleSayi);

            Console.Write("Adınız : ");
            string adi = Console.ReadLine();
            Console.Write("Soyadınız : ");
            string soyad = Console.ReadLine();
            Console.Write("Yaşınız : ");
            string yasStr = Console.ReadLine(); // "30"
            int yas = int.Parse(yasStr);        // 30

            //yas = yas + 1;
            //yas += 1;
            //yas++;

            //yas = yas - 1;
            //yas -= 1;
            //yas--;

            //string yasStr2 = yas.ToString();    // "30"

            //yas++;
            //yas += 2;

            Console.WriteLine();
            Console.WriteLine(adi + " " + soyad + " (" + yas + ")");

            
            if (yas < 18)
            {
                Console.WriteLine("Yaşınız 18 den küçüktür.");
            }
            else if (yas == 18)
            {
                Console.WriteLine("Yaşınız 18 dir.");
            }
            else
            {
                Console.WriteLine("Yaşınız 18 den büyüktür.");
            }



            //if(yas < 18)
            //{
            //    Console.WriteLine("Yaşınız 18 den küçüktür.");
            //}
            //else
            //{
            //    if (yas == 18)
            //    {
            //        Console.WriteLine("Yaşınız 18 dir.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Yaşınız 18 den büyüktür.");
            //    }
            //}


            if(yas < 18 && yas > 15)
            {
                // iki tarafında doğru olması durumunda çalışır.
            }

            if (yas > 25 || yas < 18)
            {
                // iki tarafdan birinin doğru olması durumunda çalışır.
            }


            // Ternary Operator (?:)

            string mesaj = (yas >= 18) ? "Yaş 18 ve üstü." : "Yaş 18 den küçük.";

            Console.WriteLine(mesaj);

            //int deger = (adi == "Murat") ? 1 : 0;


            //int deger = -1;

            //if(adi == "Murat")
            //{
            //    deger = 1;
            //}
            //else
            //{
            //    deger = 0;
            //}



            if (yas > 18) 
                Console.WriteLine("yaş büyük 18.");
            else
                Console.WriteLine("yaş küçük ya da eşit 18.");



            switch (yas)
            {
                case 18:
                    Console.WriteLine("Yaş 18 dir.");
                    break;

                case 23:
                case 24:
                case 25:
                    Console.WriteLine("Yaş 25 dir.");
                    break;

                default:
                    Console.WriteLine("Hiç biri değil.");
                    break;
            }



            switch (adi)
            {
                case "Murat":
                    Console.WriteLine("Merhaba Murat");
                    break;

                case "Nazım":
                    Console.WriteLine("Merhaba Nazım");
                    break;

                default:
                    Console.WriteLine("Merhaba anonim kişi");
                    break;
            }
           
        }
    }
}
