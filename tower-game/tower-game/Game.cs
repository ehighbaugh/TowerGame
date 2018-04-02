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
            Map map = new Map();

            map.Width = 8;
            map.Height = 5;

            int area = map.Width * map.Height;
        }
    }
}
