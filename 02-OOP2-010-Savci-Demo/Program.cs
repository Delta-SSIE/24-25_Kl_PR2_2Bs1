namespace _02_OOP2_010_Savci_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kun konik = new Kun("Ferda");
            konik.Cvalej();
            konik.Dychej();

            Velryba plejtvak = new Velryba("Marie", "modrá");
            plejtvak.Plav();
            plejtvak.Dychej();

            Savec kobylka = new Kun("Hátátitlá");
            kobylka.Dychej(); //nenabízí metody koně

            Kun kobylkaJinak = (Kun)kobylka; //přetypování - type casting
            kobylkaJinak.Cvalej();

            Savec velrybak = plejtvak;
            //Kun hybrid = (Kun)velrybak; //nelze přetypovat, velryba není typ koně
            //hybrid.Cvalej();

            Console.WriteLine();
            Savec[] archa = { konik, kobylka, plejtvak };
            foreach (Savec zvire in archa)
            {
                Console.WriteLine(zvire.Jmeno);
                zvire.OzviSe();
            }

            //Savec savec = new Savec("savec savý"); //nelze - savec je abstraktní
            

        }
    }

    abstract class Savec : Object
    { 
        public string Jmeno { get; protected set; }

        public Savec(string jmeno)
        {
            Jmeno = jmeno;
        }

        public void Dychej()
        {
            Console.WriteLine("Nádech - výdech");
        }
        public void SajMleko()
        {
            Console.WriteLine("Mňam");
        }

        public abstract void OzviSe();

        //public virtual void OzviSe()
        //{
        //    Console.WriteLine("Dělám zvuk");
        //}
    }
    class Kun : Savec
    {
        public Kun(string jmeno) : base(jmeno) 
        {
            Jmeno += " (kůň)";
        }

        public void Cvalej()
        {
            Console.WriteLine("Dupy dup");
        }

        public override void OzviSe()
        {
            Console.WriteLine("Íhahahá");
        }
    }
    class Velryba : Savec
    {
        public string Barva { get; private set; }
        
        public Velryba(string jmeno, string barva) : base(jmeno)
        {
            Barva = barva;
        }

        public void Plav()
        {
            Console.WriteLine("Šplouch");
        }

        public override void OzviSe()
        {
            Console.WriteLine("Huí huí");
        }
    }

    class KosatkaDrava : Velryba
    {
        public KosatkaDrava(string jmeno) : base(jmeno, "černobílá")
        {
        }
    }
}
