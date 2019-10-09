using PatternInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class Help : Pattern
    {
        List<string> patterns = new List<string>()
        {
            "strategy"
        };

        public void Initiate()
        {
            Console.Write("Available patterns are: ");
            patterns.ForEach(i => Console.Write("{0} ", i));
            Console.WriteLine("\nTo initiate each, just type the name in");
        }
    }
}
