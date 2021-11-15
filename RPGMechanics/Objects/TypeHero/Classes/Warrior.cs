using System;
using System.Collections.Generic;
using System.Text;

namespace RPGMechanics.Objects.TypeHero.Classes
{
    class Warrior : Lats
    {
        const int health = 250;

        public Warrior()
        {

        }

        public double Warriordmg(int valuedmg)
        {

            return TakeDmg(health, valuedmg);
        }

        public void Block()
        {
            resistancedmg = 90;
        }
         public void EndEffect()
        {
            resistancedmg = 16;
        }

        public int ShieldStrike(int Classhealth)
        {
            return Classhealth - 50;
        }

    }
}
