using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP_3_060_Hanoi
{
    internal class Puzzle
    {
        private Stack<int> leftPin = new Stack<int>();
        private Stack<int> middlePin = new Stack<int>();
        private Stack<int> rightPin = new Stack<int>();
        int discCount;

        public Puzzle(int discCount)
        {
            this.discCount = discCount;

            for (int i = discCount; i > 0; i--)
            {
                leftPin.Push(i);
            }
        }

        public void Render()
        {
            for (int i = 1; i < 4; i++)
            {
                RenderPin(i);
            }
            Console.WriteLine("---------");
        }

        private void RenderPin(int pinNo)
        {
            Console.WriteLine( "| " + string.Join(" ", pinNoToStack(pinNo).Reverse().ToArray()));
        }

        private void Move(Stack<int> from, Stack<int> to)
        {
            if (from.Count < 1)
                throw new InvalidOperationException();

            int disc = from.Pop();

            if (to.Count > 0)
            {
                int topOnTarget = to.Peek(); //koukni, co je v cíli nahoře

                if (topOnTarget < disc)
                    throw new InvalidOperationException();
            }
            to.Push(disc);

            Console.Clear();
            Render();
            System.Threading.Thread.Sleep(500);
        }

        public void Move(int fromNo, int toNo)
        {
            Move(pinNoToStack(fromNo), pinNoToStack(toNo));
        }

        private Stack<int> pinNoToStack(int pinNo)
        {
            return pinNo switch
            {
                1 => leftPin,
                2 => middlePin,
                3 => rightPin,
                _ => throw new ArgumentOutOfRangeException()
            };
        }

        private void MoveSet(Stack<int> from, Stack<int> to, Stack<int> temp, int howMany)
        {
            if (howMany > 1)
            {
                MoveSet(from, temp, to, howMany - 1);
            }
            Move(from, to);
            if (howMany > 1)
            {
                MoveSet(temp, to, from, howMany - 1);
            }
        }

        public void Solve()
        {
            MoveSet(leftPin, rightPin, middlePin, discCount);
        }
    }
}
