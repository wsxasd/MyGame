using System;
using System.Collections.Generic;
using System.Text;
using MyGame.CharacterModels;
using MyGame.ShieldModels;
using MyGame.WeaponModels;

namespace MyGame.Data
{
    interface IConsoleReader
    {
        Killer GetKiller();

        Victim GetVictim(int health);

        Weapon ChooseWeapon();

        int GetHealth();

        Shield ChooseShield();
    }
}
