using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _05.ConvertFromBase_NToBase_10
{
    class ConvertFromBaseNToBase10
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            var baseNumber = int.Parse(input[0]);
            var number = input[1].ToCharArray();
            long power = number.Length - 1;
            var index = 0;
            var result = new List<BigInteger>();

            if (baseNumber < 2)
            {
                baseNumber = 2;
            }
            else if (baseNumber > 10)
            {
                baseNumber = 10;
            }

            while (power >= 0)
            {
                decimal currentNum = (decimal)(Math.Pow(baseNumber, power));

                BigInteger resultNum = int.Parse(number[index].ToString()) * (BigInteger)currentNum;

                result.Add(resultNum);
                power--;
                index++;
            }
            BigInteger resultNumber = 0;

            foreach (var n in result)
            {
                resultNumber += n;
            }

            Console.WriteLine(resultNumber);
        }
    }
}
