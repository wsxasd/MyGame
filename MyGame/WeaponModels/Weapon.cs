using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame.WeaponModels
{
    class Weapon
    {
        public double Damage { get; set; } = 1;
        public virtual double DealDamage(double victimHealth)
        {
            return victimHealth -= Damage;
        }
    }
}
