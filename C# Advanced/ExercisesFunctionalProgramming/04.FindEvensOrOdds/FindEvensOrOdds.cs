using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FindEvensOrOdds
{
    class FindEvensOrOdds
    {
        static void Main()
        {
            var input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var command = Console.ReadLine();
            Predicate<int> evenOrOdd = null;

            switch (command)
            {
                case "even":
                    evenOrOdd = n => n % 2 == 0;
                    break;
                case "odd":
                    evenOrOdd = n => n % 2 != 0;
                    break;
            }

            for (int i = input[0]; i <= input[1]; i++)
            {
                if (evenOrOdd.Invoke(i))
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
