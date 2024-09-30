using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_OOP_050_Lanovka_01_Pole
{
    internal class Lanovka
    {
        private Clovek[] _sedacky;

        public int Delka { get; init; }
        public int Nosnost { get; init; }

        public bool JeVolnoDole => _sedacky[0] == null;
        public bool JeVolnoNahore => _sedacky[Delka - 1] == null;

        public int Zatizeni
        {
            get
            {
                int zatizeni = 0;
                foreach (Clovek c in _sedacky)
                {
                    if (c != null)
                        zatizeni += c.Hmotnost;
                }
                return zatizeni;

                //return _sedacky.Select(x => x == null ? 0 : x.Hmotnost).Sum();

            }
        }

        public Lanovka(int delka, int nosnost)
        {
            Delka = delka;
            Nosnost = nosnost;

            _sedacky = new Clovek[delka];

        }

        public bool Nastup(Clovek clovek)
        {
            //je tam volno?
            if (!JeVolnoDole)
                return false;

            //nepřetížíme?
            if (Zatizeni + clovek.Hmotnost > Nosnost)
                return false;

            //nastoupíme ho
            _sedacky[0] = clovek;
            return true;
        }

        public Clovek Vystup()
        {
            //uložím si to, co nahoře sedí (člověk nebo null), ještě nemůžu vrátit, ukončila by se metoda!
            Clovek nahore = _sedacky[Delka - 1];

            //a dám tam null (přepsání ničemu nevadí)
            _sedacky[Delka - 1] = null;

            //vrátím, co jsem si předtím uložil
            return nahore;
        }

        public void Jed()
        {
            if (!JeVolnoNahore)
                throw new Exception("Nelze jet s clovekem nahore");

            //posunu každého o jednu sedačku výš
            for (int i = Delka - 1; i > 0; i--)
            {
                _sedacky[i] = _sedacky[i - 1];
            }

            //dolu dám null - prázdno
            _sedacky[0] = null;
        }
    }
}
