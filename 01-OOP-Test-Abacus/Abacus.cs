using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_OOP_Test_Abacus
{
    internal class Abacus
    {
        private int length;
        private int count;

        public int Left { get; private set; } = 0;
        public int Right => count - Left;
        public int Moves { get; private set; } = 0;

        public Abacus(int length, int count)
        {
            if (length < 0 || count < 0 || count >= length)
                throw new ArgumentOutOfRangeException();

            this.length = length;
            this.count = count;
        }

        public void Add(int howMany)
        {
            if (howMany < 0 || howMany > Right)
                throw new ArgumentOutOfRangeException();

            Left += howMany;
            Moves++;
        }

        public void Remove(int howMany)
        {
            if (howMany < 0 || howMany > Left)
                throw new ArgumentOutOfRangeException();

            Left -= howMany;
            Moves++;
        }

        public void Relocate(int index)
        {
            if (index < 0 || index >= count)
                throw new ArgumentOutOfRangeException();

            else if (index < Left)
                Remove(Left - index);
            else
                Add(index - Left + 1);
            Moves++;
        }

        public string Show()
        {
            return new string('o', Left) + new string('-', length - count) + new string('o', Right); 
        }
    }
}
