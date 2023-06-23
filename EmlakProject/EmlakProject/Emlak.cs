using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmlakProject.Adresler;
using EmlakProject.Musteriler;

namespace EmlakProject
{
    public class Emlak
    {
        public long Id;
        public decimal M2;
        public DateTime IlanTarihi;
        public Adres Adres;
        public double Fiyat;
        public Musteri Musteri;

        public Emlak()
        {
            Kontrol();
        }

        public Emlak(long id, decimal m2, DateTime ilanTarihi, Adres adres, double fiyat, Musteri musteri)
        {
            Id = id;
            M2 = m2;
            IlanTarihi = ilanTarihi;
            Adres = adres;
            Fiyat = fiyat;
            Musteri = musteri;

            Kontrol();
        }

        public void Kontrol()
        {
            if (M2 <= 0 || Fiyat<=0 )
            {
                throw new Exception("Tüm kısımları doldurduğunuzdan emin olun!");
            }
        }

        public override string ToString()
        {
            return $"{IlanTarihi} {Adres} {Fiyat} {Musteri}";
        }

    }

    public class KiralikEmlakBilgileri
    {
        public decimal Deposito;
        public int KontratSuresi;
        public string Kefil;

        public KiralikEmlakBilgileri(decimal deposito, int kontratSuresi, string kefil)
        {
            Deposito = deposito;
            KontratSuresi = kontratSuresi;
            Kefil = kefil;
        }

        public override string ToString()
        {
            return $"Deposito : {Deposito} \nKontrat Süresi : {KontratSuresi} \nKefil İsim/Soyisim : {Kefil}";
        }
    }
}
