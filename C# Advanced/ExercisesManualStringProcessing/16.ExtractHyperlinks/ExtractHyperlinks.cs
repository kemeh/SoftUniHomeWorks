﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.ExtractHyperlinks
{
    class ExtractHyperlinks
    {
        static void Main()
        {
            var line = Console.ReadLine();
            var text = string.Empty;

            while (line != "END")
            {
                text += " " + line;

                line = Console.ReadLine();
            }
        }
    }
}
