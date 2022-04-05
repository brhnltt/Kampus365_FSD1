using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming_Ders1_Part1
{
    internal class Araba
    {
        // fields..
        public int KapiSayisi = 0;
        public string Renk = "";
        public string Markasi = "";
        public bool HibritMi = false;
        public decimal Fiyati = 0;


        // property
        public int TekerlekSayisi { get; set; } = 4;



        //private int _TekerlekSayisi = 4;


        // property
        //public int TekerlekSayisi
        //{
        //    get
        //    {
        //        return _TekerlekSayisi;
        //    }

        //    set
        //    {
        //        if (value < 4)
        //            value = 4;

        //        _TekerlekSayisi = value;
        //    }
        //}





        //public int GetTekerlekSayisi()
        //{
        //    return _TekerlekSayisi;
        //}

        //public void SetTekerlekSayisi(int value)
        //{
        //    if (value < 4)
        //        value = 4;

        //    _TekerlekSayisi = value;
        //}



        // constructor
        public Araba()
        {
            
        }

        // method
        public void Boya(string yeniRenk)
        {
           this.Renk = yeniRenk;
        }
    }
}
