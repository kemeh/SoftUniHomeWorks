using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.SentenceExtractor
{
    class SentenceExtractor
    {
        static void Main()
        {
            string keyword = Console.ReadLine().Trim();

            string pattern = @"[\w+? ]*?(?<!\w)" + keyword + @"(?!\w).*?[!|.|?]";
            var regex = new Regex(pattern);

            string text = Console.ReadLine();

            var matches = regex.Matches(text);

            foreach (Match m in matches)
            {
                Console.WriteLine(m.Value);
            }
        }
    }
}
