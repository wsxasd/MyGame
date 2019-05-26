using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame.WeaponModels
{
    class Weapon
    {
        public int Damage { get; set; } = 1;
        public virtual int DealDamage(int victimHealth)
        {
            return victimHealth -= Damage;
        }
    }
}
