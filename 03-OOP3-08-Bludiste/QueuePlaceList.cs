using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class QueuePlaceList : ICoordsList
{
    Queue<Coords> _places = new Queue<Coords>();

    public int Count => _places.Count;

    public void Add(Coords coords)
    {
        _places.Enqueue(coords);
    }

    public Coords NextPlace()
    {
        return _places.Dequeue();
    }
}

