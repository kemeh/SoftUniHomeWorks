using System;
using System.Collections.Generic;

namespace _01.UniqueUsernames
{
    class UniqueUsernames
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var usernames = new HashSet<string>();

            for (int i = 0; i < count; i++)
            {
                var username = Console.ReadLine().Trim();

                usernames.Add(username);
            }

            foreach (var username in usernames)
            {
                Console.WriteLine(username);
            }
        }
    }
}
