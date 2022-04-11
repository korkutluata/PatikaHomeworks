using System;

namespace array_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayiDizisi = {23,12,86,72,3,11,17,4};
            Console.WriteLine("********Sırasız Dizi ****");
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
            Console.WriteLine("********Sıralı Dizi ****");
            Array.Sort(sayiDizisi);         // dizi elemanlarini siralar
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
            Console.WriteLine("********Array Clear****");
            Array.Clear(sayiDizisi,2,2);         // belirtilen elemanlarin degerlerini degistirir default'a. Burada 2 nolu indexten 2 adeti sifirlar
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("********Array Reverse****");
            Array.Reverse(sayiDizisi);   // diziyi ters cevirir
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("********Array Indexof****");
            
            Console.WriteLine(Array.IndexOf(sayiDizisi,23));     // verilen elemanin index'ini doner, eleman yok ise dizide -1 doner

            Console.WriteLine("********Array Resize****");
            Array.Resize<int>(ref sayiDizisi,9);      // dizi'yi yeniden boyutlandirir,8'den 9'a cikardik burada.
            sayiDizisi[8] =99;                         // yeni eklenen index 8'e 99 yazdik
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
        }
    }
}

