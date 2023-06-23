using EmlakProject.Adresler;
using EmlakProject.Musteriler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakProject.Konutlar
{
    public class Konut : Emlak
    {
        public string Cephe;
        public string OdaSayisi;
        public int BinaYasi;

        public Konut(string cephe, string odaSayisi, int binaYasi, long id, decimal m2, DateTime ilanTarihi, Adres adres, double fiyat, Musteri musteri)
            : base(id, m2, ilanTarihi, adres, fiyat, musteri)
        {
            Cephe = cephe;
            OdaSayisi = odaSayisi;
            BinaYasi = binaYasi;
            Kontrol();
        }

        public Konut()
        {
            Kontrol();
        }

        public void Kontrol()
        {
            if (string.IsNullOrEmpty(Cephe) || string.IsNullOrEmpty(OdaSayisi) || BinaYasi < 0)
            {

                throw new Exception("Tüm kısımları doldurduğunuzdan emin olun!");
            }
        }

        public override string ToString()
        {
            return $"Konut Cephesi : {Cephe} \nKonut Oda Sayısı : {OdaSayisi} \nBina Yasi : {BinaYasi} \nAdres : {Adres} \n{Musteri} \n{IlanTarihi}";
        }
    }
}
