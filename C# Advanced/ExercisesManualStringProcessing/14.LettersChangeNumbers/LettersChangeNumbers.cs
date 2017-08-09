using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _14.LettersChangeNumbers
{
    class LettersChangeNumbers
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(new[] {' ', '\t', '\n'}, StringSplitOptions.RemoveEmptyEntries);

            decimal result = 0;

            foreach (var inp in input)
            {
                result += Calculate(inp);
            }

            Console.WriteLine($"{result:f2}");
        }

        private static decimal Calculate(string token)
        {
            char firstChar = token.First();
            char secondChar = token.Last();
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            decimal sum = 0;

            token = Regex.Replace(token, @"[a-zA-Z]", "");
            decimal number = decimal.Parse(token);

            if (char.IsUpper(firstChar))
            {
                sum = number / (Array.IndexOf(alpha, firstChar) + 1);
            }
            else
            {
                sum = number * (Array.IndexOf(alpha, char.ToUpper(firstChar)) + 1);
            }

            if (char.IsUpper(secondChar))
            {
                sum -= (Array.IndexOf(alpha, secondChar) + 1);
            }
            else
            {
                sum += (Array.IndexOf(alpha, char.ToUpper(secondChar)) + 1);
            }

            return sum;
        }
    }
}