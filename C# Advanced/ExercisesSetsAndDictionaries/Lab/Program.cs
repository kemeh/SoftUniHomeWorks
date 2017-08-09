using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab
{
    class Program
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

            var students = new SortedDictionary<string, double>();
            var count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                var name = Console.ReadLine();
                var grades = Console.ReadLine()
                    .Split(new char[] {' ', '\n', '\t'},StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToList();

                students.Add(name, grades.Average());
            }

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Key} is graduated with {student.Value}");
            }
        }
    }
}
