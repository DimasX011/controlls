using System;
using System.Collections.Generic;
using System.Text;

namespace RPGMechanics.Objects.TypeHero.Classes
{
  
    class Paladin : Lats
    {
    
        private int health = 250;
        bool buble = false;

        public Paladin()
        {

        }

        public double Paladindmg(int valuedmg)
        {
           return TakeDmg(health, valuedmg);
        }
      
        public void Bubl()
        {
            int currentHealth = health;
            buble = true;
            while(buble == true)
            {
                health = currentHealth;
            }
        }



    }
}
