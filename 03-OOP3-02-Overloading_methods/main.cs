using System;

class Program
{
    public static void Main(string[] args)
    {
        Map map1 = new Map(3, 4); //mapa vytvořená dvěma souřadnicemi
        Console.WriteLine(map1.IsPointValid(2, 3)); //je bod uvnitř? - dvě čísla, true

        Vector2D point = new Vector2D(2, 3);
        Console.WriteLine(map1.IsPointValid(point));//je bod uvnitř? - jeden objekt, true


        bool[,] boolArray =
        {
            { true , false, true  },
            { false, true , true  },
            { true , false, false },
        };
        Map map2 = new Map(boolArray); //mapa vytvořená z předlohového pole
        Console.WriteLine(map2.IsPointValid(2, 3));//je bod uvnitř? - false, není, pole je malé

        Console.WriteLine(map2.NeighborCount(0, 0)); //počet sousedů polohy [0, 0]            
        Console.WriteLine(map2.NeighborCount(1, 1)); //počet sousedů polohy [0, 0]

    }
}