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

        public bool decide()
        {
            return false;
        }

        public void attacks(Enemy enemy)
        {
            enemy.subtractHealth(attack);
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
