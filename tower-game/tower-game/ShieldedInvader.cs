﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tower_game
{
    class ShieldedInvader : Invader
    { 
        public override int Health { get; protected set; } = 2;

        public ShieldedInvader(Path path) : base(path)
        { }

        public override void DecreaseHealth(int factor)
        {
            if(Random.NextDouble() < .5)
            {
                base.DecreaseHealth(factor);
            }
            else
            {
                Console.WriteLine("Shot at and missed shielded invader.");
            }
        }
        
    }
}
