using System;
using System.Collections.Generic;
using System.Text;

namespace RPGMechanics.Objects.TypeHero.Classes
{
    class Priest : Cloth
    {
        internal int health = 250;
        internal double heal = 100;
        internal int dps = 60;

        public Priest()
        {

        }

        public double Pristdmg(int valuedmg)
        {
            return TakeDmg(health, valuedmg);
        }

        public double Heal()
        {
            return Deffender(health, heal);
        }

        public void WordOfPowerShield()
        {
            Takeover = 55;
        }

    }
}
