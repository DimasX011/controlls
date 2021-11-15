using System;
using System.Collections.Generic;
using System.Text;

namespace RPGMechanics.Objects.TypeHero.Classes
{
    class Hunter : ChainMail
    {
        const int health = 220;

        public Hunter()
        {

        }

        public double Huntdmg(int valuedmg)
        {

            return TakeDmg(health, valuedmg);
        }
    }
}
