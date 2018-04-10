﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tower_game 
{
    class Tower
    {
        private const int _range = 1;
        private const int _power = 1;
        private const double _accuracy = .75;

        private static readonly Random _random = new Random();

        private readonly MapLocation _location;

        public bool IsSuccessfulShot()
        {
            return _random.NextDouble() < _accuracy;
        }

        public Tower(MapLocation location)
        {
            _location = location;
        }

        public void FireOnIvaders(Invader[] invaders)
        {
            foreach(Invader invader in invaders)
            {
                if(invader.IsActive && _location.InRangeOf(invader.Location, _range))
                {
                    if(IsSuccessfulShot())
                    {
                        invader.DecreaseHealth(_power);
                        Console.WriteLine("Shot at and hit invader!");
                        if(invader.IsNeutralized)
                        {
                            Console.WriteLine("Killed invader");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Missed invader");
                    }
                    break;
                }
            }
        }
    }
}
