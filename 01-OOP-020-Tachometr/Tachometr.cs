using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_OOP_020_Tachometr
{
    internal class Tachometr
    {
        public int Stav { get; private set; } = 0;

        /// <summary>
        /// Zvýší stav tachometru
        /// </summary>
        /// <param name="kolik">O kolik se má zvýšit</param>
        /// <returns>Nový stav tachometru</returns>
        /// <exception cref="ArgumentOutOfRangeException">Při záporné hodnotě volá výjimku</exception>
        public int Ujed(int kolik)
        {
            if (kolik < 0)
                throw new ArgumentOutOfRangeException();

            Stav += kolik;
            return Stav;
        }

        //public Tachometr()
        //{
        //    Stav = 0;
        //}
    }
}
