﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tower_game
{
    class TowerGameException: System.Exception
    {
        public TowerGameException()
        {

        }

        public TowerGameException(string message) : base(message)
        {

        }
    }

    class OutOfBoundsException: TowerGameException
    {
        public OutOfBoundsException()
        {

        }

        public OutOfBoundsException(string message) : base(message)
        {

        }
    }
}
