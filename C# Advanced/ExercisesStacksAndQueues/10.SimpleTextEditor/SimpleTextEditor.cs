using System;
using System.Collections.Generic;

namespace _10.SimpleTextEditor
{
    class SimpleTextEditor
    {
        static void Main()
        {
            var commandsCount = int.Parse(Console.ReadLine());

            var prevCommands = new Stack<string>();

            var text = string.Empty;

            for (int i = 0; i < commandsCount; i++)
            {
                var commands = Console.ReadLine()
                    .Split(new char[] {' ', '\t'}, StringSplitOptions.RemoveEmptyEntries);

                switch (commands[0])
                {
                    case "1":
                        prevCommands.Push(text);
                        text += commands[1];
                        break;
                    case "2":
                        prevCommands.Push(text);
                        text = text.Substring(0, text.Length - int.Parse(commands[1]));
                        break;
                    case "3":
                        Console.WriteLine(text[int.Parse(commands[1]) - 1]);
                        break;
                    case "4":
                        text = prevCommands.Pop();
                        break;

                }

            }
        }
    }
}
