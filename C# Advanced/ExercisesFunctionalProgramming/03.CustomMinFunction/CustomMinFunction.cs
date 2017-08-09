using System;
using System.Linq;

namespace _03.CustomMinFunction
{
    class CustomMinFunction
    {
        static void Main()
        {
            var input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Func<int[], int> func = n => n.Min();

            Console.WriteLine(func(input));
        }
    }
}
