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
            ConsoloReader consoloReader = new ConsoloReader();
            
            int victimHealh = consoloReader.GetHealth();

            Victim victim = consoloReader.GetVictim(victimHealh);
            victim.StepsToRun = 10;
            Killer killer = consoloReader.GetKiller();

            Weapon weapon = consoloReader.ChooseWeapon(killer);
            Shield shield = consoloReader.ChooseShield(victim);

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
