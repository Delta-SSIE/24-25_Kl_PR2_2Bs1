using System;

class Program {
  static void Main(string[] args)
  {
      Maze maze = new Maze();
      maze.LoadMaze("emptymaze.txt");

      maze.Solve(new RandomPlaceList());
      //maze.Solve(new StackPlaceList());
    //  maze.Solve(new QueuePlaceList());
    }
}