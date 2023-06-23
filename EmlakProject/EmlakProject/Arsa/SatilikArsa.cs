using EmlakProject.Adresler;
using EmlakProject.Musteriler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakProject.Arsa
{
    public class SatilikArsa : Arsa
    {
        public SatilikArsa(long id, decimal m2, DateTime ilanTarihi, Adres adres, double fiyat, Musteri musteri) : base(id, m2, ilanTarihi, adres, fiyat, musteri)
        {
        }
    }
}
