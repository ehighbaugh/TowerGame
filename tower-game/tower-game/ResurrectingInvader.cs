using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tower_game
{
    class ResurrectingInvader : IInvader
    {
        private BasicInvader _incarnation1;
        private StrongInvader _incarnation2;

        public int Health => _incarnation1.IsNeutralized? _incarnation2.Health : _incarnation1.Health;

        //True if invader has reached end of path
        public bool HasScored => _incarnation1.HasScored || _incarnation2.HasScored;

        public bool IsNeutralized => _incarnation1.IsNeutralized && _incarnation2.IsNeutralized;

        public bool IsActive => !(IsNeutralized || HasScored);

        public MapLocation Location => _incarnation1.IsNeutralized ? _incarnation2.Location : _incarnation1.Location;

        public ResurrectingInvader(Path path)
        {
            _incarnation1 = new BasicInvader(path);
            _incarnation2 = new StrongInvader(path);
        }

        public void Move()
        {
            _incarnation1.Move();
            _incarnation2.Move();
        }

        public void DecreaseHealth(int factor)
        {
            if(!_incarnation1.IsNeutralized)
            {
                _incarnation1.DecreaseHealth(factor);
            }
            _incarnation2.DecreaseHealth(factor);
        }
    }
}
