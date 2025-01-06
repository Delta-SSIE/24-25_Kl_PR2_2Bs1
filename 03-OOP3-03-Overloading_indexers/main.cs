using System;

class Program
{
    public static void Main(string[] args)
    {
        bool[,] boolArray =
        {
            { true , false, true  },
            { false, true , true  },
            { true , false, false },
        };
        Map map = new Map(boolArray); //mapa vytvořená z předlohového pole

        map.Display();
        map[0, 0] = false;
        map.Display();

        Vector2D point = new Vector2D(2, 2);
        map[point] = true;
        map.Display();
    }
}