using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsolenspiel
{
    internal class Actor : Entity
    {
        private Controller control;

        private int gold;
        private int attack;

        public Actor(Controller control, int gold, int attack, int health)
        {
            this.control = control;
            this.gold = gold;
            this.attack = attack;
            this.health = health;
        }
    
        public bool decide()
        {
            return false;
        }

        public void statOutput()
        {
            Console.WriteLine($"Player\tHealth: {this.health}\tAttack: {this.attack}\tGold: {this.gold}");
        }
        public void attacks(Enemy enemy)
        {
            enemy.subtractHealth(attack);
            Console.WriteLine($"Player attacks Enemy for {attack}");
        }

        public void subtractHealth(int value)
        {
            health -= value;
        }

        public int getHealth()
        {
            return health;
        }

        public void setHealth(int value)
        {
            this.health = value;
        }

        public int getGold()
        {
            return gold;
        }
        public void setGold(int value)
        {
            this.gold = value;
        }

        public int getAttack()
        {
            return attack;
        }
        public void setAttack(int value)
        {
            this.gold = value;
        }


        public int getPosition(string axis)
        {
            if (axis == "x")
            {
                return positionX;
            }
            else
            {
                return positionY;
            }
        }
        public void setPosition(int x=0, int y=0)
        {
            this.positionX = x;
            this.positionY = y;
        }

    }
}
