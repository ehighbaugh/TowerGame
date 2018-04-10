using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Returns: true if the player wins, false if they lose
public bool Play()
{
    //Run until all invaders killed or invader reaches end
    int remainingInvaders = _invaders.Length;

    while(remainingInvaders > 0)
    {
        //Each tower has opp to fire on invaders
        foreach(Tower tower in towers)
        {
            tower.FireOnIvaders(_invaders);
        }
    }
}