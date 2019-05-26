using MyGame.CharacterModels;
using MyGame.Data;
using MyGame.WeaponModels;
using System;

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            DataProvider dataProvider = new DataProvider();
            
            int victimHealh = dataProvider.GetHealth();

            Victim victim = dataProvider.GetVictim(victimHealh);
            victim.StepsToRun = 10;
            Killer killer = dataProvider.GetKiller();

            Weapon weapon = dataProvider.ChooseWeapon(killer);

            for (int i = 0; i < victim.StepsToRun; i++)
            {
                killer.Voice();
                victim.Voice();
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
