using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP2_cv_040_Zamestnanci
{
    internal class Firma
    {
        //Má veřejné metody Zamestnej(zamestnanec) a Propust(zamestnanec), kterým předáme instanci nějakého zaměstnance a firma si jej připíše na svůj seznam. (Nápověda: použijte List - nebo by se hodil HashSet, ale ten si musíte dohledat)

        private List<Zamestnanec> _personal = new List<Zamestnanec>();

        public void Zamestnej(Zamestnanec z)
        {
            if (!_personal.Contains(z))
                _personal.Add(z);
        }

        public void Propust(Zamestnanec z)
        {
            _personal.Remove(z);
        }

        //Má veřejnou metodu Vyplata, která vypíše pod sebe na řádky všechny zaměstnance spolu s částkou, která jim bude vyplacena a pod to napíše celkovou sumu výplat.

        public void Vyplata()
        {
            int celkem = 0;

            foreach(Zamestnanec z in _personal)
            {
                int mzda = z.Mzda();
                celkem += mzda;
                Console.WriteLine($"{z.Prijmeni}, {z.Jmeno}: {mzda} Kč");
            }
            Console.WriteLine(new string('-', 15));
            Console.WriteLine($"Celkem: {celkem} Kč");
        }
    }
}
