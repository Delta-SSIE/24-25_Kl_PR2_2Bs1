using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_OOP3_09_Randomizer
{
    internal class Randomizer
    {
        private int[] _nums;
        private int _position;
        private Random _random = new Random();

        public Randomizer(int[] nums)
        {
            _nums = nums;
            Randomize();
            _position = 0;
        }

        private void Randomize()
        {
            //zamíchá
            for (int i = _nums.Length - 1; i > 0; i--)
            {
                int j = _random.Next(i + 1);
                int tmp = _nums[i];
                _nums[i] = _nums[j];
                _nums[j] = tmp;
            }
        }

        public int Next()
        {
            //vrací další číslo v pořadí
            return _nums[_position++]; //ještě by to chtělo řešit "přetečení indexu"
        }
    }
}
