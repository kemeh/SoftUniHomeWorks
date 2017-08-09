using System;
using System.Collections.Generic;

namespace _03.PeriodicTable
{
    class PeriodicTable
    {
        static void Main()
        {
            var input = int.Parse(Console.ReadLine());
            
            var elements = new SortedSet<string>();

            for (int i = 0; i < input; i++)
            {
                var temp = Console.ReadLine().Split(new char[] {' ', '\n', '\t'}, StringSplitOptions.RemoveEmptyEntries);

                foreach (var t in temp)
                {
                    elements.Add(t);
                }
            }

            Console.WriteLine(string.Join(" ", elements));
        }
    }
}
