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
            Controller control = new();
            Actor player = new(control,0,1,10);


            while (player.getHealth() > 0)
            {
                Event _event = randomEvent();

                NPC npc = _event.newNPC();

                if (npc is Enemy)
                {
                    Enemy enemy = (Enemy)npc;
                    while (enemy.getHealth() > 0)
                    {
                        player.statOutput();
                        enemy.statOutput();

                        enemy.attacks(player);
                        player.attacks(enemy);

                        player.statOutput();
                        enemy.statOutput();
                        Console.WriteLine("\n");
                    }
                    Console.WriteLine("Enemy died.\n");
                    Console.WriteLine("Player finds 1 gold.\n\n");
                    player.setGold(player.getGold() + 1);
                }
                else if (npc is Trader)
                {
                    Trader trader = (Trader)npc;
                    trader.upgrade(player);
                }
                else if (npc is Healer)
                {
                    Healer healer = (Healer)npc;
                    healer.heal(player);
                }


            }

            Console.WriteLine("\n\nGAME OVER!");
        }

        static public Event randomEvent()
        {
            return new Event(rng.Next(0, 3));
        }

    }
}
