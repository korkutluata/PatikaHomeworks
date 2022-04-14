using System;

namespace AlgoritmaSorulari
{
    class Program
    {
        static void Main(string[] args)
        {

            // ****** ODEV 1.1 ******

            Console.Write("Lutfen cift kontrolu yapilacak sayi adedini yaziniz : ");
            int n = Convert.ToInt16(Console.ReadLine());
            int[] tumSayilar = new int[n];
            for (int i = 0; i < n; i++)
            {
                // Console.WriteLine("tum sayilar : " + tumSayilar.ToString());
                Console.Write("Lutfen cift kontrolu yapilacak bir sayi giriniz : ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                tumSayilar[i] = sayi;
            }
            int[] ciftSayilar = new int[n];
            for (int i = 0; i < tumSayilar.Length; i++)
            {
                if (tumSayilar[i] % 2 == 0)
                {
                    ciftSayilar[i] = tumSayilar[i];
                }
            }
            Console.Write("cift sayilar : ");
            for (int i = 0; i < ciftSayilar.Length; i++)
            {
                if (ciftSayilar[i] > 0)
                {
                    Console.Write($" {ciftSayilar[i]} ");
                }                
            }            
            Console.ReadLine();


            // // ****** ODEV 1.2 ******

            // Console.Write("Lutfen esitlik kontrolu yapilacak sayi adedini giriniz : ");
            // int n = Convert.ToUInt16(Console.ReadLine());
            // Console.Write("Lutfen esitlik kontrolu yapilacak sayiyi giriniz : ");
            // int m = Convert.ToUInt16(Console.ReadLine());

            // int[] sayilar = new int[n];
            // for (int i = 0; i < n; i++)
            // {
            //     Console.Write("sayi giriniz : ");
            //     sayilar[i] = Convert.ToUInt16(Console.ReadLine());
            // }

            // int[] esitSayilar = new int[n];
            // for (int i = 0; i < n; i++)
            // {
            //     if (sayilar[i] == m || sayilar[i] % m == 0)
            //     {
            //         esitSayilar[i] = sayilar[i];
            //     }
            // }
            // Console.Write("m'ye esit || tam bolunen sayilar : ");
            // for (int i = 0; i < esitSayilar.Length; i++)
            // {
            //     if (esitSayilar[i] > 0)
            //     {
            //         Console.Write($" {esitSayilar[i]} ");
            //     }
            // }
            // Console.ReadLine();


            // // ****** ODEV 1.3 ******

            // Console.Write("Lutfen kelime adedini giriniz : ");
            // int n = Convert.ToInt16(Console.ReadLine());
            // string[] kelimeler = new string[n];

            // for (int i = 0; i < n; i++)
            // {
            //     Console.Write("Lutfen kelime giriniz : ");
            //     kelimeler[i] = Console.ReadLine();
            // }
            // Array.Reverse(kelimeler);
            // Console.Write("Kelime dizisi tersten : ");
            // foreach (var item in kelimeler)
            // {
            //     Console.Write(" " + item);
            // }
            // Console.ReadLine();


            // // ****** ODEV 1.4 ******

            // Console.Write("Lutfen bir cumle yaziniz : ");
            // string cumle=Console.ReadLine();
            // string[] kelimeler=cumle.Split(" ");
            // string duzCumle=string.Join("",kelimeler);
            // char[] harfler=duzCumle.ToCharArray();
            // Console.WriteLine($"Cumle {kelimeler.Length} adet kelimeden oluşuyor");
            // Console.WriteLine($"Cumle {harfler.Length} adet harften oluşuyor");

            // Console.ReadLine();

        }
    }
}
