using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP2_cv03_Ucty
{
    internal class UcetSPoplatkem : Ucet
    {
        public double PoplatekZaVyber { get; set; }
        public double PoplatekZaVklad { get; set; }

        public override void Uloz(double castka)
        {
            base.Uloz(castka - PoplatekZaVklad);
        }

        public override void Vyber(double castka)
        {
            base.Vyber(castka + PoplatekZaVyber);
        }
    }
}
