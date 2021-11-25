using System;
using System.Collections.Generic;
using System.Text;

namespace RPGMechanics.Objects.TypeHero.Classes
{
    class Monk : Skin
    {
        internal int health = 220;
        internal double heal = 50;
        internal int dps = 60;

        public Monk()
        {

        }

        public double Monkdmg(int valuedmg)
        {

            return TakeDmg(health, valuedmg);
        }

        public double Heal()
        {
            return Deffender(health, heal);
        }
    }
}
