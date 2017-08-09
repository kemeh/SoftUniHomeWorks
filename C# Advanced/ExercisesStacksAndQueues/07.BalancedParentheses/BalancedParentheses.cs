using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.BalancedParentheses
{
    class BalancedParentheses
    {
        static void Main()
        {
            var input = Console.ReadLine();

            var openedParentheses = new Stack<char>();

            var openingParentheses = new char[] {'{', '[', '('};

            for (int i = 0; i < input.Length; i++)
            {
                if (openingParentheses.Contains(input[i]))
                {
                    openedParentheses.Push(input[i]);
                }
                else
                {
                    if (openedParentheses.Count == 0)
                    {
                        Console.WriteLine("NO");
                        return;
                    }

                    switch (input[i])
                    {
                        case '}':
                            if (openedParentheses.Pop() != '{')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            break;
                        case ')':
                            if (openedParentheses.Pop() != '(')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            break;
                        case ']':
                            if (openedParentheses.Pop() != '[')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            break;

                    }
                }
            }

            Console.WriteLine("YES");
        }
    }
}
