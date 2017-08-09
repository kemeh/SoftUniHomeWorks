using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MultiplyBigNumber
{
    class MultiplyBigNumber
    {
        static void Main()
        {
            string firstNumString = Console.ReadLine().Trim();
            int multiplier = int.Parse(Console.ReadLine());

            var remind = 0;
            var result = new List<int>();

            for (int i = firstNumString.Length - 1; i >= 0; i--)
            {
                var multipliedNumber = (int.Parse(firstNumString[i].ToString()) * multiplier) + remind;

                var valueToAdd = multipliedNumber % 10;
                result.Add(valueToAdd);

                remind = multipliedNumber / 10;
            }
            if (remind != 0)
            {
                result.Add(remind);
            }

            result.Reverse();            

            if (result.Count == 1)
            {
                Console.WriteLine(0);
            }
            else
            {                
                Console.WriteLine(string.Join("", result).TrimStart('0'));
            }           
        }
    }
}
