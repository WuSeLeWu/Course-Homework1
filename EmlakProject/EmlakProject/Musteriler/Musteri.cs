using EmlakProject.Adresler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakProject.Musteriler
{
    public class Musteri
    {
        public long Id;
        public string Isim;
        public string Soyisim;
        public IletisimBilgileri IletisimBilgileri;

        
        public Musteri()
        {
            Kontrol();
        }
        public Musteri(long ıd, string isim, string soyisim, IletisimBilgileri ıletisimBilgileri)
        {
            Id = ıd;
            Isim = isim;
            Soyisim = soyisim;
            IletisimBilgileri = ıletisimBilgileri;
            Kontrol();
        }

        public void Kontrol()
        {
            if (string.IsNullOrEmpty(Isim) || string.IsNullOrEmpty(Soyisim))
            {

                throw new Exception("Bahçe M2'si 0'dan küçük olamaz!");
            }
        }

        public override string ToString()
        {
            return $"{Isim} {Soyisim} {IletisimBilgileri}";
        }
    }

    
}
