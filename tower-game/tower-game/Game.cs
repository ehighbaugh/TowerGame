using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tower_game 
{
    class Game
    {
        public static void Main()
        {
            Map map = new Map(8, 5);

            Point point = new Point(4, 2);

            bool isOnMap = map.OnMap(point);
        }
    }
}
