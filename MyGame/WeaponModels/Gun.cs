using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame.WeaponModels
{
    class Gun : Weapon
    {
        public Gun()
        {
            Damage = 3;
        }

        public override int DealDamage(int victimHealth)
        {
            return victimHealth -= Damage;
        }
    }
}
