using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame.WeaponModels
{
    class Blade : Weapon
    {
        public Blade()
        {
            Damage = 2;
        }

        public override int DealDamage(int victimHealth)
        {
            return victimHealth -= Damage;
        }
    }
}
