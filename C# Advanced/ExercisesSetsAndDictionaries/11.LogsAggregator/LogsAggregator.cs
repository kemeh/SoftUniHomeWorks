using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.LogsAggregator
{
    class LogsAggregator
    {
        static void Main()
        {
            var lines = int.Parse(Console.ReadLine());

            var userLogs = new SortedDictionary<string, SortedDictionary<string, int>>();

            for (int i = 0; i < lines; i++)
            {
                var input = Console.ReadLine().Split(' ');

                var IP = input[0];
                var username = input[1];
                var duration = int.Parse(input[2]);

                if (!userLogs.ContainsKey(username))
                {
                    userLogs.Add(username, new SortedDictionary<string, int>());
                }

                if (!userLogs[username].ContainsKey(IP))
                {
                    userLogs[username].Add(IP, 0);
                }

                userLogs[username][IP] += duration;
            }

            foreach (var user in userLogs)
            {
                Console.Write($"{user.Key}: {user.Value.Values.Sum()} [");

                foreach (var ips in user.Value)
                {
                    if (ips.Key.Equals(user.Value.Keys.First()))
                    {
                        Console.Write(ips.Key);
                    }
                    else
                    {
                        Console.Write($", {ips.Key}");
                    }
                }
                Console.WriteLine("]");
            }
        }
    }
}
