using EmlakProject;
using EmlakProject.Adresler;
using EmlakProject.Arsa;
using EmlakProject.Konutlar;
using EmlakProject.Musteriler;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Emlak> emlakList = new List<Emlak>();
        List<Musteri> musteriList = new List<Musteri>();


        Musteri musteri = new Musteri(1, "Mustafa", "Yılman", new IletisimBilgileri("mustafa@gmail.com", "5555555555"));
        Musteri musteri2 = new Musteri(2, "Veli", "Yılmaz", new IletisimBilgileri("veli@gmail.com", "4444444444"));


        //Konut konut = new Konut("Doğu", "4+1", 16, 1, 45, DateTime.Now, new Adres(new Semt("Caddebostan", 5, "Çınar", new Sehir("İstanbul", 34, "Marmara")), "Tabya Caddesi", "Tabya sokak", 22, 5), 30000000, musteri);

        Konut kiralikEv = new KiralikEv(new KiralikEmlakBilgileri(4500,2,"Mehmet Başaran"), true, "Güney", "3+1", 7, 1, 35, DateTime.Now, new Adres(new Semt("Slimkent", 5, "Buharaevler", new Sehir("Çorum", 19, "Karadeniz")), "İlhanlı Cad.", "37. Sokak", 5, 2), 14000, musteri2);
        Konut satilikEv = new SatilikEv("Doğu", "4+1", 5, 2, 40, DateTime.Now, new Adres(new Semt("Merkez", 1, "Üçtutlar", new Sehir("Çorum", 19, "Karadeniz")), "Eşref Hoca Cad.", "7. Sokak", 5, 1), 3500000, musteri);

        Konut kiralikVilla = new KiralikVilla(new KiralikEmlakBilgileri(10000,4,"Ahmet Yıldız"),"Batı", "7+2", 4, 4, 65, DateTime.Now, new Adres(new Semt("Ulus",55334,"Yeni Mahalle",new Sehir("Ankara",06,"İç Anadolu Bölgesi")),"Yahya Kemal Cad","22. Sok",5,2), 35000, musteri);
        Konut satilikVilla = new SatilikVilla("Kuzey", "6+2", 3, 2, 55, DateTime.Now, new Adres(new Semt("Köprücük",55334,"Yeni Mahalle",new Sehir("Ankara",06,"İç Anadolu Bölgesi")),"Since  Cad","2. Sok",7,3), 3500000, musteri2);


        musteriList.Add(musteri);
        musteriList.Add(musteri2);

        emlakList.Add(kiralikEv);
        emlakList.Add(satilikEv);
        emlakList.Add(kiralikVilla);
        emlakList.Add(satilikVilla);


        foreach (Emlak e in emlakList)
        {
            Console.WriteLine();
            Console.WriteLine(e);
            Console.WriteLine();
            Console.WriteLine("*********************************************");
            
        }
    }
}