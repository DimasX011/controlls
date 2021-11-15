using System;
using System.Collections.Generic;
using System.Text;

namespace RPGMechanics.Objects.TypeHero.Classes
{
    class Shaman : ChainMail
    {
        private int health = 220;

        public Shaman()
        {

        }

        public double Shamandmg(int valuedmg)
        {

            return TakeDmg(health, valuedmg);
        }

        public int lightning(int classHealth)
        {
           return classHealth = classHealth - 50;
        }

        public void Healing()
        {
            health = health + 25;
        }
    }
}
