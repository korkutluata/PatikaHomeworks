using System;
using System.Collections;
using System.Text.RegularExpressions;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir cumle giriniz");
            string cumle = Console.ReadLine();
            string sesliler = "aeiıuüoö";
            ArrayList sesliArray = new ArrayList();

            for (int i = 0; i < cumle.Length; i++)
            {
                if (sesliler.Contains(cumle[i]))
                {
                    sesliArray.Add(cumle[i]);
                }
            }
            sesliArray.Sort();
            foreach (var item in sesliArray)
            {
                Console.WriteLine(item);
            }           

            Console.ReadLine();
        }
    }
}
