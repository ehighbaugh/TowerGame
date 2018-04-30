using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tower_game
{
    interface IInvader
    {
        MapLocation Location { get; }

        int Health { get; }

        //True if invader has reached end of path
        bool HasScored { get; }

        bool IsNeutralized { get; }

        bool IsActive { get; }

        void Move();

        void DecreaseHealth(int factor);
    }
}
