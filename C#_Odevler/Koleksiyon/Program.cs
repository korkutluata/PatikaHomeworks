using System;
using System.Collections.Generic;

namespace Koleksiyon
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T> class
            //System.Collections.Generic
            //T-> object türündedir.

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sari");
            renkListesi.Add("Yeşil");

            //Count
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            //foreach ve List.ForEach ile ekranlara erişim
            foreach (var sayi in sayiListesi)
                Console.WriteLine(sayi);

            foreach (var renk in renkListesi)
                Console.WriteLine(renk);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Listeden eleman çıkarma
            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));


            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Liste içerisinde arama
            if (sayiListesi.Contains(10))
            {
                Console.WriteLine("10 Liste içerisinde bulundu!");
            }

            //Eleman ile index'e erişme
            Console.WriteLine(renkListesi.BinarySearch("Sari"));

            //Diziyi List'e çevirme
            string[] hayvanlar = { "kedi", "köpek", "kuş" };
            List<string> hayvanListesi = new List<string>(hayvanlar);

            //listeyi nasıl temizleriz
            hayvanListesi.Clear();

            //List içerisinde nesne tutmak
            List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();
            Kullanicilar kullanici1 = new Kullanicilar();
            kullanici1.Isim = "Korkut";
            kullanici1.Soyisim = "Kutluata";
            kullanici1.Yas = 49;

            Kullanicilar kullanici2 = new Kullanicilar();
            kullanici2.Isim = "Okan";
            kullanici2.Soyisim = "Aydin";
            kullanici2.Yas = 38;

            kullaniciListesi.Add(kullanici1);
            kullaniciListesi.Add(kullanici2);

            List<Kullanicilar> yeniListe = new List<Kullanicilar>();
            yeniListe.Add(new Kullanicilar
            {
                Isim = "Yigit",
                Soyisim = "Gursoy",
                Yas = 10
            });

            foreach (var kullanici in kullaniciListesi)
            {
                Console.WriteLine("Kullanici Adi: " + kullanici.Isim);
                Console.WriteLine("Kullanici Soyadı: " + kullanici.Soyisim);
                Console.WriteLine("Kullanici Yasi: " + kullanici.Yas);
            }

            yeniListe.Clear();
        }
    }

    public class Kullanicilar
    {
        private string isim;
        private string soyisim;
        private int yas;
        public string Isim { get => isim; set => isim = value; }   // encapsulation islemi 
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}
