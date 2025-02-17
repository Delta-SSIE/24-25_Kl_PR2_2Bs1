using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Tests_01_Min
{
    public class Tools
    {
        public static int FindMin(int[] numbers)
        {
            //if (numbers.Length == 0)
            //    throw new ArgumentException("Empty array cannot have minimum", nameof(numbers));

            int min = int.MaxValue;
            foreach (int num in numbers)
            {
                if (num < min)
                    min = num;
            }
            return min;
        }
    }
}
