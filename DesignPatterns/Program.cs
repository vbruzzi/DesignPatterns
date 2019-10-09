using PatternInterface;
using StrategyPattern;
using System;

namespace DesignPatterns
{
    class Program
    {

        static void Main(string[] args)
        {
            Pattern pattern = new Help();
            pattern.Initiate();

            while (true)
            {
                var x = Console.ReadLine().ToLower();

                switch(x)
                {
                    case "help":
                        pattern = new Help();
                        break;
                    case "strategy":
                        pattern = new Strategy();
                        break;
                    default:
                        Console.WriteLine("Unrecognized pattern. Type 'help' for more commands");
                        pattern = null;
                        break;

                }

                if (pattern == null)
                {
                    continue;
                } else
                {
                    pattern.Initiate();
                }
            }

            
            
        }
    }
}
