using System;

namespace ConsoleProgramming_Ders2_Part2
{
    internal class Program
    {
        // Compiling Hatalar
        // Runtime Hatalar
        // Logical Hatalar

        static void Main(string[] args)
        {
            Console.Write("Adınız : ");
            string adi = Console.ReadLine();

            Console.Write("Soyadınız : ");
            string soyad = Console.ReadLine();

            Console.Write("Yaş : ");
            string yas = Console.ReadLine();

            int yasInt = 0;


            try
            {
                Console.WriteLine("Yaş değeriniz int e dönüştürülüyor.");
                yasInt = int.Parse(yas);

                if (yasInt <= 0)
                {
                    throw new Exception("Lütfen geçerli bir yaş değeri giriniz. Programı yeninden başlatınız.");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine("Hata oluştu.");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Yaşı doğru formatta girmediniz. Programı tekrar çalıştırınız.");

                Console.ResetColor();
            }

            if (yasInt > 18)
            {
                Console.WriteLine("18 den büyük");
            }
            else if (yasInt == 18)
            {
                Console.WriteLine("18 e eşit");
            }
            else
            {
                Console.WriteLine("18 den küçük");
            }



            Console.WriteLine();
            Console.WriteLine(adi + " " + soyad);
        }
    }
}
