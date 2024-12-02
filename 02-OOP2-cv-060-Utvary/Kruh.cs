using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _02_OOP2_cv_060_Utvary
{
    internal class Kruh : IUtvar
    {
        public double Polomer { get; private set; }
        public string Nazev => "Kruh";

        public Kruh(double polomer)
        {
            Polomer = polomer;
        }

        public double GetObsah() => Math.PI * Polomer * Polomer;
        public double GetObvod() => 2 * Math.PI * Polomer;
        public override string? ToString() => $"Kruh o poloměru {Polomer} cm";

    }
}
