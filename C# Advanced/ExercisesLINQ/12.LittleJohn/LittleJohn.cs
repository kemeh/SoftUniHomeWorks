using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _12.LittleJohn
{
    class LittleJohn
    {
        static void Main()
        {
            var arrowCount = ReadData();
            var result = Encrypt(arrowCount);

            Console.WriteLine(result);
        }

        private static decimal Encrypt(Dictionary<string, int> arrowCount)
        {
            var concatenatedNum = string.Empty;

            foreach (var arrow in arrowCount)
            {
                concatenatedNum += arrow.Value.ToString();
            }

            var binaryNum = Convert.ToString(int.Parse(concatenatedNum), 2);
            var reversedBinaryNum = ReverseString(binaryNum);

            var concatedBinary = binaryNum + reversedBinaryNum;

            var dec = 0;
            for (int i = 0; i < concatedBinary.Length; i++)
            {
                // we start with the least significant digit, and work our way to the left
                if (concatedBinary[concatedBinary.Length - i - 1] == '0') continue;
                dec += (int)Math.Pow(2, i);
            }

            return dec;
        }

        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        private static Dictionary<string, int> ReadData()
        {
            string smallArrow = ">----->";
            string mediumArrow = ">>----->";
            string largeArrow = ">>>----->>";

            var data = new Dictionary<string, int>()
            {
                {smallArrow, 0 },
                {mediumArrow, 0 },
                {largeArrow, 0 }
            };          

            for (int i = 0; i < 4; i++)
            {
                var input = Console.ReadLine();

                if (input.Contains(largeArrow))
                {
                    data[largeArrow] += Regex.Matches(input, largeArrow).Count;

                    input = Regex.Replace(input, largeArrow, " ");
                }

                if (input.Contains(mediumArrow))
                {
                    data[mediumArrow] += Regex.Matches(input, mediumArrow).Count;

                    input = Regex.Replace(input, mediumArrow, " ");
                }

                if (input.Contains(smallArrow))
                {
                    data[smallArrow] += Regex.Matches(input, smallArrow).Count;
                }
            }

            return data;
        }
    }
}
