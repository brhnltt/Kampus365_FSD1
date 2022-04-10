using System;
using System.Collections.Generic;

namespace ObjectOrientedProgramming_Ders3_Part4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Listem<int> liste1 = new Listem<int>();

            List<string> liste2 = new List<string>();
            liste2.Add("asdas");



            Listem<int> liste3 = new Listem<int>();
            liste3.Ekle(10);
            liste3.Ekle(12);
            liste3.Ekle(14);

            int deger1 = liste3.Getir(0);
            int deger2 = liste3.Getir(1);

            liste3.EkranaYaz();

            liste3.EkranaYaz<string>(2, -1, "TL");  // -1 14 TL
            //liste3.EkranaYaz(2, -1, "TL");  // -1 14 TL
        }
    }


    public class Listem<T>
    {
        private T[] _dizi = new T[0];


        public void Ekle(T item)
        {
            Array.Resize(ref _dizi, _dizi.Length + 1);
            _dizi[_dizi.Length - 1] = item;
        }

        public T Getir(int index)
        {
            return _dizi[index];
        }

        public void EkranaYaz()
        {
            for (int i = 0; i < _dizi.Length; i++)
            {
                Console.WriteLine(_dizi[i]);
            }
        }

        public void EkranaYaz<TSuffix>(int index, T prefix, TSuffix suffix)
        {
            Console.Write(prefix + " ");
            Console.Write(_dizi[index]);
            Console.WriteLine(" " + suffix);
        }
    }
}
