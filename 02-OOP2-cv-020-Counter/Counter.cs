using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP2_cv_020_Counter
{
    internal class Counter
    {
        //vlastnost Count (celé číslo, stav), který lze veřejně zjistit7
        public int Count { get; protected set; }

        //metodu Next, která nic nevrací, ale zvýší počítadlo o 1
        public virtual void Next()
        {
            Count++;
        }

        //metodu Reset, která vrátí počítadlo zpět na nulu7
        public virtual void Reset()
        {
            Count = 0;
        }
    }
}
