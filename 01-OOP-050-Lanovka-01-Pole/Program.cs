namespace _01_OOP_050_Lanovka_01_Pole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lanovka lanovka = new Lanovka(4, 250);

            Clovek pepa = new Clovek("Pepa", 80);
            Clovek franta = new Clovek("Franta", 60);
            Clovek lojza = new Clovek("Lojza", 90);
            //Clovek lojza = new Clovek("Lojza", 120);

            Console.WriteLine(lanovka.Nastup(pepa));
            Console.WriteLine(lanovka.Nastup(franta));
            lanovka.Jed();

            Console.WriteLine(lanovka.Nastup(franta));
            lanovka.Jed();

            Console.WriteLine(lanovka.Nastup(lojza));
            lanovka.Jed();

            Console.WriteLine(lanovka.Vystup().Jmeno);

            lanovka.Jed();
            Console.WriteLine(lanovka.Vystup().Jmeno);

            lanovka.Jed();
            Console.WriteLine(lanovka.Vystup().Jmeno);
        }
    }
}
