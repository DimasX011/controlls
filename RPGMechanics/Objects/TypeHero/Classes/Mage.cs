using System;
using System.Collections.Generic;
using System.Text;

namespace RPGMechanics.Objects.TypeHero.Classes
{
    class Mage : Cloth
    {
        internal int health = 220;
        internal int heal = 50;
        internal int dps = 60;

        public Mage()
        {

        }

        public double Magedmg(int valuedmg)
        {

            return TakeDmg(health, valuedmg);
        }

        public double Heal()
        {
            return Deffender(health, heal);
        }
    }
}
