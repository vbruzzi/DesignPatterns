using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class BowBehavior : WeaponBehavior
    {
        public void Attack()
        {
            Console.WriteLine("I shoot my arrow");
        }
    }
}
