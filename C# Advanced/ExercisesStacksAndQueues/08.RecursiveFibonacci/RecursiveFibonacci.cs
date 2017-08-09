using System;

namespace _08.RecursiveFibonacci
{
    class RecursiveFibonacci
    {
        private static long[] fibNumbers;

        static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            fibNumbers = new long[number];

            var result = GetFibonacci(number);

            Console.WriteLine(result);
        }

        private static long GetFibonacci(int number)
        {
            if (number <= 2)
            {
                return 1;
            }

            if (fibNumbers[number - 1] != 0)
            {
                return fibNumbers[number - 1];
            }

            return fibNumbers[number - 1] = GetFibonacci(number - 1) + GetFibonacci(number - 2);
        }
    }
}
