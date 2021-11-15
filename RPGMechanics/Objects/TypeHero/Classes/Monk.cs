using System;
using System.Collections.Generic;
using System.Text;

namespace RPGMechanics.Objects.TypeHero.Classes
{
    class Monk : Skin
    {
        const int health = 220;

        public Monk()
        {

        }

        public double Monkdmg(int valuedmg)
        {

            return TakeDmg(health, valuedmg);
        }
    }
}
