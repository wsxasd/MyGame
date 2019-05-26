using System;
using System.Collections.Generic;
using System.Text;
using MyGame.CharacterModels;
using MyGame.WeaponModels;

namespace MyGame.Data
{
    interface IDataProvider
    {
        Killer GetKiller();

        Victim GetVictim(int health);

        Weapon ChooseWeapon(Killer killer);

        int GetHealth();
    }
}
