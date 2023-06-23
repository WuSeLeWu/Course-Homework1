using EmlakProject.Adresler;
using EmlakProject.Musteriler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakProject.Konutlar
{
    public class Villa : Konut
    {
        public double BahceM2;

        public Villa(double bahceM2, string cephe, string odaSayisi, int binaYasi, long id, decimal m2, DateTime ilanTarihi, Adres adres, double fiyat, Musteri musteri)
            :base(cephe, odaSayisi, binaYasi, id, m2, ilanTarihi, adres, fiyat, musteri)
        {
            BahceM2 = bahceM2;
            Kontrol();
        }

        public Villa()
        {

        }

        public Villa(string cephe, string odaSayisi, int binaYasi, long id, decimal m2, DateTime ilanTarihi, Adres adres, double fiyat, Musteri musteri)
            : base(cephe, odaSayisi, binaYasi, id, m2, ilanTarihi, adres, fiyat, musteri)
        {
            Kontrol();
        }

        public void Kontrol()
        {
            if (BahceM2 < 0)
            {

                throw new Exception("Bahçe M2'si 0'dan küçük olamaz!");
            }
        }
    }
}
