using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MaximumElement
{
    class MaximumElement
    {
        static void Main()
        {
            var count = int.Parse(Console.ReadLine());
            var maxNumber = 0;
            var stack = new Stack<int>();

            for (int i = 0; i < count; i++)
            {
                var command = Console.ReadLine()
                    .Split(new char[] {' ', '\n', '\t'}, StringSplitOptions.RemoveEmptyEntries);

                switch (command[0])
                {
                    case "1":
                        var number = int.Parse(command[1]);
                        stack.Push(number);

                        if (number > maxNumber)
                        {
                            maxNumber = number;
                        }                        
                        break;
                    case "2":
                        stack.Pop();

                        if (stack.Count > 0)
                        {
                            maxNumber = stack.Max();    
                        }
                        break;
                    case "3":
                        Console.WriteLine(maxNumber);
                        break;
                }
            }
        }
    }
}
