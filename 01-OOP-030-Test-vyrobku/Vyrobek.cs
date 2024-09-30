using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_OOP_30_Test_vyrobku
{
    internal class Vyrobek
    {
        public double Rozmer { get; private set; }

        public Vyrobek(double rozmer)
        {
            if (rozmer <= 0)
                throw new ArgumentOutOfRangeException();

            Rozmer = rozmer;
        }
    }
}
