using EmlakProject.Adresler;
using EmlakProject.Musteriler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakProject.Konutlar
{
    public class SatilikVilla : Villa
    {
        public SatilikVilla(string cephe, string odaSayisi, int binaYasi, long id, decimal m2, DateTime ilanTarihi, Adres adres, double fiyat, Musteri musteri)
            : base(cephe, odaSayisi, binaYasi, id, m2, ilanTarihi, adres, fiyat, musteri)
        {

        }
    }
}
