﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.SeriesOfLetters
{
    class SeriesOfLetters
    {
        static void Main()
        {
            var input = Console.ReadLine();

            Console.WriteLine(Regex.Replace(input, "([A-Za-z])\\1+", "$1"));
        }
    }
}
