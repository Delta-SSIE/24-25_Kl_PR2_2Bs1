using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class RandomPlaceList : ICoordsList
{
    List<Coords> _places = new List<Coords>();
    Random _random = new Random();

    public int Count => _places.Count;

    public void Add(Coords coords)
    {
        _places.Add(coords);
    }

    public Coords NextPlace()
    {
        int index = _random.Next(Count);
        Coords result = _places[index];
        _places.RemoveAt(index);
        return result;
    }
}

