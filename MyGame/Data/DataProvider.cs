using System;
using MyGame.CharacterModels;
using MyGame.WeaponModels;

namespace MyGame.Data
{
    class DataProvider : IDataProvider
    {
        public Weapon ChooseWeapon(Killer killer)
        {
            Console.WriteLine("Choose weapon");
            Console.WriteLine("1 - gun\n2 - blade");
            string weapon = Console.ReadLine();
            if (weapon == "1")
            {
                return new Gun();
            }
            else if (weapon == "2")
            {
                return new Blade();
            } else
            {
                return new Weapon(); 
            }
        }

        public int GetHealth()
        {
            Console.WriteLine("Enter health for victim: ");
            string health = Console.ReadLine();

            return Convert.ToInt32(health);
        }

        public Killer GetKiller()
        {
            Console.WriteLine("Killer's name: ");
            var characterName = Console.ReadLine();

            return new Killer(characterName);
        }

        public Victim GetVictim(int health)
        {
            Console.WriteLine("Victim's name: ");
            var characterName = Console.ReadLine();

            return new Victim(characterName, health);
        }
    }
}