using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame.ShieldModels
{
    class BodyArmor : Shield
    {
        public BodyArmor()
        {
            Protection = 1;
        }

        public override double Armor(double victimHealth)
        {
            return victimHealth += Protection;
        }
    }
}
