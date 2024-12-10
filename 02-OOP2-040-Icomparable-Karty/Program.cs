namespace _02_OOP2_040_Icomparable_Karty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Karta[] karty = {
                new Karta(Vyska.Svrsek, Barva.Zaludy),
                new Karta(Vyska.Eso, Barva.Srdce),
                new Karta(Vyska.Svrsek, Barva.Zelene),
                new Karta(Vyska.Sedma, Barva.Kule),
                new Karta(Vyska.Desitka, Barva.Zaludy),
            };
            Array.Sort(karty); //díky IComparable mohu třídit

            foreach (Karta karta in karty)
            {
                Console.WriteLine(karta);
            }
        }
    }
}
