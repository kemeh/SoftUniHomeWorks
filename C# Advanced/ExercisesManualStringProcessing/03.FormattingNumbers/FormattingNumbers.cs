using System;

namespace _03.FormattingNumbers
{
    class FormattingNumbers
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(new []{' ', '\t', '\n'}, StringSplitOptions.RemoveEmptyEntries);

            var firstNumber = int.Parse(input[0]);
            var secondNumber = decimal.Parse(input[1]);
            var thirdNumber = decimal.Parse(input[2]);

            var firstnumToBin = Convert.ToString(firstNumber, 2);
            if (firstnumToBin.Length > 10)
            {
                firstnumToBin = firstnumToBin.Substring(0, 10);
            }

            Console.WriteLine($"|{firstNumber.ToString("X").PadRight(10)}" +
                              $"|{firstnumToBin.PadLeft(10, '0')}" +
                              $"|{secondNumber.ToString("F2").PadLeft(10)}" +
                              $"|{thirdNumber.ToString("F3").PadRight(10)}|");
        }
    }
}
