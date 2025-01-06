namespace _03_OOP3_04_Overloading_operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Karta karta1 = new Karta(VyskaKarty.Sedma, BarvaKarty.Srdce);
            Karta karta2 = new Karta(VyskaKarty.Desitka, BarvaKarty.Kule);

            if (karta1 > karta2)
            {
                Console.WriteLine("Mám věrší kartu");
            }
            else
            {
                Console.WriteLine( "Potvoro, vítězíš");
            }
        }
    }

    enum VyskaKarty { Sedma, Osma, Devitka, Desitka, Spodek, Svrsek, Kral, Eso }
    enum BarvaKarty { Srdce, Kule, Zaludy, Zelene }
    
    class Karta
    {
        VyskaKarty vyska;
        BarvaKarty barva;

        public Karta(VyskaKarty vyska, BarvaKarty barva)
        {
            this.vyska = vyska;
            this.barva = barva;
        }

        public static bool operator >(Karta kartaA, Karta kartaB) {
            if (kartaA.vyska > kartaB.vyska)
                return true;
            else
                return false;
        }
        public static bool operator <(Karta kartaA, Karta kartaB) =>
            kartaA.vyska < kartaB.vyska;
        
        public static bool operator ==(Karta kartaA, Karta kartaB) =>
            kartaA.vyska == kartaB.vyska && kartaA.barva == kartaB.barva;
        public static bool operator !=(Karta kartaA, Karta kartaB) =>
            ! (kartaA == kartaB);


    }


}
