using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class SwordBehavior : WeaponBehavior
    {
        public void Attack()
        {
            Console.WriteLine("I swing my sword");
        }
    }
}
