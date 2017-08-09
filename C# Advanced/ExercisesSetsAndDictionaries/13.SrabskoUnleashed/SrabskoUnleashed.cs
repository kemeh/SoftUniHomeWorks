using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _13.SrabskoUnleashed
{
    class SrabskoUnleashed
    {
        static void Main()
        {
            var venues = new Dictionary<string, Dictionary<string, long>>();
            
            var pattern = @"(([a-zA-Z]+\s){1,3})@(([a-zA-Z]+\s){1,3})(\d+)\s(\d+)";

            var command = Console.ReadLine().Trim();

            while (command.ToLower() != "end")
            {
                var match = Regex.Match(command, pattern);

                if (match.Success)
                {
                    var singer = match.Groups[1].Value.Trim();
                    var venue = match.Groups[3].Value.Trim();
                    var ratePerTicket = int.Parse(match.Groups[5].Value);
                    var ticketsCount = int.Parse(match.Groups[6].Value);

                    if (!venues.ContainsKey(venue))
                    {
                        venues.Add(venue, new Dictionary<string, long>());
                    }

                    if (!venues[venue].ContainsKey(singer))
                    {
                        venues[venue].Add(singer, 0);
                    }

                    venues[venue][singer] += (ratePerTicket * ticketsCount);
                }

                command = Console.ReadLine().Trim();
            }

            foreach (var venue in venues)
            {
                Console.WriteLine(venue.Key);

                foreach (var singer in venue.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                }
            }
        }
    }
}
