using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame.CharacterModels
{
    class Victim : Character
    {
        public int Health { set; get; }
        public int StepsToRun { get; set; }
        public Victim(string name, int health) : base(name)
        {
            Health = health;
        }

        public override void Voice()
        {
            Console.WriteLine("Help");
        }
    }
}
