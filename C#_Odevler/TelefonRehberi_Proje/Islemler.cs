using System;
using System.Collections.Generic;

namespace TelefonRehberi_Proje
{
    static class Islemler
    {
        public static void Listele(List<Person> phoneBook)
        {
            foreach (var item in phoneBook)
            {
                Console.WriteLine($"İsim: {item.Name}");
                Console.WriteLine($"Soyisim: {item.SurName}");
                Console.WriteLine($"Telefon Numarası: {item.PhoneNumber}");
                Console.WriteLine("-");
            }
        }
        public static void AcilisEkrani()
        {
            Console.Clear();
            Console.WriteLine("**************  MENÜ  *****************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncellemek");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");
            Console.Write("Lütfen yapmak istediğiniz işlemi seçiniz : ");
        }
        public static void Baslat(List<Person> phoneBook)
        {
            AcilisEkrani();
            string secim = Console.ReadLine();
            switch (secim)
            {
                case "1":
                    EklemeIslemi(phoneBook);
                    break;
                case "2":
                    SilmeIslemi(phoneBook);
                    break;
                case "3":
                    GuncellemeIslemi(phoneBook);
                    break;
                case "4":
                    RehberiListele(phoneBook);
                    break;
                case "5":
                    RehberdeAra(phoneBook);
                    break;
                default:
                    break;
            }
        }

        public static List<Person> Ara(List<Person> phoneBook, string kriter)
        {
            List<Person> bulunanlar = phoneBook.FindAll(x => x.Name == kriter || x.SurName == kriter || x.PhoneNumber == kriter);
            return bulunanlar;
        }

        public static void EklemeIslemi(List<Person> phoneBook)
        {
            Console.Clear();
            Console.Write("Lütfen isim giriniz : ");
            string name = Console.ReadLine();
            Console.Write("Lütfen soyisim giriniz : ");
            string surName = Console.ReadLine();
            Console.Write("Lütfen telefon numarası giriniz : ");
            string phoneNumber = Console.ReadLine();
            Person person = new()
            {
                Name = name,
                SurName = surName,
                PhoneNumber = phoneNumber
            };
            phoneBook.Add(person);
            Console.WriteLine($"{name} {surName} isimli kişinin kaydı yapılmıştır ");
            Console.ReadLine();
            Baslat(phoneBook);
        }

        public static void SilmeIslemi(List<Person> phoneBook)
        {
            Console.Clear();
            Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz : ");
            string kriter = Console.ReadLine();
            List<Person> bulunanlar = Islemler.Ara(phoneBook, kriter);
            if (bulunanlar.Count == 0)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için      : (2)");
                string tercih = Console.ReadLine();
                switch (tercih)
                {
                    case "1":
                        Baslat(phoneBook);
                        break;
                    case "2":
                        SilmeIslemi(phoneBook);
                        break;
                    default:
                        Console.WriteLine("Yanlış seçim yaptınız");
                        Console.ReadLine();
                        break;
                }
            }
            Console.WriteLine($"{bulunanlar[0].Name} {bulunanlar[0].SurName} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ? (y/n)");
            string karar = Console.ReadLine();
            switch (karar)
            {
                case "y":
                    phoneBook.Remove(bulunanlar[0]);
                    Console.WriteLine("silme işlemi başarıyla gerçekleşti");
                    Console.ReadLine();
                    break;
                case "n":
                    Console.WriteLine("silme işlemi iptal edildi");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Yanlış seçim yaptınız");
                    Console.ReadLine();
                    break;
            }
            Baslat(phoneBook);
        }



        public static void RehberdeAra(List<Person> phoneBook)
        {
            Console.Clear();
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("*****************************************");
            Console.WriteLine();
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
            string secim = Console.ReadLine();

            if (secim == "1")
            {
                Console.WriteLine("Lütfen aramak istediğiniz kişinin adını ya da soyadını giriniz:");
                string altSecim = Console.ReadLine();
                List<Person> bulunanlar = Ara(phoneBook, altSecim);
                if (bulunanlar.Count > 0)
                {
                    Listele(bulunanlar);
                    Console.ReadLine();
                    Baslat(phoneBook);
                }
                else
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı");
                    Console.ReadLine();
                    Baslat(phoneBook);
                }
            }
            else if (secim == "2")
            {
                Console.WriteLine("Lütfen aramak istediğiniz kişinin telefon numarasını giriniz:");
                string altSecim = Console.ReadLine();
                List<Person> bulunanlar = Ara(phoneBook, altSecim);
                if (bulunanlar.Count > 0)
                {
                    Listele(bulunanlar);
                    Console.ReadLine();
                    Baslat(phoneBook);
                }
                else
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı");
                    Console.ReadLine();
                    Baslat(phoneBook);
                }
            }
            else
            {
                Console.WriteLine("Yanlış seçim yaptınız");
                Console.ReadLine();
                RehberdeAra(phoneBook);
            }
        }

        public static void GuncellemeIslemi(List<Person> phoneBook)
        {
            Console.Clear();
            Console.WriteLine("Güncellemek istediğiniz kişinin adını veya soyadını giriniz");
            string kriter = Console.ReadLine();
            Person bulunanKisi = phoneBook.Find(x => x.Name == kriter || x.SurName == kriter);
            if (bulunanKisi == null)
            {
                Console.WriteLine("Aradiginiz kriterlere uygun kişi bulunamadı");
                Console.ReadLine();
                Baslat(phoneBook);
            }
            else
            {
                Console.Write($"{bulunanKisi.Name} {bulunanKisi.SurName} isimli kisiye ait yeni numarayi giriniz : ");
                string yeniNumara = Console.ReadLine();
                bulunanKisi.PhoneNumber = yeniNumara;
                Console.WriteLine("guncelleme islemi basarili");
                Console.ReadLine();
                Baslat(phoneBook);
            }
        }
        public static void RehberiListele(List<Person> phoneBook)
        {
            Console.Clear();
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("***************************************");
            Listele(phoneBook);
            Console.ReadLine();
            Baslat(phoneBook);
        }


    }
}