using System;
using System.Collections.Generic;
using System.Text;

namespace RPGMechanics.Objects.TypeHero.Classes
{
    class Rogue : Skin
    {
        private int health = 220;

        public Rogue()
        {

        }

        public double Roguedmg(int valuedmg)
        {
            return TakeDmg(health, valuedmg);
        }

        public int HitInTheBack(int classHealth)
        {
            return classHealth - 45;
        }

        public void ScarletViolet()
        {
            health = health + 30;
        }
    }
}
