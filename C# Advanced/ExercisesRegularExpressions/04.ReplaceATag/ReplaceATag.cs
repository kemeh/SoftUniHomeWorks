using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.ReplaceATag
{
    class ReplaceATag
    {
        static void Main()
        {
            var input = Console.ReadLine();

            var sb = new StringBuilder();

            while (!input.ToLower().Equals("end"))
            {
                sb.AppendLine(input);
                    
                input = Console.ReadLine();
            }

            string pattern = @"<a (href=.+?)>(.+?)<\/a>";

            var result = Regex.Replace(sb.ToString(), pattern,
                match => $"[URL {match.Groups[1]}]{match.Groups[2]}[/URL]");

            Console.WriteLine(result);

        }
    }
}
