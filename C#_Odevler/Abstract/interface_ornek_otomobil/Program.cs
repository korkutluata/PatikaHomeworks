using System;

namespace interface_ornek_otomobil
{
    class Program
    {
        static void Main(string[] args)
        {
            Focus focus = new();
            Console.WriteLine(focus.HangiMarkaninAraci().ToString());
            Console.WriteLine(focus.KacTekerlektenOlusur());
            Console.WriteLine(focus.StandartRengiNe().ToString());

            Civic civic = new();
            Console.WriteLine(civic.HangiMarkaninAraci().ToString());
            Console.WriteLine(civic.KacTekerlektenOlusur());
            Console.WriteLine(civic.StandartRengiNe().ToString());

            Corolla corolla = new();
            Console.WriteLine(corolla.HangiMarkaninAraci().ToString());
            Console.WriteLine(corolla.KacTekerlektenOlusur());
            Console.WriteLine(corolla.StandartRengiNe().ToString());

            Console.WriteLine("******Abstracttan turetilenler*******");

            NewFocus newFocus = new();
            Console.WriteLine(newFocus.HangiMarkaninAraci().ToString());
            Console.WriteLine(newFocus.KacTekerlektenOlusur());
            Console.WriteLine(newFocus.StandartRengiNe().ToString());

            NewCivic newCivic = new();
            Console.WriteLine(newCivic.HangiMarkaninAraci().ToString());
            Console.WriteLine(newCivic.KacTekerlektenOlusur());
            Console.WriteLine(newCivic.StandartRengiNe().ToString());

            NewCorolla newCorolla = new();
            Console.WriteLine(newCorolla.HangiMarkaninAraci().ToString());
            Console.WriteLine(newCorolla.KacTekerlektenOlusur());
            Console.WriteLine(newCorolla.StandartRengiNe().ToString());
            
        }
    }
}
