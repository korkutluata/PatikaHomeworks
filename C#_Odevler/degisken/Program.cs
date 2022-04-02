using System;

namespace degisken
{
    class Program
    {
        static void Main(string[] args)
        {
            int deger = 2;
            string degisken = null;
            string Degisken = null;
            // !! string class = "";
            // !! string degisken + veri = null
            string degisken_veri = null;
            string degiskenVeri = null;

            byte b = 5;  //0-255       //1byte
            sbyte c = 5; //-128  127 arasında değer alır   //1byte


            short s = 5;      //2byte
            ushort us = 5;    //2byte işaretsiz 

            Int16 i16 = 2;    //2byte
            int i = 2;        //4byte
            Int32 i32 = 2;    //4byte
            Int64 i64 = 2;    //8byte

            uint ui = 2;      //4byte
            long l = 4;       //8byte
            ulong ul = 4;     //8byte

            //reel sayılar
            float f = 5;      //4byte
            double d = 5;      //8byte
            decimal de = 5;   //16byte


            char ch = '2';    //2byte
            string str = "Gokhan"; //Sınırsız

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            object o1 = "x";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 4.3;


            // String ifadeler
            string str1 = string.Empty;
            str1 = "Gokhan Gok";
            string ad = "Gokhan";
            string soyad = "GOK";
            string tamIsim = ad + " " + soyad;

            //integer tanımlama

            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 + integer2;

            //boolean
            bool bool1 = 10 > 2;

            //Değiken dönüşümleri
            string str20 = "20";
            int int20 = 20;

            string yeniDeger = str20 + int20.ToString();
            Console.WriteLine(yeniDeger); //çıktısı 2020


            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21); //çıktısı 40

            int int22 = int20 + int.Parse(str20); //Çıktısı  40


            // dateTime

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime1 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime1);

            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);
        }
    }
}
