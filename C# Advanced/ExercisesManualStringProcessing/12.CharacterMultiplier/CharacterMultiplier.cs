using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.CharacterMultiplier
{
    class CharacterMultiplier
    {
        static void Main()
        {
            var tokens = Console.ReadLine().Split();

            var firstString = tokens[0].Trim();
            var secondString = tokens[1].Trim();

            var length = Math.Min(firstString.Length, secondString.Length);

            var sum = 0;

            for (int i = 0; i < length; i++)
            {
                sum += (int) firstString[i] * (int) secondString[i];
            }

            if (firstString.Length > secondString.Length)
            {
                for (int i = length; i < firstString.Length; i++)
                {
                    sum += (int) firstString[i];
                }
            }
            else if(secondString.Length > firstString.Length)
            {
                for (int i = length; i < secondString.Length; i++)
                {
                    sum += (int)secondString[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
