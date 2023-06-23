using EmlakProject.Adresler;
using EmlakProject.Musteriler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakProject.Konutlar
{
    public class SatilikEv : Ev
    {
        public SatilikEv(string cephe, string odaSayisi, int binaYasi, long id, decimal m2, DateTime ilanTarihi, Adres adres, double fiyat, Musteri musteri)
            : base(cephe, odaSayisi, binaYasi, id, m2, ilanTarihi, adres, fiyat, musteri)
        {

        }

        public override string ToString()
        {
            return $"\nKonut Cephesi : {Cephe} \nSahibi : {Musteri} \nAdres : {Adres} \nOda Sayısı : {OdaSayisi} \nİlan Tarihi : {IlanTarihi} \nFiyat : {Fiyat} \nOda Sayısı :{OdaSayisi}";
        }
    }
}
