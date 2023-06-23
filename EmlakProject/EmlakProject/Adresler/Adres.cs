using EmlakProject.Musteriler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakProject.Adresler
{
    public class Adres
    {
        public Semt Semt;
        public string Cadde;
        public string Sokak;
        public int BinaNo;
        public int DaireNo;

        public Adres(Semt semt, string cadde, string sokak, int binaNo, int daireNo)
        { 
            Semt = semt;
            Cadde = cadde;
            Sokak = sokak;
            BinaNo = binaNo;
            DaireNo = daireNo;
            Kontrol();

        }

        public Adres()
        {
            Kontrol();
        }

        public void Kontrol()
        {
            if (string.IsNullOrEmpty(Cadde) || string.IsNullOrEmpty(Sokak) || BinaNo < 0 || DaireNo < 0)
            {
                throw new Exception("Tüm kısımları doldurduğunuzdan emin olun!");
            }
        }

        public override string ToString()
        {
            return $"{Semt}  {Cadde}  {Sokak} {BinaNo}/{DaireNo}";
        }

        
    }
}
