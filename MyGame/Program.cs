using MyGame.CharacterModels;
using MyGame.Data;
using MyGame.ShieldModels;
using MyGame.WeaponModels;
using System;

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleReader consoleReader = new ConsoleReader();
            
            int victimHealh = consoleReader.GetHealth();

            Victim victim = consoleReader.GetVictim(victimHealh);
            victim.StepsToRun = 10;
            Killer killer = consoleReader.GetKiller();

            Weapon weapon = consoleReader.ChooseWeapon(killer);
            Shield shield = consoleReader.ChooseShield(victim);

            for (int i = 0; i < victim.StepsToRun; i++)
            {
                killer.Voice();
                victim.Voice();
                victim.Health = victim.Armor(shield, victim.Health);
                victim.Health = killer.Attack(weapon, victim.Health);

                if (victim.Health <= 0)
                {
                    Console.WriteLine("Victim died");
                    break;
                }   
            }

        }
    }
}
