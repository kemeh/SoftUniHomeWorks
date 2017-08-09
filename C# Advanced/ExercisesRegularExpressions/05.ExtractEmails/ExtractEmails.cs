using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.ExtractEmails
{
    class ExtractEmails
    {
        static void Main()
        {
            var input = Console.ReadLine();

            var regex = new Regex(@"\b([a-z]{1,}[\w-\.]*?)@[a-z-]+?(\.[a-z-]+)(\.[a-z-]+){0,1}");

            var result = regex.Matches(input);

            foreach (Match match in result)
            {
                Console.WriteLine(match.Value.TrimStart('.'));
            }
        }
    }
}
