    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP2_040_Icomparable_Karty
{
    enum Vyska { Sedma, Osma, Devitka, Desitka, Spodek, Svrsek, Kral, Eso };
    enum Barva { Srdce, Kule, Zaludy, Zelene };

    class Karta : IComparable
    {
        public Vyska Vyska { get; private set; }
        public Barva Barva { get; private set; }

        public Karta(Vyska vyska, Barva barva)
        {
            Vyska = vyska;
            Barva = barva;
        }

        public override string ToString() => $"{Barva} {Vyska}";


        public int CompareTo(object o) //musí  být object - deklarováno na obecném objektu
        {
            // Pokud druhá karta není platný odkaz na objekt, je tento větší (std. implementace)
            if (o == null)
                return 1;

            Karta druhaKarta = o as Karta;

            // Pokud druhá karta není karta, vyvoláme výjimku)
            if (druhaKarta == null)
                throw new ArgumentException();

            // Porovnání karet závisí na porovnání jejich výšek, které implementuje enum
            // tedy vlastně číslo
            //if (this.Vyska > druhaKarta.Vyska)
            //    return 1;
            // atd...

            //return Vyska.CompareTo(druhaKarta.Vyska)

            int vyskaCmp = Vyska.CompareTo(druhaKarta.Vyska);
            if (vyskaCmp != 0)
                return -vyskaCmp;

            return -Barva.CompareTo(druhaKarta.Barva);
        }

    }
}
