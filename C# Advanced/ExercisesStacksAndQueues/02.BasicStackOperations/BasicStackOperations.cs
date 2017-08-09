using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BasicStackOperations
{
    class BasicStackOperations
    {
        static void Main()
        {
            var input = Console.ReadLine()
                .Split(new char[] {' ', '\n', 't'}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var popInput = Console.ReadLine()
                .Split(new char[] { ' ', '\n', 't' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var stack = new Stack<int>();
            var elementsToPush = input[0];

            if (popInput.Length < input[0])
            {
                elementsToPush = popInput.Length;
            }

            for (int i = 0; i < elementsToPush; i++)
            {
                stack.Push(popInput[i]);
            }

            for (int i = 0; i < input[1]; i++)
            {
                stack.Pop();
            }

            if (stack.Count < 1)
            {
                Console.WriteLine(0);
            }
            else if (stack.Contains(input[2]))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}
