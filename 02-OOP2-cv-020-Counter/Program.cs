namespace _02_OOP2_cv_020_Counter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //napočítáme do 5, pak resetujeme a pro jistotu vypíšeme
            Counter c = new Counter();

            Console.WriteLine(c.Count);

            for (int i = 0; i < 5; i++)
            {
                c.Next();
                Console.WriteLine(c.Count);
            }

            c.Reset();
            Console.WriteLine(c.Count); //teď by měla být nula


            Console.WriteLine();


            //napočítáme do 15, po 5
            Counter sc = new StepCounter(5);
            //StepCounter sc = new StepCounter(5);

            Console.WriteLine(sc.Count);

            for (int i = 0; i < 3; i++)
            {
                sc.Next();
                Console.WriteLine(sc.Count);
            }

            Console.WriteLine();

            DownCounter dc = new DownCounter(10, 100);

            Console.WriteLine(dc.Count);
            while (!dc.IsFinished)
            {
                dc.Next();
                Console.WriteLine(dc.Count);
            }

            //zresetujeme a odpočítáme ještě jednou
            Console.WriteLine();

            dc.Reset();

            Console.WriteLine(dc.Count);
            while (!dc.IsFinished)
            {
                dc.Next();
                Console.WriteLine(dc.Count);
            }
        }
    }
}
