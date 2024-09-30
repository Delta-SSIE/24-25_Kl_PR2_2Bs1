using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_OOP_30_Test_vyrobku
{
    internal class Tester
    {
        public Vyrobek Vzor { get; set; }

		private double _tolerance;

		public double Tolerance
		{
			get { return _tolerance; }
			set 
			{
				if (value < 0)
					throw new ArgumentOutOfRangeException();

				_tolerance = value; 
			}
		}

        public Tester(Vyrobek vzor, double tolerance)
        {
            Vzor = vzor;
            Tolerance = tolerance;
        }

		public bool Vyhovuje(Vyrobek vyrobek)
		{
			double rozdil = Math.Abs(vyrobek.Rozmer - Vzor.Rozmer);
			double rozdilVProcentech = rozdil / Vzor.Rozmer * 100;

			return Tolerance > rozdilVProcentech;
			//if (rozdilVProcentech > Tolerance)
			//	return false;
			//else
			//	return true;
		}
    }
}
