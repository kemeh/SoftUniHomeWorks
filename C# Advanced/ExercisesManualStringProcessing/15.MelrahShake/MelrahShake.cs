using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.MelrahShake
{
    class MelrahShake
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var pattern = Console.ReadLine();

            bool shake = true;

            while (shake)
            {
                if (input.IndexOf(pattern) != -1 && input.LastIndexOf(pattern) != -1 && input.IndexOf(pattern) != input.LastIndexOf(pattern))
                {
                    var firstSub = input.IndexOf(pattern);
                    var secondSub = input.LastIndexOf(pattern);                   

                    input = input.Remove(secondSub, pattern.Length);
                    input = input.Remove(firstSub, pattern.Length);

                    Console.WriteLine("Shaked it.");
                }
                else
                {
                    shake = false;
                }

                if (pattern.Length > 1)
                {
                    pattern = pattern.Remove(pattern.Length / 2, 1);
                }
                else
                {
                    shake = false;
                }
                
            }

            Console.WriteLine("No shake.");
            Console.WriteLine(input);
        }
    }
}