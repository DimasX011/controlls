using System;
using System.Collections.Generic;
using System.Text;

namespace RPGMechanics.Objects.TypeHero
{
    class Skin
    {
        public int resistancedmg = 8;
        public Skin()
        {

        }
        protected double TakeDmg(int Classhealth, double valuedmg)
        {
            Damage dmg = new Damage();
            return dmg.TakeDamage(Classhealth, valuedmg, resistancedmg);
        }

        protected double Deffender(double health, double value)
        {
            Damage dmg = new Damage();
            return dmg.Deffender(health, value);
        }

    }
}
