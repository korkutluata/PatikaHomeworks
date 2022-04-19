using System;

namespace Class_accessModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            //Söz Dizimi
            //class SinifAdi
            // {
            //    PROPERTY =>   [Erişim Belirleyici] [Veri Tipi] OzellikAdi;
            //    METOT    =>   [Erişim Belirleyici] [Geri Donus Tipi] MetotAdi([Parametre Listesi])
            //                  {
            //                      Metot Komutlari
            //                  }
            //}

            //Erisim Belirleyiciler
            // * Public
            // * Private : Sadece tanimlandigi sinif icerisinde erisilebilen (Propertyler)
            // * Internal : Sadece kendi bulundugu proje icerisinde degiskenlere(propertylere) ve siniflara
            // * Protected : Sadece tanimlandigi sinifta veya o siniftan kalitim alan siniflarda

            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Korkut";
            calisan1.Soyad = "Kutluata";
            calisan1.No = 1234567;
            calisan1.Departman = "Maliye";

            Console.WriteLine("********************");

            calisan1.CalisanBilgileri();

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Ege";
            calisan2.Soyad = "Sarp";
            calisan2.No = 1234568;
            calisan2.Departman = "Lojistik";

            calisan2.CalisanBilgileri();
        }
    }

    class Calisan
    {
        //Calisani tanimlayanlara propertyler deniliyor.
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;
        public void CalisanBilgileri()
        {
            Console.WriteLine("Calisan Adi: {0}", Ad);
            Console.WriteLine("Calisan Soyadi: {0}", Soyad);
            Console.WriteLine("Calisan Numarasi: {0}", No);
            Console.WriteLine("Calisan Departmani: {0}", Departman);
        }
    }
}
