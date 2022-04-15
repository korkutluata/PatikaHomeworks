using System;

namespace string_metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz CSharp , Hoşgeldiniz.";
            string degisken2 = "CSharp";
            //Lenght => kaç harf olduğunu verir.
            Console.WriteLine(degisken.Length);
            // ToUpper() => tüm karakterleri büyük yazdırır.
            //ToLower() => tüm karakterleri küçük yazdırır.
            Console.WriteLine(degisken.ToLower());
            Console.WriteLine(degisken.ToUpper());

            //Concat(degisken,eklemek istenilen) => Verilen değerin sonuna ekleme işlemi yapar.

            Console.WriteLine(String.Concat(degisken,"Merhaba!"));

            // CompareTo ile Compare farkli
            Console.WriteLine(degisken.CompareTo(degisken2));
            Console.WriteLine(String.Compare(degisken,degisken2,false));
            Console.WriteLine(String.Compare(degisken,degisken2,true));

            //Contains
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz."));
            Console.WriteLine(degisken.StartsWith("Merhaba!"));

            //IndexOf

            Console.WriteLine(degisken.IndexOf("C#"));
            Console.WriteLine(degisken.IndexOf("Korkut"));
            Console.WriteLine(degisken.LastIndexOf("i"));

            //Insert
            Console.WriteLine(degisken.Insert(0,"Merhaba"));
            
            //PadLeft,PadRight
            Console.WriteLine(degisken + degisken2.PadLeft(30,'*'));
            Console.WriteLine(degisken.PadRight(50,'-') + degisken2);

            //Remove
            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(5,3));
            Console.WriteLine(degisken.Remove(0,1));

            //Replace
            Console.WriteLine(degisken.Replace("C#","C Sharp"));
            Console.WriteLine(degisken.Replace(" ","*"));

            //Split
            Console.WriteLine(degisken.Split(" ")[1]);

            //SubString
            Console.WriteLine(degisken.Substring(4));

            Console.ReadLine();  
        }
    }
}
