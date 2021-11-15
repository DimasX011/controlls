using System;
using System.Collections.Generic;
using System.Text;

namespace RPGMechanics.Objects.TypeHero
{
    class Lats
    {
     
        protected int resistancedmg = 16;
        public Lats()
        {
            
        }
        protected double TakeDmg(int Classhealth,double valuedmg)
        {
          Damage dmg = new Damage();
          return dmg.TakeDamage(Classhealth, valuedmg, resistancedmg);
        }
        
    }
}
