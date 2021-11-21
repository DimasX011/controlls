using System;
using System.Collections.Generic;
using System.Text;

namespace RPGMechanics.Objects.TypeHero
{
    class Lats
    {
     
        public int resistancedmg = 16;
        public Lats()
        {
            
        }
        protected double TakeDmg(double Classhealth,double valuedmg)
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
