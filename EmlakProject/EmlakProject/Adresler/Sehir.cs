using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakProject.Adresler
{
    public class Sehir
    {
        public string Ad;
        public int SehirNo;
        public string Bölge;

        public Sehir(string ad, int sehirNo, string bölge)
        {
            Ad = ad;
            SehirNo = sehirNo;
            Bölge = bölge;
            Kontrol();
        }

        public Sehir()
        {
            Kontrol();
        }

        public void Kontrol()
        {
            if (string.IsNullOrEmpty(Ad) || SehirNo<=0 || SehirNo>81 || Bölge.Length <= 0)
            {
                throw new Exception("Tüm kısımları doldurduğunuzdan emin olun!");
            }
        }

        public override string ToString()
        {
            return $"\nSehir Adı : {Ad}\nŞehir No : {SehirNo} \nŞehir Bölgesi : {Bölge}";
        }
    }
}
