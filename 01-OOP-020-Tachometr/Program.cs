﻿namespace _01_OOP_020_Tachometr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //vytvořte nový tachometr
            Tachometr t = new();

            try
            {
                //zkuste jeho stav několikrát zvýšit a pak vypsat
                t.Ujed(25);
                Console.WriteLine(t.Stav);
            }
            catch
            {
                Console.WriteLine("Nezdařilo se ujet vzdálenost. Dává smysl?");
            }

            try
            {
                t.Ujed(100);
                Console.WriteLine(t.Stav);
            }
            catch
            {
                Console.WriteLine("Nezdařilo se ujet vzdálenost. Dává smysl?");
            }

            //zkuste také zvýšit o zápornou hodnotu
            try
            {
                t.Ujed(-50);
                Console.WriteLine(t.Stav);
            }
            catch
            {
                Console.WriteLine("Nezdařilo se ujet vzdálenost. Dává smysl?");
            }
        }
    }
}
