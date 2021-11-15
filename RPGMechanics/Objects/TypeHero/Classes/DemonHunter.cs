using System;
using System.Collections.Generic;
using System.Text;

namespace RPGMechanics.Objects.TypeHero.Classes
{
    class DemonHunter : Skin 
    {
        const int health = 250;

        public DemonHunter()
        {

        }

        public double DHdmg(int valuedmg)
        {

            return TakeDmg(health, valuedmg);
        }
    }
}
