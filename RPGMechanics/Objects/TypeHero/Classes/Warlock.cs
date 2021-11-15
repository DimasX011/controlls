using System;
using System.Collections.Generic;
using System.Text;

namespace RPGMechanics.Objects.TypeHero.Classes
{
    class Warlock : Cloth
    {
        private int health = 300;

        public Warlock()
        {

        }

        public double Warlockdmg(int valuedmg)
        {

            return TakeDmg(health, valuedmg);
        }

        public double StealingLife(int classHealth)
        {
            classHealth = classHealth - 25;
            health = health + 15;
            return classHealth;
        }
    }
}
