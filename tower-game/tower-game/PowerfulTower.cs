using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tower_game
{
    class PowerfulTower : Tower
    {
        protected override double Accuracy { get; } = 2;

        private readonly MapLocation _location;

        public PowerfulTower(MapLocation location) : base(location)
        {
            _location = location;
        }
    }
}