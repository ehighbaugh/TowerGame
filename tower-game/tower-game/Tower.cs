using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tower_game 
{
    class Tower
    {
        protected virtual int Range { get; } = 1;
        protected virtual int Power { get; } = 1;
        protected virtual double Accuracy { get; } = .75;

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
