using System;
using System.Collections;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            for (int i = 0; i < 20; i++)
            {
                int sayi = int.Parse(Console.ReadLine());
                list.Add(sayi);
            }
            list.Sort();
            ArrayList enKucukUcSayi = new ArrayList() { list[0], list[1], list[2] };
            list.Reverse();
            ArrayList enBuyukUcSayi = new ArrayList() { list[0], list[1], list[2] };
            Console.WriteLine("***En Buyuk Uc Sayi***");
            foreach (var item in enBuyukUcSayi)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Uc buyuk ortalamasi : {Ortalama(enBuyukUcSayi)}");
            Console.WriteLine("***En Kucuk Uc Sayi***");
            foreach (var item in enKucukUcSayi)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Uc kucuk ortalamasi : {Ortalama(enKucukUcSayi)}");
            Console.WriteLine($"Ortalamalar Toplami : {Ortalama(enBuyukUcSayi) + Ortalama(enKucukUcSayi)}");

            Console.ReadLine();
        }

        static int Ortalama(ArrayList list)
        {
            int ortalama = ((int)list[0] + (int)list[1] + (int)list[2]) / 3;
            return ortalama;
        }
    }
}
