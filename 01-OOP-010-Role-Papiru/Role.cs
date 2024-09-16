using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_OOP_010_Role_Papiru
{
    internal class Role
    {
        private string barva;
        private int delka;

        //pouzivejte prop - tab, resp. propfull - tab

        public string Barva { get => barva; set => barva = value; }
        public int Delka { 
            get => delka;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException();

                delka = value;
            } 
        }

        public Role(string barva, int delka)
        {
            Barva = barva;
            Delka = delka;
        }

        public override string ToString()
        {
            return $"Role papíru, barva {Barva}, zbývá {Delka} cm";
        }
    }
}
