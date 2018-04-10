using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tower_game
{
    class Level
    {
        private readonly Invader[] _invaders;

        public Tower[] Towers { get; set; }

        public Level(Invader[] invaders)
        {
            _invaders = invaders;
        }

        //Returns: true if the player wins, false if they lose
        public bool Play()
        {
            //Run until all invaders killed or invader reaches end
            int remainingInvaders = _invaders.Length;

            while (remainingInvaders > 0)
            {
                //Each tower has opp to fire on invaders
                foreach (Tower tower in Towers)
                {
                    tower.FireOnIvaders(_invaders);
                }

                //Count and move active invaders
                remainingInvaders = 0;
                foreach (Invader invader in _invaders)
                {
                    if (invader.IsActive)
                    {
                        invader.Move();

                        if (invader.HasScored)
                        {
                            return false;
                        }

                        remainingInvaders++;
                    }
                }
            }

            return true;
        }
    }
}