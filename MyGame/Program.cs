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
            DataProvider dataProvider = new DataProvider();
            
            double victimHealh = dataProvider.GetHealth();

            Victim victim = dataProvider.GetVictim(victimHealh);
            victim.StepsToRun = 10;
            Killer killer = dataProvider.GetKiller();

            Weapon weapon = dataProvider.ChooseWeapon(killer);
            Shield shield = dataProvider.ChooseShield(victim);

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
                else if (victim.Health > 0 && i >= victim.StepsToRun)
                {
                    Console.WriteLine("Victim escaped");
                    break;
                }
            }
        }
    }
}
