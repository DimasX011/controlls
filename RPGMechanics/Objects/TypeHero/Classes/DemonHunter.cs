using System;
using System.Collections.Generic;
using System.Text;

namespace RPGMechanics.Objects.TypeHero.Classes
{
    class DemonHunter : Skin 
    {
        internal double health = 250;
        internal int dps = 60;
        internal double heal = 45;

        public DemonHunter()
        {

        }

        public double DHdmg(int valuedmg)
        {
            return TakeDmg((int)health, valuedmg);
        }

        public double Metamorphosis()
        {
            dps = dps + 25;
            return Deffender(health, heal);
        }
    }
}
