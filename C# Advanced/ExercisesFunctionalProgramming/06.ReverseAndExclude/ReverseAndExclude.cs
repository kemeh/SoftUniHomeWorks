using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ReverseAndExclude
{
    class ReverseAndExclude
    {
        static void Main()
        {
            var input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int divider = int.Parse(Console.ReadLine());

            Predicate<int> isDivisible = n => n % divider != 0;

            List<int> result = new List<int>();

            foreach (var n in input.Reverse())
            {
                if (isDivisible(n))
                {
                    result.Add(n);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
