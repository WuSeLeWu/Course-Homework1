using EmlakProject.Adresler;
using EmlakProject.Musteriler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakProject.Konutlar
{
    public class KiralikEv : Ev
    {
        public KiralikEmlakBilgileri KiralikEmlakBilgileri;
        public bool EvcilHayvan { get; set; }

        public KiralikEv(KiralikEmlakBilgileri kiralikEmlakBilgileri,bool evcilHayvan, string cephe, string odaSayisi, int binaYasi, long id, decimal m2, DateTime ilanTarihi, Adres adres, double fiyat, Musteri musteri)
            :base(cephe,odaSayisi,binaYasi,id,m2,ilanTarihi,adres,fiyat,musteri)
        {
            KiralikEmlakBilgileri = kiralikEmlakBilgileri;
            EvcilHayvan = evcilHayvan;
        }

        public override string ToString()
        {
            return $"Evcil Hayvan İzni :{((EvcilHayvan==true)?" Var ":" Yok ")}\nKonut Cephesi : {Cephe}\nSahibi : {Musteri} \nAdres : {Adres} \nİlan Tarihi : {IlanTarihi} \nFiyat : {Fiyat} \nOda Sayısı :{OdaSayisi} \n{KiralikEmlakBilgileri}";
        }
    }
}
