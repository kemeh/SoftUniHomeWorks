using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PredicateParty
{
    class PredicateParty
    {
        static void Main()
        {
            var guests = Console.ReadLine()
                .Split()
                .ToList();

            var command = Console.ReadLine();

            while (command != "Party!")
            {
                ExecuteAction(guests, command);

                command = Console.ReadLine();
            }

            if (guests.Any())
            {
                Console.WriteLine($"{string.Join(", ", guests)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        private static List<string> ExecuteAction(List<string> guests, string command)
        {
            var result = guests;

            var tokens = command.Split();

            var action = tokens[0];
            var criteria = tokens[1];
            var token = tokens[2];

            Predicate<string> startsWith = n => n.Substring(0, token.Length) == token;
            Predicate<string> endsWith = n => n.Substring(n.Length - token.Length, token.Length) == token;
            Predicate<string> isSameLenght = n => n.Length == int.Parse(token);

            Func<string, string, bool> b = (m, n) =>
            {
                return (m == "StartsWith" && startsWith(n))
                       || (m == "EndsWith" && (m == "EndsWith" && endsWith(n))
                           || (m == "Length" && isSameLenght(n)));
            };

            if (action == "Remove")
            {
                foreach (var guest in guests)
                {
                    if (b(criteria, guest))
                    {
                        result.Remove(guest);
                    }
                }
            }
            if (action == "Double")
            {
                foreach (var guest in guests)
                {
                    if (b(criteria, guest))
                    {
                        result.Add(guest);
                    }
                }
            }
            
            guests = result;

            return guests;
        }
    }
}