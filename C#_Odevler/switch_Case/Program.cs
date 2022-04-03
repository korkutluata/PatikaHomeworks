namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
           int month = DateTime.Now.Month;
            switch (month)
            {
                case 1:
                    Console.WriteLine("Ocak ");
                    break;
                case 2:
                    Console.WriteLine("Şubat");
                    break;
                case 3:
                    Console.WriteLine("Mart");
                    break;
                case 4:
                    Console.WriteLine("Nisan");
                    break;
                case 5:
                    Console.WriteLine("Mayıs");
                    break;
                default:
                    Console.WriteLine("Yanlış veri");
                    break;
            }

            switch (month)
            {
                case 1:
                case 2:
                case 12:
                    Console.WriteLine("Kış");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahar");
                    break;
                default:
                    Console.WriteLine("Mevsim Belirsiz");
                    break;
            }
            Console.ReadLine();
        }
    }
}