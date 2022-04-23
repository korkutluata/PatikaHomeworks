using System;

namespace Inheritance
{
    public class Hayvanlar : Canlilar
    {
        protected void Adaptasyon(){
            Console.WriteLine("Hayvanlar adaptasyon kurabilir.");
        }

        public override void UyaranlaraTepki()  //! hayvanlar class'i icin virtual metodu kismen degistirdik base kullandik
        {
            base.UyaranlaraTepki();
            Console.WriteLine("Hayvanlar temasa tepki verirler");
        }
    }

    public class Surungenler : Hayvanlar{
        public Surungenler(){
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
        }
        public void SurunerekHareketEderler(){
            System.Console.WriteLine("Sürüngenler sürünerek hareket ederler.");
            
        }
    }
    public class Kuslar : Hayvanlar{
        public Kuslar(){
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
            base.UyaranlaraTepki();
        }
        public void Ucmak(){
            Console.WriteLine("Kuslar ucabilir.");
        }
    }


    
}