using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Palindromes
{
    class Palindromes
    {
        static void Main()
        {
            var words = Console.ReadLine().Split(new[] {',', ' ', '?', '!', '.'}, StringSplitOptions.RemoveEmptyEntries);

            var result = new SortedSet<string>();

            foreach (var w in words)
            {
                if (isPalindrome(w))
                {
                    result.Add(w);
                }
            }

            Console.WriteLine($"[{string.Join(", ", result)}]");
        }

        private static bool isPalindrome(string input)
        {
            int length = input.Length;

            for (int i = 0; i < length / 2; i++)
            {
                if (input[i] != input[length - i - 1])
                    return false;
            }
            return true;
        }
    }
}
