using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame.ShieldModels
{
    class Shield
    {
        public double Protection { get; set; } = 0.5;
        public virtual double Armor(double victimHealth)
        {
            return victimHealth += Protection;
        }
    }
}
