﻿namespace _01_OOP_051_Lanovka_02_LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                LanovkaLinkedList lanovka = new LanovkaLinkedList(4, 250);

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
}
