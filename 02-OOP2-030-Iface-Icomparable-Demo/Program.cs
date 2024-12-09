namespace _02_OOP2_030_Iface_Icomparable_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Strom[] sad = new Strom[]
            {
                new Strom() {Druh = "Jabloň", Vyska = 5.5},
                new Strom() {Druh = "Smrk", Vyska = 12},
                new Strom() {Druh = "Hrušeň", Vyska = 8.2},
                new Strom() {Druh = "Třešeň", Vyska = 3.3},
                new Strom() {Druh = "Švestka", Vyska = 4.1}
            };

            foreach (Strom strom in sad)
            {
                Console.WriteLine($"{strom.Druh}: {strom.Vyska}");
            }

            Console.WriteLine();

            Array.Sort(sad);

            foreach (Strom strom in sad)
            {
                Console.WriteLine($"{strom.Druh}: {strom.Vyska}");
            }
        }
    }

    class Strom
    {
        public string Druh { get; set; }
        public double Vyska { get; set; }
    }
    
}
