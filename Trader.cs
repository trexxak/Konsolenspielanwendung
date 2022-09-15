using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsolenspiel
{
    internal class Trader : NPC
    {
        void upgrade(Actor actor)
        {
            actor.setGold(actor.getGold()-1);
            actor.setAttack(actor.getAttack()+1);
        }
    }
}
