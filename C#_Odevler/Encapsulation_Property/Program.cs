using System;

namespace Encapsulation_Property
{
   class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Ad = "Korkut";
            ogrenci.Soyad = "Kutluata";
            ogrenci.OgrenciNo = 45632;
            ogrenci.Sinif = 3;
            ogrenci.OgrenciBilgileriniGetir();

            Ogrenci ogrenci1 = new Ogrenci("Emel", "Ece", 346, 1);
            ogrenci1.SinifDusur();
            ogrenci1.SinifDusur();
            ogrenci1.OgrenciBilgileriniGetir();
        }
    }

    class Ogrenci
    {
        private string ad;
        private string soyad;
        private int ogrenciNo;
        private int sinif;
        public string Ad
        {
            get => ad;          // get islemi aslinda bir metot. Ad'i cagiranlara ad'i return eden bir metod
            //get {return ad;}   
            set => ad = value;  // set de bir metot. Ad'i cagiranlarin verdigi value'u ad'a atayan bir metod
            //set{ ad = value;}  
        }
        public string Soyad { get => soyad; set => soyad = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif
        {
            get => sinif;
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("Sinif En Az 1 Olmali!");
                    sinif = 1;
                }
                else
                    sinif = value;
            }
        }

        public Ogrenci(string ad, string soyad, int ogrenciNo, int sinif)
        {
            Ad = ad;
            Soyad = soyad;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }
        public Ogrenci()
        {
        }

        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("**** Ogrenci Bilgileri ****");
            Console.WriteLine("Ogrenci Adi     : {0}", this.Ad);
            Console.WriteLine("Ogrenci Soyadi     : {0}", this.Soyad);
            Console.WriteLine("Ogrenci Ogrenci No     : {0}", this.OgrenciNo);
            Console.WriteLine("Ogrenci Sinifi     : {0}", this.Sinif);
        }

        public void SinifAtlat()
        {
            this.Sinif = this.Sinif + 1;
        }

        public void SinifDusur()
        {
            this.Sinif = this.Sinif - 1;
        }

    }
}
