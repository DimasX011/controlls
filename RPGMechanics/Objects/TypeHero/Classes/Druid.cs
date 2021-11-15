using System;
using System.Collections.Generic;
using System.Text;

namespace RPGMechanics.Objects.TypeHero.Classes
{
    class Druid : Skin 
    {
        const int health = 250;

        public Druid()
        {

        }

        public double Druiddmg(int valuedmg)
        {

            return TakeDmg(health, valuedmg);
        }
    }
}
