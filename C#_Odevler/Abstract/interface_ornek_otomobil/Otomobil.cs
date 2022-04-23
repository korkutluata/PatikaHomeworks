using System;

namespace interface_ornek_otomobil
{
    public abstract class Otomobil 
    {
        public int KacTekerlektenOlusur()
        {
            return 4;
        }

        public virtual Renk StandartRengiNe()
        {
            return Renk.Beyaz;
        }

        public abstract Marka HangiMarkaninAraci();   // abstract metodun govdesi olmaz       

    }
}