using System;
using System.Collections.Generic;
using System.Numerics;

namespace _04.ConvertFromBase_10ToBase_N
{
    class ConvertFromBase10ToBaseN
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(new[] {' ','\t', '\n'}, StringSplitOptions.RemoveEmptyEntries);
            var baseToConvert = int.Parse(input[0]);
            var number = BigInteger.Parse(input[1]);
            BigInteger reminder = 0;
            var result = new List<BigInteger>();

            if (baseToConvert < 2)
            {
                baseToConvert = 2;
            }
            else if (baseToConvert > 10)
            {
                baseToConvert = 10;
            }

            while (number != 0)
            {
                reminder = number % baseToConvert;
                number = number / baseToConvert;
                
                result.Add(reminder);
            }
            result.Reverse();

            Console.WriteLine(string.Join("", result));
        }
    }
}
