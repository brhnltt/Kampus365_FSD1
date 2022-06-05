using System;

namespace WebApplication1.Models.Pages
{
    public class Index2ViewModel:IDisposable
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }
        public bool Aktif { get; set; }

        public void Dispose()
        {
            //Ad = String.Empty;
            //Soyad = String.Empty;
            //Yas = 0;
            //Aktif = false;
        }
    }
}
