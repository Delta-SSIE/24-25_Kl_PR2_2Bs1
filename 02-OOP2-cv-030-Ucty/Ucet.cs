using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP2_cv03_Ucty
{
    internal class Ucet
    {
        public double Stav { get; protected set; }
        public virtual void Uloz(double castka)
        {
            if (castka <= 0)
                throw new ArgumentOutOfRangeException(nameof(castka), "Hodnota nemůže být záporná");
            Stav += castka;
        }
        public virtual void Vyber(double castka)
        {
            if (castka <= 0)
                throw new ArgumentOutOfRangeException(nameof(castka), "Hodnota nemůže být záporná");
            else if (castka > Stav)
                throw new Exception("Nelze vybrat pod zůstatek na účtu");
            Stav -= castka;
        }
        public override string ToString()
        {
            return $"Účet se stavem {Stav} Kč";
        }

    }
}
