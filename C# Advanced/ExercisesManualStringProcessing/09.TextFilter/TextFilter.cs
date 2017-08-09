using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.TextFilter
{
    class TextFilter
    {
        static void Main()
        {
            var bannedWords = Console.ReadLine().Split(new[] {',',' '}, StringSplitOptions.RemoveEmptyEntries);

            var text = Console.ReadLine();

            foreach (var word in bannedWords)
            {
                var replacement = new string('*', word.Length);

                text = text.Replace(word, replacement);
            }

            Console.WriteLine(text);
        }
    }
}
