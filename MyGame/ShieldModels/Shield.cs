using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame.ShieldModels
{
    class Shield
    {
        public int Protection { get; set; } = 0;
        public virtual int Armor(int victimHealth)
        {
            return victimHealth += Protection;
        }
    }
}
