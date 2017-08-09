using System;
using System.Collections.Generic;

namespace _07.FixEmails
{
    class FixEmails
    {
        static void Main()
        {
            var allMails = new Dictionary<string, string>();

            while (true)
            {
                var name = Console.ReadLine();

                if (name.ToLower().Equals("stop"))
                {
                    break;
                }

                var email = Console.ReadLine();

                if (!allMails.ContainsKey(name))
                {
                    allMails.Add(name, null);
                }

                if (email.Substring(email.Length - 3).Equals(".us") || email.Substring(email.Length - 3).Equals(".uk"))
                {
                    allMails.Remove(name);
                }
                else
                {
                    allMails[name] = email;
                }
            }

            foreach (var mail in allMails)
            {
                Console.WriteLine($"{mail.Key} -> {mail.Value}");
            }
        }
    }
}
