using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(Gunler.Pazar);
            System.Console.WriteLine((int)Gunler.Cumartesi);
            int sicaklik=32;
            if(sicaklik <= (int)HavaDurumu.Normal)
            {
                System.Console.WriteLine("Dışarıya çıkmak için havanın biraz daha ısınmasını bekleyelim.");
            }
            else if (sicaklik>=(int)HavaDurumu.Sicak)
            {
                System.Console.WriteLine("Dışarıya çıkmak için çok sıcak bir gün!");
            }
            else if(sicaklik>=(int)HavaDurumu.Normal && sicaklik<=(int)HavaDurumu.CokSicak)
            System.Console.WriteLine("Hadi dışarıya çıkalım!");
        }

        enum Gunler   // ardisik kullanim
        {
            Pazartesi=1,    // 1 atamazsak default olarak index degerini 0 alir
            Sali,           // pazartesi'ye 1 ataninca Sali gunu 2 degerini aldi otomatik olarak
            Carsamba,
            Persembe,
            Cuma=23,   
            Cumartesi,     // cuma 23  olunca cumartesi 24 olur
            Pazar
        }

        enum HavaDurumu    // ardisik olmayan
        {
            Soguk=5,
            Normal=20,
            Sicak=25,
            CokSicak=30
        }
    }

}
