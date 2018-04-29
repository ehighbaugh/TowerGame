using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tower_game
{
    class StrongInvader : Invader
    {
        public override int Health { get; protected set; } = 2;

        public StrongInvader(Path path) : base(path)
        {

        }
    }
}
