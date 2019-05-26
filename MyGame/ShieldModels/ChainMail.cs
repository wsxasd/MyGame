using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame.ShieldModels
{
    class ChainMail : Shield
    {
        public ChainMail()
        {
            Protection = 1;
        }

        public override int Armor(int victimHealth)
        {
            return victimHealth += Protection;
        }
    }
}
