using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP2_cv_040_Zamestnanci
{
    internal class Brigadnik : Zamestnanec
    {
        public Brigadnik(string jmeno, string prijmeni) : base(jmeno, prijmeni)
        {
        }

        //Má veřejné vlastnosti Odpracovano(celé číslo, počet odpracovaných hodin) a HodinovaMzda(celé číslo)
        public int Odpracovano { get; set; }
        public int HodinovaMzda { get; set; }



        //Mzda() vrací mzdu vypočtenou z předchozích položek
        public override int Mzda()
        {
            return Odpracovano * HodinovaMzda;
        }


    }
}
