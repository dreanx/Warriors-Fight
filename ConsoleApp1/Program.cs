using System;
using ConsoleApp1;

namespace HelloBob
{
    internal class HW
    {
        private static void Main(string[] args)
        {
            Warrior pierre = new Warrior("Pierre", 120, 30, 5);
            MagicWarrior ellen = new MagicWarrior("Ellen", 90, 15, 15, 60);

            Battle.StartFight(pierre, ellen);
            Console.ReadKey();
        }
    }
}