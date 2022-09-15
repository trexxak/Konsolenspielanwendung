using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsolenspiel
{
    internal class Event
    {
        private int eventId;
        public Enemy randomEnemy;
        public Trader randomTrader;
        public Event(int id)
        {
            this.eventId = id;
        }


        public NPC newNPC()
        {
            Random random = new Random();
            if (random.Next(0, 5) == 0)
            {
                return newTrader();
            }
            else if (random.Next(0,5) == 3)
            {
                return newOasis();
            }
            else
            {
                return newEnemy();
            }
        }

        public Healer newOasis()
        {
            switch (eventId)
            {
                case 0:
                    Healer oasis = new(1);
                    Console.WriteLine("An Oasis!");
                    return oasis;

                case 1:
                    Healer mimic = new(-1);
                    Console.WriteLine("An Oasis... wait, no!");
                    return mimic;

                case 2:
                    Healer coolOasis = new(3);
                    Console.WriteLine("An Oasis!");
                    return coolOasis;

                default:
                    Healer noOasis = new(0);
                    Console.WriteLine("...");
                    return noOasis;
            }
        }

        public Trader newTrader()
        {
            switch (eventId)
            {
                case 0:
                    Trader trader = new(1, 1);
                    Console.WriteLine("A Trader appeared!");
                    return trader;
                case 1:
                    Trader expensiveTrader = new(2, 1);
                    Console.WriteLine("A Trader appeared!");
                    return expensiveTrader;
                case 2:
                    Trader coolTrader = new(0, 2);
                    Console.WriteLine("A Trader appeared!");
                    return coolTrader;
                default:
                    Trader nothing = new(0, 0);
                    Console.WriteLine("Woops! Nothing happened...");
                    return nothing;
            }
        }

        public Enemy newEnemy()
        {
            switch (eventId)
            {
                case 0:
                    Enemy skelly = new(1, 2);
                    Console.WriteLine("A Skeleton appeared!");
                    return skelly;
                case 1:
                    Enemy slime = new(1, 3);
                    Console.WriteLine("A Slime appeared!");
                    return slime;
                case 2:
                    Enemy oger = new(2, 1);
                    Console.WriteLine("An Oger appeared!");
                    return oger;
                default:
                    Enemy something = new(0, 0);
                    Console.WriteLine("Something went wrong!");
                    return something;
            }
        }
    }
}
