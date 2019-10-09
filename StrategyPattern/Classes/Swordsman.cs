using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Characters
{
    public class Swordsman : Character
    {
        public Swordsman(string name)
        {
            this.name = name;
            this.characterClass = "Swordsman";
            this.weaponBehavior = new SwordBehavior();
        }
    }
}
