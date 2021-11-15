using System;
using System.Collections.Generic;
using System.Text;

namespace RPGMechanics.Objects.TypeHero
{
    class Cloth
    {
        int resistancedmg = 2;
        protected int Takeover = 0;
        public Cloth()
        {

        }
        protected double TakeDmg(int Classhealth, double valuedmg)
        {
            Damage dmg = new Damage();
            return dmg.TakeDamage(Classhealth + Takeover, valuedmg, resistancedmg);
        }
    }
}
