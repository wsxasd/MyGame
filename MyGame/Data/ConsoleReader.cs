using System;
using MyGame.CharacterModels;
using MyGame.ShieldModels;
using MyGame.WeaponModels;

namespace MyGame.Data
{
    class ConsoleReader : IConsoleReader
    {
        public Weapon ChooseWeapon()
        {
            Console.WriteLine("Choose weapon");
            Console.WriteLine("1 - gun\n2 - blade");
            string weapon = Console.ReadLine();
            switch(weapon)
            {
                case ("1"):
                    return new Gun();
                case ("2"):
                    return new Blade();
                default:
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
            string characterName = Console.ReadLine();

            return new Killer(characterName);
        }

        public Victim GetVictim(int health)
        {
            Console.WriteLine("Victim's name: ");
            string characterName = Console.ReadLine();

            return new Victim(characterName, health);
        }
        public Shield ChooseShield()
        {
            Console.WriteLine("Choose shield");
            Console.WriteLine("1 - chain mail\n2 - body armor");
            string shield = Console.ReadLine();
            switch (shield)
            {
                case ("1"):
                    return new ChainMail();
                case ("2"):
                    return new BodyArmor();
                default:
                    return new Shield();
            }
        }
    }
}