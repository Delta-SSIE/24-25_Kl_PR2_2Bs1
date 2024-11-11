namespace _002_OOP2_020_Obdelnik_a_ctverec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Obdelnik abcd = new Obdelnik(3, 7);
            Console.WriteLine(abcd);
            Console.WriteLine(abcd.Obsah());

            Ctverec efgh = new Ctverec(4);
            Console.WriteLine(efgh);
            Console.WriteLine(efgh.Obsah());
        }
    }

    class Obdelnik
    {
        //private double _stranaA;
        //public double StranaA
        //{
        //    get { return _stranaA; }
        //    private set { _stranaA = value; }
        //}

        public double StranaA { get; private set; }
        public double StranaB { get; private set; }

        public Obdelnik(double stranaA, double stranaB)
        {
            StranaA = stranaA;
            StranaB = stranaB;
        }

        public double Obvod() => 2 * (StranaA + StranaB);
        public double Obsah() => StranaA * StranaB;

        public override string ToString() => $"Obdélník o stranách {StranaA} a {StranaB}";
    }

    class Ctverec : Obdelnik
    {
        public Ctverec(double strana) : base(strana, strana){}
        public override string ToString() => $"Čtverec o straně {StranaA}";

    }
}
