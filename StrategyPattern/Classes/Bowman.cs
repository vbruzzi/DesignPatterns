using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Characters
{
    public class Bowman : Character
    {
        public Bowman(string name)
        {
            this.name = name;
            this.characterClass = "Bowman";
            this.weaponBehavior = new BowBehavior();
        }
    }
}
