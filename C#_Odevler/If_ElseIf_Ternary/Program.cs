using System;

namespace If_ElseIf_Ternary
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            if (time >= 6 && time < 11)
            {
                Console.WriteLine("Günaydın !");
            }
            else if (time <= 18)
            {
                Console.WriteLine("İyi Günler !");
            }
            else
            {
                Console.WriteLine("İyi Geceler !");
            }
                
                // ternary kismimiz
            string sonuc = time <= 18 ? "İyi Günler !" : "İyi Geceler !";
            sonuc = time >= 6 && time < 11 ? "Günaydın !" : time <= 18 ? "İyi Günler !" : "İyi Geceler !";
            Console.WriteLine(sonuc);
        }
    }
}
