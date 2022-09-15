using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsolenspiel
{
    internal static class MainScene
    {
        static Random rng = new Random();
        static int randomNumber;

        static public void run()
        {

        }

        static public Event randomEvent()
        {
            return new Event(rng.Next(0, 3));
        }

    }
}
