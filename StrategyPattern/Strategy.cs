using PatternInterface;
using StrategyPattern.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class Strategy : Pattern
    {
        // The strategy pattern allows you to encapsulate families of algorithms and make them interchangeable
        // All characters have an Attack method (even if the Attack does nothing)
        // But they all differ fron one another
        // By generalizing it into "WeaponBehavior", we can implement different attacks on each class 
         
        Character swordsman = new Swordsman("John");
        Character bowman = new Bowman("Vitor");

        public void Initiate()
        {
            swordsman.Greeting();
            swordsman.Attack();


            bowman.Greeting();
            bowman.Attack();
        }
    }
}
