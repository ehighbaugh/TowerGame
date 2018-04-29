using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tower_game
{
    class SniperTower : Tower
    {
        protected override int Range { get; } = 2;

        private readonly MapLocation _location;

        public SniperTower(MapLocation location) : base(location)
        {
            _location = location;
        }
    }
}