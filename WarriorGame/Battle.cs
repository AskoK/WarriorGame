using System;
namespace WarriorGame
{
    public class Battle
    {
        public static void StartFight(Warrior warrior1, Warrior warrior2)
        {
            while(true)
            {
                if(GetAttackResult(warrior1, warrior2) == "Game Over")
                {
                    Console.WriteLine("Game Over!");
                    break;
                }

                if (GetAttackResult(warrior2, warrior1) == "Game Over")
                {
                    Console.WriteLine("Game Over!");
                    break;
                }

            }
        }

        public static string GetAttackResult(Warrior warriorA, Warrior warriorB)
        {
            double warrAAttkAmt = warriorA.Attack();
            double warrBBlkAmt = warriorB.Block();

            double dmg2WarB = warrAAttkAmt - warrBBlkAmt;

            if (dmg2WarB > 0)
            {
                warriorB.Health = warriorB.Health - dmg2WarB;
            }
            else dmg2WarB = 0;

            Console.WriteLine("{0} warrior Attacks {1} and deals {2} Damage", warriorA.Name, warriorB.Name, dmg2WarB);

            Console.WriteLine("{0} Has {1} Health\n", warriorB.Name, warriorB.Health);

            if (warriorB.Health <= 0)
            {
                Console.WriteLine("{0} has Died and {1} is Victorius\n", warriorB.Name, warriorA.Name);
                return "Game Over";
            }
            else return "Fight Again";

        }
    
    }
}
