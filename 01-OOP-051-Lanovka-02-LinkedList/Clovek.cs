using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_OOP_051_Lanovka_02_LinkedList
{
    internal class Clovek
    {
        public string Jmeno { get; init; }
        public int Hmotnost { get; init; }

        public Clovek(string jmeno, int hmotnost)
        {
            Jmeno = jmeno;

            if (hmotnost < 1)
                throw new ArgumentOutOfRangeException();

            Hmotnost = hmotnost;
        }
    }
