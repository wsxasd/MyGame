using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame.WeaponModels
{
    class Gun : Weapon
    {
        public Gun()
        {
            Damage = 4;
        }

        public override double DealDamage(double victimHealth)
        {
            return victimHealth -= Damage;
        }
    }
}
