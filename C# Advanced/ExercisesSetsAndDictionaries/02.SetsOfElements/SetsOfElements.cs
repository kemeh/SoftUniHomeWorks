using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SetsOfElements
{
    class SetsOfElements
    {
        static void Main()
        {
            var setsLengths = Console.ReadLine()
                .Split(new char[] {' ', '\n', '\t'}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var length = setsLengths[0] + setsLengths[1];
            var setOne = new HashSet<int>();
            var setTwo = new SortedSet<int>();

            for (int i = 0; i < length; i++)
            {
                var temp = int.Parse(Console.ReadLine());

                if (setOne.Contains(temp))
                {
                    setTwo.Add(temp);
                }

                setOne.Add(temp);
            }

            Console.WriteLine(string.Join(" ", setTwo));
        }
    }
}
