using System;
using System.Collections.Generic;
using System.Text;

namespace RPGMechanics.Objects.TypeHero.Classes
{
    class Rogue : Skin
    {
        internal double health = 220;
        internal int dps = 60;
        internal double heal = 45;

        public Rogue()
        {

        }

        public double Roguedmg(double valuedmg)
        {
            return TakeDmg((int)health, valuedmg);
        }

        public double Heal()
        {
            return Deffender(health, heal);
        }
    }
}
