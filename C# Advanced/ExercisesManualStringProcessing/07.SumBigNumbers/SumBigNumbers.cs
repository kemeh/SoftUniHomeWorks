using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.SumBigNumbers
{
    class SumBigNumbers
    {
        static void Main()
        {
            string firstNumString = Console.ReadLine().Trim();
            string secondNumString = Console.ReadLine().Trim();

            var length = Math.Max(firstNumString.Length, secondNumString.Length);

            firstNumString = firstNumString.PadLeft(length, '0');
            secondNumString = secondNumString.PadLeft(length, '0');

            var remind = 0;
            var firstNumber = 0;
            var secondNumber = 0;
            var result = new List<int>();

            for (int i = length - 1; i >= 0; i--)
            {
                firstNumber = int.Parse(firstNumString[i].ToString());
                secondNumber = int.Parse(secondNumString[i].ToString());

                var sum = firstNumber + secondNumber + remind;

                result.Add(sum % 10);
                remind = sum / 10;
            }

            if (remind != 0)
            {
                result.Add(remind);
            }

            result.Reverse();
            Console.WriteLine(string.Join("", result).TrimStart('0'));
        }
    }
}
