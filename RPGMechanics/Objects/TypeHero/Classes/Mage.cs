using System;
using System.Collections.Generic;
using System.Text;

namespace RPGMechanics.Objects.TypeHero.Classes
{
    class Mage : Cloth
    {
        const int health = 220;

        public Mage()
        {

        }

        public double Magedmg(int valuedmg)
        {

            return TakeDmg(health, valuedmg);
        }
    }
}
