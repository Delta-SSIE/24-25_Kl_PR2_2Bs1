using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP2_cv_020_Counter
{
    internal class StepCounter : Counter
    {
        public int Step { get; private set; }

        public StepCounter(int step)
        {
            Step = step;
        }

        public override void Next()
        {
            Count += Step;
        }
    }
}
