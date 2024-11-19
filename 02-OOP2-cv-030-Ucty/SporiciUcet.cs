using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP2_cv03_Ucty
{
    internal class SporiciUcet : Ucet
    {
        /// <summary>
        /// Úroková míra udávaná v procentech
        /// </summary>
        public double UrokovaMira { get; set; }
        public void Urokuj()
        {
            Stav += Stav * UrokovaMira / 100;
        }
    }
}
