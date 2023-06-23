using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakProject.Musteriler
{
    public class IletisimBilgileri
    {
        public string Email;
        public string TelNo;

        public IletisimBilgileri()
        {
            Kontrol();
        }
        public IletisimBilgileri(string email, string telNo)
        {
            Email = email;
            TelNo = telNo;
            Kontrol();
        }

        public void Kontrol()
        {
            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(TelNo) || !(TelNo.Length == 10))
            {
                throw new Exception("Tüm kısımları doldurduğunuzdan emin olun!");
            }
        }

        public override string ToString()
        {
            return $"{Email} {TelNo}";
        }
    }
}
