using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsolenspiel
{
    internal class Healer : NPC
    {
        private int healAmount;

        public Healer(int healAmount)
        {
            this.healAmount = healAmount;
        }

        public void heal(Actor actor)
        {
            actor.setHealth(actor.getHealth() + this.healAmount);
            Console.WriteLine($"Oasis heals Player for {healAmount}.");
            Console.WriteLine("\n\n");

        }
    }
}
