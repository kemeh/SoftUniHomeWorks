using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.BasicQueueOperations
{
    class BasicQueueOperations
    {
        static void Main(string[] args)
        {
            var input =
                Console.ReadLine()
                    .Split(new char[] {' ', '\n', '\t'}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

            var inputToEnqueue =
                Console.ReadLine()
                    .Split(new char[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

            var enqueueCount = input[0];
            var queue = new Queue<int>();

            if (inputToEnqueue.Length < enqueueCount)
            {
                enqueueCount = inputToEnqueue.Length;
            }

            for (int i = 0; i < enqueueCount; i++)
            {
                queue.Enqueue(inputToEnqueue[i]);
            }

            for (int i = 0; i < input[1]; i++)
            {
                queue.Dequeue();
            }

            if (queue.Count > 0)
            {
                if (queue.Contains(input[2]))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(queue.Min());
                }
            }
            else
            {
                Console.WriteLine(0);
            }

        }
    }
}
