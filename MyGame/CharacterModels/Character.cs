using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame.CharacterModels
{
    abstract class Character
    {
        public string Name { get; set; }

        public Character(string name)
        {
            Name = name;
        }

        public abstract void Voice();
    }

}
