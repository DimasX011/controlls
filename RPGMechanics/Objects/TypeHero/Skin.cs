using System;
using System.Collections.Generic;
using System.Text;

namespace RPGMechanics.Objects.TypeHero
{
    class Skin
    {
        int resistancedmg = 8;
        public Skin()
        {

        }
        protected double TakeDmg(int Classhealth, double valuedmg)
        {
            Damage dmg = new Damage();
            return dmg.TakeDamage(Classhealth, valuedmg, resistancedmg);
        }

    }
}
