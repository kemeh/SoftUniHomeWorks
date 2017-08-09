using System;
using System.Collections.Generic;

namespace _04.CountSymbols
{
    class CountSymbols
    {
        static void Main()
        {
            var input = Console.ReadLine();

            var result = new SortedDictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!result.ContainsKey(input[i]))
                {
                    result[input[i]] = 0;
                }

                result[input[i]]++;
            }

            foreach (var r in result)
            {
                Console.WriteLine($"{r.Key}: {r.Value} time/s");
            }
        }
    }
}
