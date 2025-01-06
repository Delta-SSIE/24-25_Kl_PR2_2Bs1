using System;

class Map
{
    private bool[,] map;

    public Map(bool[,] map) //konstruktor s předáním mapy
    {
        this.map = map;
    }
    public Map(int width, int height) //konstruktor s vytvořením nové mapy
    {
        this.map = new bool[width, height];
    }

    public bool IsPointValid(int x, int y) //ověří, že bod předaný dvěma souřadnicemi existuje
    {
        return x >= 0 && y >= 0 && x < map.GetLength(0) && y < map.GetLength(1);
    }

    public bool IsPointValid(Vector2D point)//ověří, že bod předaný jako jedna dvojice čísel existuje
    {
        return IsPointValid(point.X, point.Y);
    }

    public int NeighborCount(int x, int y)
    {
        int count = 0;
        for (int dx = -1; dx <= 1; dx++)
        {
            for (int dy = -1; dy <= 1; dy++)
            {
                if (dx == 0 & dy == 0) continue;

                int placeX = x + dx;
                int placeY = y + dy;
                if (IsPointValid(placeX, placeY) && map[placeX, placeY] == true)
                    count++;
            }
        }
        return count;
    }
    public int NeighborCount(Vector2D point) {
        return NeighborCount(point.X, point.Y);
    }

    public void Display(string trueSymbol = "#", string falseSymbol = "-")
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