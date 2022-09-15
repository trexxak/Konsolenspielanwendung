using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsolenspiel
{
    internal class Enemy : NPC
    {
        public void subtractHealth(int value)
        {
            health -= value;
        }
    }
}
