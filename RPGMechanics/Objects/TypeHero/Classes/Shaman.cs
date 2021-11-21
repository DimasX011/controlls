using System;
using System.Collections.Generic;
using System.Text;

namespace RPGMechanics.Objects.TypeHero.Classes
{
    class Shaman : ChainMail
    {
        internal int health = 220;
        internal int dps = 60;
        internal double heal = 65;

        public Shaman()
        {

        }

        public double Shamandmg(int valuedmg)
        {

            return TakeDmg(health, valuedmg);
        }

        public double Heal()
        {
            return Deffender(health, heal);
        }
    }
}
