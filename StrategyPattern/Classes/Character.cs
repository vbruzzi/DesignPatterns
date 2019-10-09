using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Characters
{
    public class Character
    {
        public string name { get; set; }
        public string characterClass { get; set; }
        public int health { get; set; }
        public WeaponBehavior weaponBehavior { get; set; }

        public void Greeting()
        {
            Console.WriteLine("Hello, I am " + this.name + " I am a " + this.characterClass);
        }

        public void Attack()
        {
            this.weaponBehavior.Attack();
        }
    }
}
