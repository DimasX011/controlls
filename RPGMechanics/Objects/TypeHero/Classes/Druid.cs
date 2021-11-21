using System;
using System.Collections.Generic;
using System.Text;

namespace RPGMechanics.Objects.TypeHero.Classes
{
    class Druid : Skin 
    {
        internal int health = 250;
        internal double heal = 50;
        internal double dps = 55;


        public Druid()
        {

        }

        public double Druiddmg(int valuedmg)
        {

            return TakeDmg(health, valuedmg);
        }

        public double Heal()
        {
            return Deffender(health, heal);
        }
    }
}
