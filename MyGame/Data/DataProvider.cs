using System;
using MyGame.CharacterModels;
using MyGame.ShieldModels;
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

        public double GetHealth()
        {
            Console.WriteLine("Enter health for victim: ");
            string health = Console.ReadLine();

            return Convert.ToDouble(health);
        }

        public Killer GetKiller()
        {
            Console.WriteLine("Killer's name: ");
            string characterName = Console.ReadLine();

            return new Killer(characterName);
        }

        public Victim GetVictim(double health)
        {
            Console.WriteLine("Victim's name: ");
            string characterName = Console.ReadLine();

            return new Victim(characterName, health);
        }
        public Shield ChooseShield(Victim victim)
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