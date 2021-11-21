using System;
using System.Collections.Generic;
using System.Text;

namespace RPGMechanics.Objects.TypeHero.Classes
{
    class DeathKing : Lats
    {
        internal double health = 300;
        internal int dps = 65;
        internal double heal = 25;

        public DeathKing()
        {

        }

        public double DKdmg(double valuedmg)
        {
            return TakeDmg(health, valuedmg);
        }

        public double Vampiric()
        {
            return Deffender(health, heal);
        }
    }
}
