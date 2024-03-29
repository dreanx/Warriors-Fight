﻿using System;

namespace ConsoleApp1
{
    internal class Battle
    {
        public static void StartFight(Warrior warrior1, Warrior warrior2)
        {
            while (true)
            {
                if (GetAttackResult(warrior1, warrior2) == "Game Over")
                {
                    Console.WriteLine("GAME OVER");
                    break;
                }

                if (GetAttackResult(warrior2, warrior1) == "Game Over")
                {
                    Console.WriteLine("GAME OVER");
                    break;
                }
            }
        }

        public static string GetAttackResult(Warrior warriorA, Warrior warriorB)
        {
            double warAAtkAmt = warriorA.Attack();
            double warBBlkAmt = warriorB.Block();

            double dmg2WarB = warAAtkAmt - warBBlkAmt;

            if (dmg2WarB > 0)
            {
                warriorB.Health = warriorB.Health - dmg2WarB;
            }
            else dmg2WarB = 0;

            Console.WriteLine("{0} attacks {1} and deals {2} damage",
                warriorA.Name,
                warriorB.Name,
                dmg2WarB);

            Console.WriteLine("{0} has {1} health\n",
                warriorB.Name,
                warriorB.Health);

            if (warriorB.Health <= 0)
            {
                Console.WriteLine("{0} has died and {1} is the Winner\n",
                    warriorB.Name,
                    warriorA.Name);
                return "Game Over";
            }
            else { return "Fight Again"; }
        }
    }
}