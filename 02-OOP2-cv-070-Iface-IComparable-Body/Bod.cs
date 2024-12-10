using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP2_070_Iface_IComparable_Body
{
    class Bod : IComparable
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Bod(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public override string ToString()
        {
            return string.Format("Bod [{0};{1}]", this.X, this.Y);
        }

        public double VzdalenostOdStredu()
        {
            return Math.Sqrt(this.X * this.X + this.Y * this.Y);
        }

        public int CompareTo(object? obj)
        {
            Bod druhyBod = obj as Bod; //převedu typ
            if (druhyBod == null)
                throw new Exception("Incomaparable objects");

            //if (druhyBod.VzdalenostOdStredu() < this.VzdalenostOdStredu())
            //    return 1;
            //else if (druhyBod.VzdalenostOdStredu() == this.VzdalenostOdStredu())
            //    return 0;
            //else return -1;

            return Math.Sign(this.VzdalenostOdStredu() - druhyBod.VzdalenostOdStredu());

        }
    }
}
