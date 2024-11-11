namespace _01_OOP_Test_Abacus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Abacus abacus = new Abacus(9, 5);
            Console.WriteLine(abacus.Show());
            abacus.Add(2);
            Console.WriteLine(abacus.Show());
            abacus.Relocate(3);
            Console.WriteLine(abacus.Show());
            abacus.Relocate(0);
            Console.WriteLine(abacus.Show());
            abacus.Relocate(0);
            Console.WriteLine(abacus.Show());
        }
    }
}
