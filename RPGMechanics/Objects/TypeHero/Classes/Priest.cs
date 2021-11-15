using System;
using System.Collections.Generic;
using System.Text;

namespace RPGMechanics.Objects.TypeHero.Classes
{
    class Priest : Cloth
    {
        private int health = 250;

        public Priest()
        {

        }

        public double Pristdmg(int valuedmg)
        {
            return TakeDmg(health, valuedmg);
        }

        public void WordOfPowerShield()
        {
            Takeover = 55;
        }

        public int PiercingTheMind(int classHealth)
        {
            return classHealth - 47;
        }

        public void FasterHealing()
        {
            health = health + 35;
        }
    }
}
