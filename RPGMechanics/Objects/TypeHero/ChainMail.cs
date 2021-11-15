using System;
using System.Collections.Generic;
using System.Text;

namespace RPGMechanics.Objects.TypeHero
{
    class ChainMail
    {
        int resistancedmg = 12;
        public ChainMail()
        {

        }
        protected double TakeDmg(int Classhealth, double valuedmg)
        {
            Damage dmg = new Damage();
            return dmg.TakeDamage(Classhealth, valuedmg, resistancedmg);
        }
    }
}
