using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsolenspiel
{
    internal class Controller
    {
        private Actor player;
        void goUp()
        {
            player.setPosition(player.getPosition("y") + 1);
        }

        void goDown()
        {
            player.setPosition(player.getPosition("y") - 1);
        }

        void goLeft()
        {
            player.setPosition(player.getPosition("x") - 1);
        }

        void goRight()
        {
            player.setPosition(player.getPosition("x") + 1);
        }
    }
}
