using System;
using System.Collections.Generic;
using System.Text;

namespace RPGMechanics.Objects.TypeHero.Classes
{
    class Warlock : Cloth
    {
        internal int health = 300;
        internal int dps = 60;
        internal double heal = 55;

        public Warlock()
        {

        }

        public double Warlockdmg(int valuedmg)
        {

            return TakeDmg(health, valuedmg);
        }

        public double Heal()
        {
            return Deffender(health, heal);
        }
    }
}
