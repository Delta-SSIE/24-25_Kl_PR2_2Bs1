namespace Overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool[,] map =
            {
                { true , false, true  },
                { false, true , true  },
                { true , false, false },
            };

            DisplayMap(map);
            DisplayMap(map, "X");
            DisplayMap(map, "██", "  ");
            DisplayMap(map, falseSymbol: "."); //lze i pro povinné parametry

        }
        static void DisplayMap(bool[,] map, string trueSymbol = "#", string falseSymbol = "-")
        {
            for (int y = 0; y < map.GetLength(1); y++)
            {
                for (int x = 0; x < map.GetLength(0); x++)
                {
                    Console.Write(map[y, x] ? trueSymbol : falseSymbol);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        
    }
}
