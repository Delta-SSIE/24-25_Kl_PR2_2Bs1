using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP2_cv_060_Utvary
{
    internal class PlechovkaBarvy
    {
        public double Objem { get; private set; } //objem v ml
        public double Vydatnost { get; private set; } //kolik ml je třeba na 1 cm2

        public PlechovkaBarvy(double objem, double vydatnost)
        {
            Objem = objem;
            Vydatnost = vydatnost;
        }

        public bool Obarvi(IUtvar utvar)
        {
            double spotreba = utvar.GetObsah() * Vydatnost;
            //když je barvy dost
            if (spotreba <= Objem)
            {
                //odečti a vrať true
                Objem -= spotreba;
                return true;
            }
            else
            {
                //jinak vrať false
                return false;
            }
        }

        public override string ToString()
        {
            return $"Plechovka barvy, zbývá jí ještě na {Objem / Vydatnost} cm²";
        }
    }
}
