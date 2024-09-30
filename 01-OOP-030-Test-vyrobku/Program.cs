namespace _01_OOP_30_Test_vyrobku
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vyrobek ideal = new Vyrobek(150);
            Vyrobek produkt = new Vyrobek(151.4);
            Vyrobek produkt2 = new Vyrobek(149.4);
            Vyrobek zmetek = new Vyrobek(30);

            Tester tester = new Tester(ideal, 1); // bude testovat vůči ideálu s tolerancí 1%

            Console.WriteLine(tester.Vyhovuje(ideal)); //vrátí true
            Console.WriteLine(tester.Vyhovuje(produkt)); //vrátí true
            Console.WriteLine(tester.Vyhovuje(produkt2)); //vrátí true
            Console.WriteLine(tester.Vyhovuje(zmetek)); //vrátí false

            //produkt2.Rozmer = -14; //výjimka, zakomentujte si

            //tester.Tolerance = -0.1; //výjimka, zakomentujte si
            tester.Tolerance = 0.1;
            Console.WriteLine(tester.Vyhovuje(produkt)); //vrátí teď už false - do tolerance se nevejde
        }
    }
}
