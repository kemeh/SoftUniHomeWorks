using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.MagicExchangeableWords
{
    class MagicExchangeableWords
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            var result = AreExchangeable(input[0], input[1]).ToString().ToLower();
            Console.WriteLine(result);

        }

        private static bool AreExchangeable(string first, string second)
        {
            var letters = new Dictionary<char, char>();
            var length = Math.Min(first.Length, second.Length);

            for (int i = 0; i < length; i++)
            {
                var firstChar = first[i];
                var secondChar = second[i];

                if (!letters.ContainsKey(firstChar))
                {
                    if (letters.ContainsValue(secondChar))
                    {
                        return false;
                    }

                    letters.Add(firstChar, secondChar);
                }
                else
                {
                    if (letters[firstChar] != secondChar)
                    {
                        return false;
                    }
                }
            }

            if (first.Length == second.Length)
            {
                return true;
            }

            string substring = String.Empty;

            if (first.Length > second.Length)
            {
                substring = first.Substring(length);
            }
            else
            {
                substring = second.Substring(length);
            }

            foreach (var c in substring)
            {
                if (!letters.Keys.Contains(c) && !letters.Values.Contains(c))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
