using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ReverseNumbersWithStack
{
    class ReverseNumbersWithStack
    {
        static void Main()
        {
            var input = Console.ReadLine()
                .Split(new char[] {' ', '\t', '\n'}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var stack = new Stack<int>(input);

            while (stack.Count > 0)
            {
                Console.Write(stack.Pop() + " ");
            }
        }
    }
}
