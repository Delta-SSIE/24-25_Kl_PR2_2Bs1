using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP2_cv_060_Utvary
{
    internal interface IUtvar
    {
        string Nazev { get; } //v iface je vše automaticky public

        double GetObvod();
        double GetObsah();
    }
}
