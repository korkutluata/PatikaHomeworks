using System;

namespace Inheritance
{
    // public sealed class Canlilar       //!  sealed ile diger class'larin inheritance almasi engellenir
    public class Canlilar
    {
        protected void Beslenme(){
            Console.WriteLine("Canlılar beslenir.");
        }
        protected void Solunum(){
            Console.WriteLine("Canlılar solunum yapar.");
        }
        protected void Bosaltim(){
            Console.WriteLine("Canlılar bosaltım yapar.");
        }

        public virtual void UyaranlaraTepki()
        {
            Console.WriteLine("Canlılar uyaranlara tepki verirler");
        }
    } 
}