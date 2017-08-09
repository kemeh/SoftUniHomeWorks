using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _07.ValidUsernames
{
    class ValidUsernames
    {
        static void Main()
        {
            string pattern = @"\b[a-zA-Z]\w{2,24}\b";
            Regex regex = new Regex(pattern);

            string text = Console.ReadLine();

            MatchCollection matches = regex.Matches(text);

            string firstResultString = string.Empty;
            string secondResultString = string.Empty;

            if (matches.Count >= 2)
            {
                int sum = 0;

               for (int i = 0; i < matches.Count - 1; i++)
                {
                    if (matches[i].Value.Length + matches[i + 1].Length > sum)
                    {
                        sum = matches[i].Value.Length + matches[i + 1].Length;

                        firstResultString = matches[i].Value;
                        secondResultString = matches[i + 1].Value;
                    }
                }

            }

            Console.WriteLine(firstResultString.Trim());
            Console.WriteLine(secondResultString.Trim());

        }
    }
}
