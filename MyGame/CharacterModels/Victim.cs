using MyGame.ShieldModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame.CharacterModels
{
    class Victim : Character
    {
        public double Health { set; get; }
        public int StepsToRun { get; set; }
        public double Shield { get; set; }
        public Victim(string name, double health) : base(name)
        {
            Health = health;
        }

        public override void Voice()
        {
            Console.WriteLine("Help");
        }
        public double Armor(Shield shield, double victimHealth)
        {
            return shield.Armor(victimHealth);
        }

    }
}
