using System;
using System.IO;
using System.Collections.Generic;

class Maze
{
    public int Width { get; private set; }
    public int Height { get; private set; }
    private Coords _entrance;
    private TileType[,] _map = null;
    private MazeDisplay _display = null;

    public void LoadMaze(string filename)
    {
        using (StreamReader reader = new StreamReader(filename)) //načtu textový soubor
        {
            Width = int.Parse(reader.ReadLine()); //první řádek je šířka
            Height = int.Parse(reader.ReadLine()); //druhý řádek je výška
            
            _map = new TileType[Height, Width];

            string line;
            for (int y = 0; y < Height; y++) //projdu všechny řádky
            {
                line = reader.ReadLine();
                for (int x = 0; x < Width; x++) //projdu všechny sloupce
                {
                    _map[x, y] = line[x] switch //uložím do mapy
                    {
                        '#' => TileType.Wall,
                        ' ' => TileType.Corridor,
                        'S' => TileType.Entrance,
                        'E' => TileType.Exit,
                    };
                    if (line[x] == 'S') //poznamenám si, kde je start
                        _entrance = new Coords(x, y);
                }
            }                
        }
        _display = new MazeDisplay(1, 1, Width, Height); //připravím prostor pro kreslení, odsazený o 1 čtverec
        RenderMaze();
    }

    public void RenderMaze()
    {
        for (int x = 0; x < Width; x++)
        {
            for (int y = 0; y < Height; y++)
            {
                _display.RenderTile(new Coords(x, y), _map[x, y]);
            }
        }
        _display.WrapUp();
    }

    public void Solve(ICoordsList toBeVisited)
    {
        //Připravím seznam bodů k projití
        //Stack<Coords> toBeVisited = new Stack<Coords>();

        // Začnu na startu - dám ho do seznamu
        toBeVisited.Add(_entrance);


        // dokud v seznamu něco je
        while (toBeVisited.Count > 0) {

            // vyber ze senamu první
            Coords here = toBeVisited.NextPlace();

            // když jsi v cíli, skonči
            if (_map[here.X, here.Y] == TileType.Exit)
                return;

            // poznač si, žes tu byl
            _map[here.X, here.Y] = TileType.Visited;


            // dej do seznamu všechny jeho zatím nezaznamenané sousedy

            foreach (Coords neighbor in VisitableNeighbors(here))
            {
                toBeVisited.Add(neighbor);
                if (_map[neighbor.X, neighbor.Y] != TileType.Exit)
                    _map[neighbor.X, neighbor.Y] = TileType.Marked;
            }

            RenderMaze();
            System.Threading.Thread.Sleep(100);
        }
    }

    private Coords[] VisitableNeighbors (Coords location)
    {
        List<Coords> neighbors = new List<Coords>();
        (int dx, int dy)[] steps = { (0, 1), (1, 0), (0, -1), (-1, 0) };

        foreach (var step in steps)
        {
            Coords candidate = new Coords(location.X + step.dx, location.Y + step.dy);
            
            if ( 
                candidate.X < 0 
                || candidate.Y < 0 
                || candidate.X >= Width 
                || candidate.Y >= Height
            )
                continue;

            if (
                _map[candidate.X, candidate.Y] == TileType.Corridor 
                || _map[candidate.X, candidate.Y] == TileType.Exit
            )
                neighbors.Add(candidate);
        }

        return neighbors.ToArray();
    }

}

