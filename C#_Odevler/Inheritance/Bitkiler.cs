using System;

namespace Inheritance
{
    public class Bitkiler : Canlilar
    {
         protected void FotosentezYapmak(){
            Console.WriteLine("Bitkiler fotosentez yapar.");
        }

        public override void UyaranlaraTepki()  //! bitkiler class'i icin virtual metodu tumden degistirdik base kullanmadik
        {
            // base.UyaranlaraTepki();
            Console.WriteLine("Bitkiler güneşe tepki verirler");
        }
    }

    public class TohumluBitkiler : Bitkiler
    {
        public TohumluBitkiler(){
            base.FotosentezYapmak();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
            base.UyaranlaraTepki();
        }
        public void TohumlaCogalma(){
            Console.WriteLine("Tohumlu bitkiler tohumla çoğalır.");
        }
    }
    public class TohumsuzBitkiler:Bitkiler
    {
        public TohumsuzBitkiler(){
            base.FotosentezYapmak();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
        }
        public void SporlaCogalma(){
            Console.WriteLine("Tohumsuz bitkiler sporla çoğalır.");
        }
    }


    
}