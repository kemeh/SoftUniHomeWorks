using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ActionPrint
{
    class ActionPrint
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToList();

            Action<string> action = s => Console.WriteLine($"Sir {s}");
            Action<List<string>> ac = l => l.ForEach(action);

            ac(input);
        }
    }
}