using System;
using System.Linq;

namespace _08.CustomComparator
{
    class CustomComparator
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Array.Sort(input, (x, y) =>
            {
                if (x % 2 != 0 && y % 2 == 0)
                {
                    return 1;
                }
                if (x % 2 == 0 && y % 2 != 0)
                {
                    return -1;
                }
                if (x > y)
                {
                    return 1;
                }
                if (x < y)
                {
                    return -1;
                }

                return 0;
            });

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
