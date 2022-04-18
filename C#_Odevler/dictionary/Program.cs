using System;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> kullanicilar = new Dictionary<int, string>();
            // key'in int olacagini , value'nun da string olacagini en basta belirtmis olduk
            Dictionary<char, int> deneme = new Dictionary<char, int>();
            // key => char ,  value => int olacak dedik

            kullanicilar.Add(10, "Ayse Yilmaz");
            kullanicilar.Add(12, "Ahmet Yilmaz");
            kullanicilar.Add(18, "Deniz Arda");
            kullanicilar.Add(20, "Ozcan Cosar");

            deneme.Add('a', 1);
            deneme.Add('b', 34);
            deneme.Add('A', 12);
            deneme.Add('z', 43);


            Console.WriteLine(kullanicilar[12]);
            Console.WriteLine("**********");

            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("**********");
            foreach (var item in deneme)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("**********");
            foreach (var item in deneme)
            {
                Console.WriteLine(item.Key);
            }
            Console.WriteLine("**********");
            foreach (var item in deneme)
            {
                Console.WriteLine(item.Value);
            }

            // count
            Console.WriteLine("*****Count*****");
            Console.WriteLine(kullanicilar.Count);

            // Contains
            Console.WriteLine("*****Contains*****");
            Console.WriteLine(kullanicilar.ContainsKey(12));
            Console.WriteLine(kullanicilar.ContainsValue("Ali Veli"));

            // remove
            Console.WriteLine("*****Remove*****");
            kullanicilar.Remove(12);
            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item);
            }

            // keys, value
            Console.WriteLine("*****Key*****");
            foreach (var item in kullanicilar.Keys)  // bu sekilde de kullanilabilir
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("*****Value*****");
            foreach (var item in kullanicilar)     // bu sekilde de kullanilabilir
            {
                Console.WriteLine(item.Value);
            }







            Console.ReadLine();
        }
    }
}
