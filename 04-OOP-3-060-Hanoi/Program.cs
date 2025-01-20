namespace _04_OOP_3_060_Hanoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int discCount = 6;
            Puzzle puzzle = new Puzzle(discCount);
            puzzle.Render();
            //puzzle.Move(1, 3);
            //puzzle.Render();
            //puzzle.Move(1, 2);
            //puzzle.Render();
            //puzzle.Move(3, 2);
            //puzzle.Render();
            //puzzle.Move(1, 3);
            puzzle.Solve();
            puzzle.Render();

        }
    }


}
