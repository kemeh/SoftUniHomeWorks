using System;

namespace _10.UnicodeCharacters
{
    class UnicodeCharacters
    {
        static void Main()
        {
            string input = Console.ReadLine().Trim();

            foreach(var charc in input)
            {
                Console.Write("\\u{0:x4}", (uint)charc);
            }
            Console.WriteLine();
        }
    }
}
