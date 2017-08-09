using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.MatchPhoneNumber
{
    class MatchPhoneNumber
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"[+]{1}359{1}((\s|-){1})2\1[0-9]{3}\1[0-9]{4}\b");

            string input = Console.ReadLine();

            List<string> result = new List<string>();

            while (!input.ToLower().Equals("end"))
            {
                Match match = regex.Match(input);

                if (match.Success)
                {
                    result.Add(input);
                }

                input = Console.ReadLine();
            }

            foreach (var r in result)
            {
                Console.WriteLine(r);
            }
        }
    }
}
