using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsolenspiel
{
    internal class Enemy : NPC
    {
        private int attack;
        public Enemy(int attack, int health)
        {
            this.attack = attack;
            this.health = health;
        }

        public int getHealth()
        {
            return health;
        }

        public void statOutput()
        {
            Console.WriteLine($"Enemy\tHealth: {this.health}\tAttack: {this.attack}");
        }

        public void subtractHealth(int value)
        {
            health -= value;
        }

        public void attacks(Actor actor)
        {
            actor.subtractHealth(attack);
            Console.WriteLine($"Enemy attacks Player for {attack}");
        }
    }
}
