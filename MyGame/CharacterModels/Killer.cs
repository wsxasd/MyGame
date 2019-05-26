using MyGame.WeaponModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame.CharacterModels
{
    class Killer : Character
    {
        public Killer(string name) : base(name)
        {

        }

        public override void Voice()
        {
            Console.WriteLine("I'll kill you");
        }

        public int Attack(Weapon weapon, int victimHealth)
        {
            return weapon.DealDamage(victimHealth);
        }
    }
}
