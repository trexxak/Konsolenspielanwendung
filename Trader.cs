using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsolenspiel
{
    internal class Trader : NPC
    {
        private int upgradeCost;
        private int upgradeLvl;
        public Trader(int upgradeCost, int upgradeLvl)
        {
            this.upgradeCost = upgradeCost;
            this.upgradeLvl = upgradeLvl;
        }

        public void upgrade(Actor actor)
        {
            if (actor.getGold() > 0)
            {
                actor.setGold(actor.getGold()-this.upgradeCost);
                actor.setAttack(actor.getAttack()+this.upgradeLvl);
                Console.WriteLine($"Trader trades you {upgradeLvl} attack for {upgradeCost} Gold.");
            }
            else
            {
                Console.WriteLine("The trader is disgusted by your poorness.");
            }
            Console.WriteLine("\n\n");
        }
    }
}
