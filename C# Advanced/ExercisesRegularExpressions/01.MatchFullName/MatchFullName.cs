using System;
using System.Text.RegularExpressions;

namespace _01.MatchFullName
{
    class MatchFullName
    {
        static void Main()
        {
            string pattern = @"\b([A-Z]{1}[a-z]+?) ([A-Z]{1}[a-z]+?)\b";
            Regex regex = new Regex(pattern);
            string input = Console.ReadLine();

            string text = string.Empty;

            while (input != "end")
            {
                text += " " + input;
                input = Console.ReadLine();
            }

            var matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }

        }
    }
}
