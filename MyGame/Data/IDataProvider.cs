using System;
using System.Collections.Generic;
using System.Text;
using MyGame.CharacterModels;
using MyGame.ShieldModels;
using MyGame.WeaponModels;

namespace MyGame.Data
{
    interface IDataProvider
    {
        Killer GetKiller();

        Victim GetVictim(double health);

        Weapon ChooseWeapon(Killer killer);

        double GetHealth();

        Shield ChooseShield(Victim victim);
    }
}
