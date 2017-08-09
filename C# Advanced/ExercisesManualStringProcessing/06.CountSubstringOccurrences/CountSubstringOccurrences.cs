using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CountSubstringOccurrences
{
    class CountSubstringOccurrences
    {
        static void Main()
        {
            var inputText = Console.ReadLine().ToLower();
            var subS = Console.ReadLine().ToLower();
            var count = 0;
            var removeLength = subS.Length - 1;
            if (subS.Length == 1)
            {
                removeLength = 1;
            }

            var startIndex = inputText.IndexOf(subS);

            while (startIndex != -1)
            {
                inputText = inputText.Remove(startIndex, removeLength);
                count++;
                startIndex = inputText.IndexOf(subS);
            }

            Console.WriteLine(count);
        }
    }
}
