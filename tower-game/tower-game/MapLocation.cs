using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tower_game
{
    class MapLocation : Point
    {
        public MapLocation(int x, int y, Map map): base(x, y)
        {
            if (!map.OnMap(this))
            {
                throw new OutOfBoundsException(x + "," + y + "is out of boundaries of the map");
            }
        }
    }
}
