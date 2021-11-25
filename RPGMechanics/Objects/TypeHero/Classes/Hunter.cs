using System;
using System.Collections.Generic;
using System.Text;

namespace RPGMechanics.Objects.TypeHero.Classes
{
    class Hunter : ChainMail
    {
        internal int health = 220;
        internal double heal = 45;
        internal int dps = 60;

        public Hunter()
        {

        }

        public double Huntdmg(int valuedmg)
        {

            return TakeDmg(health, valuedmg);
        }

        public double Heal()
        {
            return Deffender(health, heal);
        }
    }
}
