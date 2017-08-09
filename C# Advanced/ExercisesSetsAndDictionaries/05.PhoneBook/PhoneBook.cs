using System;
using System.Collections.Generic;

namespace _05.PhoneBook
{
    class PhoneBook
    {
        static void Main()
        {
            var phoneBook = new Dictionary<string, string>();

            var input = Console.ReadLine();

            while (input != "search")
            {
                var tokens = input.Split('-');

                if (!phoneBook.ContainsKey(tokens[0]))
                {
                    phoneBook[tokens[0]] = tokens[1];
                }
                
                phoneBook[tokens[0]] = tokens[1];

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "stop")
            {
                if (phoneBook.ContainsKey(input.Trim()))
                {
                    Console.WriteLine($"{input} -> {phoneBook[input]}");
                }
                else
                {
                    Console.WriteLine($"Contact {input} does not exist.");
                }

                input = Console.ReadLine();
            }
        }
    }
}
