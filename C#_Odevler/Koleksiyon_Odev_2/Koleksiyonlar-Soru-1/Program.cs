using System;
using System.Collections;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            for (int i = 0; i < 20; i++)
            {
                try
                {
                    Console.Write("Bir pozitif tam sayi giriniz : ");
                    int sayi = int.Parse(Console.ReadLine());
                    if (sayi > 0) { liste.Add(sayi); }
                    else { Console.WriteLine("sayi pozitif degil"); }
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("pozitif tam sayi giriniz");
                }
            }

            ArrayList asalListe = new ArrayList();
            ArrayList asalOlmayanListe = new ArrayList();
            foreach (var item in liste)
            {
                if (AsalMi((int)item))
                {
                    asalListe.Add(item);
                }
                else
                {
                    asalOlmayanListe.Add(item);
                }
            }
            Console.WriteLine("*****asal liste*****");
            asalListe.Sort();
            asalListe.Reverse();
            foreach (var item in asalListe)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"asal sayi adedi : {asalListe.Count}");
            Console.WriteLine($"asal sayilar ortalamasi : {Ortalama(asalListe)}");

            Console.WriteLine("*****asal olmayan liste*****");
            asalOlmayanListe.Sort();
            asalOlmayanListe.Reverse();
            foreach (var item in asalOlmayanListe)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"asal olmayan sayi adedi : {asalOlmayanListe.Count}");
            Console.WriteLine($"asal olmayanlarin ortalamasi : {Ortalama(asalOlmayanListe)}");
            Console.ReadLine();

        }

        static bool AsalMi(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i > 0)
                {
                    continue;
                }
                else { return false; }
            }
            return true;
        }

        static int Ortalama(ArrayList list)
        {
            int toplam = 0;
            foreach (var item in list)
            {
                toplam += (int)item;
            }
            return (toplam / list.Count);
        }
    }
}
