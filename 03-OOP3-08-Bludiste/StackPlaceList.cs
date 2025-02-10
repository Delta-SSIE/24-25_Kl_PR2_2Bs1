using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class StackPlaceList : ICoordsList
{
    Stack<Coords> _places = new Stack<Coords>();

    public int Count => _places.Count;

    public void Add(Coords coords)
    {
        _places.Push(coords);
    }

    public Coords NextPlace()
    {
        return _places.Pop();
    }
}

