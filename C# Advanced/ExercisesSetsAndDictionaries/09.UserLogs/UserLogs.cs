using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.UserLogs
{
    class UserLogs
    {
        static void Main()
        {
            var allUsers = new SortedDictionary<string, Dictionary<string, int>>();

            var input = Console.ReadLine();

            while (input != "end")
            {
                var commandLine = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                var IP = commandLine[0]
                    .Split('=')
                    .Last();

                var messages = 0;
                var username = commandLine[2]
                    .Split('=')
                    .Last();

                if (!allUsers.ContainsKey(username))
                {
                    allUsers.Add(username, new Dictionary<string, int>());
                }

                if (!allUsers[username].ContainsKey(IP))
                {
                    allUsers[username].Add(IP,0);
                }

                allUsers[username][IP] += 1;

                input = Console.ReadLine();
            }

            foreach (var user in allUsers)
            {
                Console.WriteLine($"{user.Key}:");

                foreach (var log in user.Value)
                {
                    Console.Write($"{log.Key} => {log.Value}");
                    if (log.Key.Equals(user.Value.Keys.Last()))
                    {
                        Console.Write(".");
                    }
                    else
                    {
                        Console.Write(", ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
