using System;
using System.Collections.Generic;
using System.Text;

namespace RPGMechanics.Objects.TypeHero.Classes
{
    class Warrior : Lats
    {
        internal
            int health = 250;
        internal int dps = 60;
        internal double heal = 60;

        public Warrior()
        {

        }

        public double Warriordmg(int valuedmg)
        {

            return TakeDmg(health, valuedmg);
        }

        public void Block()
        {
            resistancedmg = 90;
        }

        public double Heal()
        {
            Block();
            return Deffender(health, heal);
        }

    }
}
