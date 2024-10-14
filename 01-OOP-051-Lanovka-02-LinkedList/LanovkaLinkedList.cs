using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_OOP_051_Lanovka_02_LinkedList
{
    internal class LanovkaLinkedList
    {
        private Clovek[] _sedacky;

        public int Delka { get; init; }
        public int Nosnost { get; init; }

        private Sedacka _dolniSedacka = null;
        private Sedacka _horniSedacka = null;

        public bool JeVolnoDole => _dolniSedacka.Pasazer == null;
        public bool JeVolnoNahore => _horniSedacka.Pasazer == null;

        public int Zatizeni
        {
            get
            {
                int zatizeni = 0;
                Sedacka s = _dolniSedacka;
                do
                {
                    if (s.Pasazer == null)
                        continue;

                    zatizeni += s.Pasazer.Hmotnost;

                    s = s.Dalsi;
                }
                while (s.Dalsi != null);

                return zatizeni;
            }
        }

        public LanovkaLinkedList(int delka, int nosnost)
        {
            Delka = delka;
            Nosnost = nosnost;

            Sedacka s = new Sedacka();
            _dolniSedacka = s;

            for (int i = 0; i < delka - 1; i++)
            {
                Sedacka t = new Sedacka();
                s.Dalsi = t;
                t.Predchozi = s;

                s = t;
            }

            _horniSedacka = s;
        }

        public bool Nastup(Clovek clovek)
        {
            if (!JeVolnoDole)
                return false;

            if (Zatizeni + clovek.Hmotnost > Nosnost)
                return false;

            _dolniSedacka.Pasazer = clovek;
            return true;
        }

        public Clovek Vystup()
        {
            Clovek pasazer = _horniSedacka.Pasazer;
            _horniSedacka.Pasazer = null;
            
            return pasazer;
        }

        public void Jed()
        {
            if (!JeVolnoNahore)
                throw new Exception("Nelze jet s clovekem nahore");

            Sedacka puvodniNahore = _horniSedacka;
            _horniSedacka = puvodniNahore.Predchozi;
            _horniSedacka.Dalsi = null;

            puvodniNahore.Dalsi = _dolniSedacka;
            _dolniSedacka.Predchozi = puvodniNahore;
            _dolniSedacka = puvodniNahore;
        }

    }
}
