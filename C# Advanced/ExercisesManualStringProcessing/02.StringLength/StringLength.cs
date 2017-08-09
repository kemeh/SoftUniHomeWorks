using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.StringLength
{
    class StringLength
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var result = string.Empty;

            if (input.Length >= 20)
            {
                result = input.Substring(0, 20);
            }
            else
            {
                result = input;
            }

            Console.WriteLine(result.PadRight(20, '*'));
        }
    }
}
