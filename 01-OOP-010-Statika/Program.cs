namespace _01_OOP_010_Statika
{
    class Clovek 
    { 
        public static void Popis() 
        { 
            Console.WriteLine("Lidé jsou humaniodní rasa, ne nepodobná gorilám, vyznačují se ale nižší \n" 
                + "inteligencí, fyzickou silou i celkovou odolností. Nejsou také schopni \n" 
                + "artikulované řeči."); 
        } 
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            double constPi2 = 2 * Math.PI;
            //Math m = new Math();

            Console.WriteLine(  );
            Clovek.Popis();

            Clovek Franta = new Clovek();
            //Franta.Popis(); //nelze - statická metoda
        }
    }
}
