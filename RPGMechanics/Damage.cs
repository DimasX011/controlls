using System;
using System.Collections.Generic;
using System.Text;

namespace RPGMechanics
{
    public class Damage
    {
        public Damage()
        {

        }
        public double  TakeDamage(double Health, double damage,double clasres)
        {
           return Health = Health - resistance(damage,clasres);
        }
        private double resistance(double value1, double value2)
        {
            return System.Math.Round((double)(value1-(value1 * (value2 / 100))));
        }

        public double Deffender(double healthheal, double valuehealth)
        {
            return healthheal + valuehealth;
        }
    }
}
