﻿using System;

namespace _01.ReverseString
{
    class ReverseString
    {
        static void Main()
        {
            var input = Console.ReadLine().ToCharArray();

            Array.Reverse(input);

            var result = new string(input);

            Console.WriteLine(result);
        }
    }
}
