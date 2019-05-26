using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame.ShieldModels
{
    class ChainMail : Shield
    {
        public ChainMail()
        {
            Protection = 0.75;
        }

        public override double Armor(double victimHealth)
        {
            return victimHealth += Protection;
        }
    }
}
