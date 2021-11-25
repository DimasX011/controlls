using System;
using System.Collections.Generic;
using System.Text;
using RPGMechanics.Objects.TypeHero.Classes;
using RPGMechanics.Objects.TypeHero;

namespace RPGMechanics
{
    class Player
    {
        DeathKing death = new DeathKing();
        DemonHunter demonHunter = new DemonHunter();
        Druid druid = new Druid();
        Hunter hunter = new Hunter();
        Mage mage = new Mage();
        Monk monk = new Monk();
        Paladin paladin = new Paladin();
        Priest priest = new Priest();
        Rogue rogue = new Rogue();
        Shaman shaman = new Shaman();
        Warlock warlock = new Warlock();
        Warrior warrior = new Warrior();
             
        internal int dmhdps = 0;
        Lats lats = new Lats();
        object obj;
        public string name;
        internal double health;
        internal int clarses;
        internal double valueheal;
        internal object classes;
        Damage dmg = new Damage();
        public Player(string answer)
        {
            name = answer;
            switch (name)
            {
                case "1":
                    this.health = death.health;
                    this.obj = death;
                    this.clarses = death.resistancedmg;
                    this.dmhdps = death.dps;
                    this.valueheal = death.heal;
                    break;
                case "2":
                    this.health = demonHunter.health;
                    this.obj = demonHunter;
                    this.clarses = demonHunter.resistancedmg;
                    this.dmhdps = demonHunter.dps;
                    this.valueheal = demonHunter.heal;
                    break;
                case "3":
                    this.health = druid.health;
                    this.obj = druid;
                    this.clarses = druid.resistancedmg;
                    this.dmhdps = (int)druid.dps;
                    this.valueheal = druid.heal;
                    break;
                case "4":
                    this.health = hunter.health;
                    this.obj = hunter;
                    this.clarses = hunter.resistancedmg;
                    this.dmhdps = (int)hunter.dps;
                    this.valueheal = hunter.heal;
                    break;
                case "5":
                    this.health = mage.health;
                    this.obj = mage;
                    this.clarses = mage.resistancedmg;
                    this.dmhdps = (int)mage.dps;
                    this.valueheal = mage.heal;
                    break;
                case "6":
                    this.health = monk.health;
                    this.obj = monk;
                    this.clarses = monk.resistancedmg;
                    this.dmhdps = (int)monk.dps;
                    this.valueheal = monk.heal;
                    break;
                case "7":
                    this.health = paladin.health;
                    this.obj = paladin;
                    this.clarses = paladin.resistancedmg;
                    this.dmhdps = (int)paladin.dps;
                    this.valueheal = paladin.heal;
                    break;
                case "8":
                    this.health = priest.health;
                    this.obj = priest;
                    this.clarses = priest.resistancedmg;
                    this.dmhdps = (int)priest.dps;
                    this.valueheal = priest.heal;
                    break;
                case "9":
                    this.health = rogue.health;
                    this.obj = rogue;
                    this.clarses = rogue.resistancedmg;
                    this.dmhdps = (int)rogue.dps;
                    this.valueheal = rogue.heal;
                    break;
                case "10":
                    this.health = shaman.health;
                    this.obj = shaman;
                    this.clarses = shaman.resistancedmg;
                    this.dmhdps = (int)shaman.dps;
                    this.valueheal = shaman.heal;
                    break;
                case "11":
                    this.health = warlock.health;
                    this.obj = warlock;
                    this.clarses = warlock.resistancedmg;
                    this.dmhdps = (int)warlock.dps;
                    this.valueheal = warlock.heal;
                    break;
                case "12":
                    this.health = warrior.health;
                    this.obj = warrior;
                    this.clarses = warrior.resistancedmg;
                    this.dmhdps = (int)warrior.dps;
                    this.valueheal = warrior.heal;
                    break;


            }
            
        }

        public void status()
        {
            Console.WriteLine($"Здоровье персонажа:{health}");
        }

        public double Damaging(double playerheath2, double damage)
        {
           return playerheath2 = dmg.TakeDamage(playerheath2, damage, clarses);
        }

        public double Deffender(double plahealth1, double value)
        {
            return plahealth1 = dmg.Deffender(plahealth1, value);
        }
    }
}
