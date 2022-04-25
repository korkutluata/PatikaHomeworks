using System;
using System.Collections.Generic;

namespace TelefonRehberi_Proje
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> PhoneBook = new(){
                new Person(){Name="Korkut", SurName="Kutluata", PhoneNumber="01112223344"},
                new Person(){Name="Ali", SurName="Mavi", PhoneNumber="02223334455"},
                new Person(){Name="Veli", SurName="Kirmizi", PhoneNumber="03334445566"},
                new Person(){Name="Hale", SurName="Jale", PhoneNumber="04445556677"},
                new Person(){Name="Lale", SurName="Vale", PhoneNumber="05556667788"}
            };

            Islemler.Baslat(PhoneBook);
        }
    }
}
