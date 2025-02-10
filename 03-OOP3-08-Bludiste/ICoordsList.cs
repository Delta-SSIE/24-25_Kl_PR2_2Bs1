using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal interface ICoordsList
{
    int Count { get; }
    void Add(Coords coords);
    Coords NextPlace();
}
