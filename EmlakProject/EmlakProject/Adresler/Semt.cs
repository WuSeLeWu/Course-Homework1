using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakProject.Adresler
{
    public class Semt
    {
        public string Ad;
        public int Kod;
        public string Mahalle;
        public Sehir Sehir;

        public Semt(string ad, int kod, string mahalle, Sehir sehir)
        {
            Ad = ad;
            Kod = kod;
            Mahalle = mahalle;
            Sehir = sehir;
            Kontrol();
        }

        public Semt()
        {
            Kontrol();
        }

        public void Kontrol()
        {
            if (string.IsNullOrEmpty(Ad) || Kod < 0 || string.IsNullOrEmpty(Mahalle))
            {
                throw new Exception("Tüm kısımları doldurduğunuzdan emin olun!");
            }
        }

        public override string ToString()
        {
            return $"{Ad} {Mahalle}";
        }
    }
}
