using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_OOP_050_Lanovka_01_Pole
{
    internal class LanovkaUkazatel
    {

        private Clovek[] _sedacky; //pole, kam davam hodnoty

        private int _dolniSedacka; //index, kam se nastupuje
        private int _horniSedacka //vypocitavany index, odkud se vystupuje
        {
            get
            {
                if (_dolniSedacka > 0)
                    return _dolniSedacka - 1;

                return Delka - 1;
            }
        }

        public int Delka { get; init; }
        public int Nosnost { get; init; }

        public bool JeVolnoDole => _sedacky[_dolniSedacka] == null;
        public bool JeVolnoNahore => _sedacky[_horniSedacka] == null;

        public int Zatizeni
        {
            get //sectu zatizeni pres vsechny sedacky
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

        public LanovkaUkazatel(int delka, int nosnost)
        {
            Delka = delka;
            Nosnost = nosnost;
            _dolniSedacka = 0;

            _sedacky = new Clovek[delka];

        }

        public bool Nastup(Clovek clovek)
        {
            if (!JeVolnoDole)
                return false;

            if (Zatizeni + clovek.Hmotnost > Nosnost)
                return false;

            _sedacky[_dolniSedacka] = clovek; //noveho cloveka usadim na sedacku, na kterou ukazauje ukazatel _dolniSedacka
            return true;
        }

        public Clovek Vystup()
        {
            Clovek nahore = _sedacky[_horniSedacka]; //zapamatuju si, co je tam, kam vede ukazatel _horniSedacka
            _sedacky[_horniSedacka] = null; //dam na horni sedacku null
            return nahore;
        }

        public void Jed()
        {
            if (!JeVolnoNahore)
                throw new Exception("Nelze jet s clovekem nahore");

            _dolniSedacka--; //zdanlive posunu celou sedacku tak, ze snizim

            if (_dolniSedacka < 0) //při přetečení (spíš "podtečení") rozsahu dáme až nahoru
                _dolniSedacka += Delka;

        }

    }
}
