namespace _04_OOP3_050_Urad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pocetPrepazek = 3;
            double pravdepodobnostNoveho = 0.25;
            Random random = new Random();

            Clovek[] lide =
            {
                new Clovek("Josef", "Smutný", 4),
                new Clovek("Anna", "Veselá", 3),
                new Clovek("Marie", "Zelená", 12),
                new Clovek("Jiří", "Červenka", 3),
                new Clovek("Antonín", "Černý", 5),
                new Clovek("Antonie", "Bohatá", 7),
                new Clovek("Richard", "Těsný", 4),
                new Clovek("Luisa", "Podhorská", 15),
            };

            //Queue<Clovek> fronta = new Queue<Clovek>(lide); //inicializace kolekce polem
            Queue<Clovek> fronta = new Queue<Clovek>();
            foreach (Clovek clovek in lide)
            {
                fronta.Enqueue(clovek);
            }

            Prepazka[] prepazky = new Prepazka[pocetPrepazek];
            for (int i = 0; i < pocetPrepazek; i++)
            {
                prepazky[i] = new Prepazka(i + 1);
            }

            int cas = 0;
            int maxCas = 180;

            // while (fronta.Count > 0) //dokud ve frontě někdo je
            while (maxCas > cas) //dokud ve frontě někdo je
            {
                foreach (Prepazka p in prepazky)
                {
                    if (fronta.Count < 1)
                        break;

                    if (p.KdyBudeVolno <= cas)
                    {
                        Clovek zakaznik = fronta.Dequeue(); //zkrátí frontu o prvního a vrátí nám ho
                        p.Odbav(zakaznik, cas);
                    }
                }
                cas++;
                
                if (random.NextDouble() < pravdepodobnostNoveho)
                {
                    Clovek novy = Clovek.NahodnyClovek();
                    fronta.Enqueue(novy);
                    Console.WriteLine($"Čas {cas}: Nový zákazník {novy.Jmeno} {novy.Prijmeni} ");
                }
            }

        }
    }

    class Prepazka
    {
        public int KdyBudeVolno { get; private set; }
        public int Cislo { get; private set; }

        public Prepazka(int cislo)
        {
            Cislo = cislo;
            KdyBudeVolno = 0;
        }

        public void Odbav(Clovek zakaznik, int casTed)
        {
            KdyBudeVolno = casTed + zakaznik.Trvani;
            Console.WriteLine($"Přepážka {Cislo}: {zakaznik.Prijmeni} {zakaznik.Jmeno} ({casTed} - {KdyBudeVolno})");
        }

    }

    class Clovek
    {
        public string Jmeno { get; private set; }
        public string Prijmeni { get; private set; }
        public int Trvani { get; private set; }

        public Clovek(string jmeno, string prijmeni, int trvani)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Trvani = trvani;
        }

        private static Random random = new Random();

        public static Clovek NahodnyClovek()
        {
            string jmeno = "Jméno" + random.Next(1, 1_000_000);
            string prijmeni = "Příjmení" + random.Next(1, 1_000_000);
            int trvani = random.Next(2, 20);

            return new Clovek(jmeno, prijmeni, trvani);
        }
    }
}
