using System;
using System.Collections.Generic;
using System.Text;

namespace RPGMechanics.Objects.TypeHero.Classes
{
    class DeathKing : Lats
    {
        const int health = 300;

        public DeathKing()
        {

        }

        public double DKdmg(int valuedmg)
        {

            return TakeDmg(health, valuedmg);
        }
    }
}
