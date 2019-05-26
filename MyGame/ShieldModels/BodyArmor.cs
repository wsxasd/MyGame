using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame.ShieldModels
{
    class BodyArmor : Shield
    {
        public BodyArmor()
        {
            Protection = 2;
        }

        public override int Armor(int victimHealth)
        {
            return victimHealth += Protection;
        }
    }
}
