using System;
using System.Collections.Generic;

namespace _05.SequenceWithQueue
{
    class SequenceWithQueue
    {
        static void Main(string[] args)
        {
            var input = long.Parse(Console.ReadLine());

            var members = 50;
            var queue = new Queue<long>();
            var result = new long[members];

            queue.Enqueue(input);

            for (int i = 0; i < members; i++)
            {
                long current = queue.Dequeue();

                result[i] = current;

                queue.Enqueue(current + 1);
                queue.Enqueue(2 * current + 1);
                queue.Enqueue(current + 2);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
