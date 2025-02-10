using System;
using System.Collections.Generic;

class MazeDisplay
{
    public int Left { get; init; }
    public int Top { get; init; }
    public int Width { get; init; }
    public int Height { get; init; }

    public MazeDisplay(int left, int top, int width, int height)
    {
        Left = left;
        Top = top;
        Width = width;
        Height = height;
    }

    public void RenderTile(Coords coords, TileType type)
    {
        Console.BackgroundColor = type switch
        {
            TileType.Wall => ConsoleColor.White,
            TileType.Corridor => ConsoleColor.Black,
            TileType.Entrance => ConsoleColor.Red,
            TileType.Exit => ConsoleColor.Green,
            _ => ConsoleColor.Black,
        };
        Console.SetCursorPosition(2 * (Left + coords.X), Top + coords.Y); //2 * x proto, aby byly dílky zhruba čtvercové
        Console.Write("  ");
        Console.BackgroundColor = ConsoleColor.Black;
    }

    public void WrapUp()
    {
        Console.SetCursorPosition(0, Top + Height + 1);
    }
}
