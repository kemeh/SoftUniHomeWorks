using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.ListOfPredicates
{
    class ListOfPredicates
    {
        static void Main()
        {
            int lastNumber = int.Parse(Console.ReadLine());

            int[] dividers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Distinct()
                .ToArray();

            Func<int, int, bool> filter = (x, y) => x % y == 0;

            List<int> result = new List<int>();

            for (int i = 1; i <= lastNumber; i++)
            {
                bool hasPassed = true;

                for (int j = 0; j < dividers.Length; j++)
                {
                    if (!filter(i, dividers[j]))
                    {
                        hasPassed = false;
                        break;
                    }
                }

                if (hasPassed)
                {
                    result.Add(i);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}