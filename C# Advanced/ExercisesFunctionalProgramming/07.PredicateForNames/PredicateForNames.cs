using System;

namespace _07.PredicateForNames
{
    class PredicateForNames
    {
        static void Main(string[] args)
        {
            var lenght = int.Parse(Console.ReadLine());

            string[] names = Console.ReadLine().Split();

            Predicate<string> fit = n => n.Length <= lenght;

            foreach (var name in names)
            {
                if (fit(name))
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
