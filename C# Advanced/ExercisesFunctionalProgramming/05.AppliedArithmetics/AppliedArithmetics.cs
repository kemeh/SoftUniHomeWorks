using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.AppliedArithmetics
{
    class AppliedArithmetics
    {
        static void Main()
        {
            var input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var command = Console.ReadLine();

            Func<int, int> addFunc = n => n + 1;
            Func<int, int> multiplyFunc = n => n * 2;
            Func<int, int> subtractFunc = n => n - 1;
            Action<List<int>> printAction = n => Console.WriteLine(string.Join(" ", n));

            while (command != "end")
            {
                switch (command)
                {
                    case "add":
                        for (int i = 0; i < input.Count; i++)
                        {
                            input[i] = addFunc(input[i]);
                        }
                        break;
                    case "multiply":
                        for (int i = 0; i < input.Count; i++)
                        {
                            input[i] = multiplyFunc(input[i]);
                        }
                        break;
                    case "subtract":
                        for (int i = 0; i < input.Count; i++)
                        {
                            input[i] = subtractFunc(input[i]);
                        }
                        break;
                    case "print":
                        printAction(input);
                        break;
                }

                command = Console.ReadLine();
            }
        }
    }
}
