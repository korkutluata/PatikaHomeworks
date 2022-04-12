using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //erişim_belirteci    geri_dönüş_tipi    metot_adı(parametre listesi / argüman)
            //{
            //komutlar;
            //return;
            //}

            int a = 2;
            int b = 3;
            Console.WriteLine($"a + b = {a+b}");

            int sonuc = Topla(a, b);
            Console.WriteLine($"Topla metot = {sonuc}");

            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdir(Convert.ToString(sonuc));

            int sonuc2 = ornek.ArttirVeTopla(ref a, ref b);
            ornek.EkranaYazdir(Convert.ToString($"ArttitVeTopla sonuc2 = {sonuc2}"));
            ornek.EkranaYazdir(Convert.ToString($"a + b = {a+b}"));
            int sonuc3 = ornek.ArttirVeTopla(ref a, ref b);
            ornek.EkranaYazdir(Convert.ToString($"ArttitVeTopla sonuc3 = {sonuc3}"));
            ornek.EkranaYazdir(Convert.ToString($"a = {a} , b = {b}"));    // ref ile degerler global degisti ONEMLI !!!!!

        }

        static int Topla(int deger1, int deger2)
        {
            return (deger1 + deger2);
        }
    }
    class Metotlar
    {
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public int ArttirVeTopla(ref int deger1, ref int deger2)
        {
            deger1 += 1;
            deger2 += 1;
            return deger1 + deger2;
        }
    }
}
