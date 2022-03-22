using System;

namespace ConsoleProgramming_Ders3_Part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[3];
            dizi[0] = 20;
            dizi[1] = 10;
            dizi[2] = 30;
            //dizi[3] = 40;

            Console.WriteLine("Dizi Değerleri");
            Console.WriteLine();

            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    int item = dizi[i];
            //    Console.WriteLine(i + ". item : " + item);
            //}





            //int[] tempDizi = new int[dizi.Length];

            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    tempDizi[i] = dizi[i];
            //}

            //// boxing
            //object temp = tempDizi;

            // unboxing = casting
            ////int sayi = (int)temp;



            //object cloneArray = dizi.Clone();
            //int[] dizi2 = (int[])cloneArray;


            //foreach (int item in dizi2)
            //{
            //    int i = Array.IndexOf(dizi, item);
            //    Console.WriteLine(i + ". item : " + item);
            //}


            //int[] dizi3 = new int[dizi.Length + 2];
            //dizi.CopyTo(dizi3, 2);


            //for (int i = 0; i < dizi3.Length; i++)
            //{
            //    int item = dizi3[i];
            //    Console.WriteLine(i + ". item : " + item);
            //}



            //Array.Sort(dizi);

            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    int item = dizi[i];
            //    Console.WriteLine(i + ". item : " + item);
            //}

            //Console.WriteLine();

            //Array.Reverse(dizi);

            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    int item = dizi[i];
            //    Console.WriteLine(i + ". item : " + item);
            //}


            //Array.Resize(ref dizi, dizi.Length + 1);

            //dizi[dizi.Length - 1] = 40;

            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    int item = dizi[i];
            //    Console.WriteLine(i + ". item : " + item);
            //}


            Console.WriteLine("Ürün Adet Girişi");
            Console.WriteLine("================");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Ürün adedi girerken -1 değeri girerseniz adet girişini tamamlamış olacaksınız.");
            Console.ResetColor();

            Console.WriteLine();

            int[] adetler = new int[0];
            int deger = 0;

            do
            {
                Console.Write((adetler.Length + 1) + ". ürün adedi : ");
                deger = int.Parse(Console.ReadLine());

                if(deger > -1)
                {
                    Array.Resize(ref adetler, adetler.Length + 1);
                    adetler[adetler.Length - 1] = deger;
                }

            } while (deger > -1);

            Console.WriteLine();
            Console.WriteLine();

            Array.Sort(adetler);

            Console.ForegroundColor = ConsoleColor.Cyan;
            int sayac = 0;
            foreach (int item in adetler)
            {
                //int i = Array.IndexOf(adetler, item,) + 1;
                Console.WriteLine((sayac+1) + ". ürün adedi : " + item);
                sayac++;
            }

            Console.ResetColor();
        }
    }
}
