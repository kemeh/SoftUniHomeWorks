using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.StackFibonacci
{
    class StackFibonacci
    {
        static void Main()
        {
            var index = int.Parse(Console.ReadLine());

            var initSequence = new long[] {0, 1};
            var fibSequence = new Stack<long>(initSequence.Reverse());

            for (int i = 0; i < index; i++)
            {
                var prevNum = fibSequence.Peek();
                var nextNum = fibSequence.Pop() + fibSequence.Peek();
                 
                fibSequence.Push(prevNum);
                fibSequence.Push(nextNum);
            }

            Console.WriteLine(fibSequence.Pop());
        }
    }
}
