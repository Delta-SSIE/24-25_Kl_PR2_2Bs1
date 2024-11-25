using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP2_cv_040_Zamestnanci
{
    internal class StalyZamestnanec : Zamestnanec
    {
        //V konstruktoru přímo přijímá měsíční mzdu (celé číslo) a ukládá si ji tak, aby ji metoda Mzda() vracela
        private int _mzda;

        public StalyZamestnanec(string jmeno, string prijmeni, int mzda) : base(jmeno, prijmeni)
        {
            _mzda = mzda;
        }

        public override int Mzda()
        {
            return _mzda;
        }


    }
}
