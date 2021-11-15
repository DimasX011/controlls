using System;
using RPGMechanics.Objects.TypeHero.Classes;

namespace RPGMechanics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Paladin paladin = new Paladin();
            double health = 0;
            health = paladin.Paladindmg(15);

            Console.WriteLine("Ваше здоровье:"+health);
            
        }
    }
}
