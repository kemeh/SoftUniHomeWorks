using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.StudentsEnrolledIn2014Or2015
{
    class StudentsEnrolled
    {
        static void Main()
        {
            var input = Console.ReadLine();

            List<int[]> grades = new List<int[]>();

            while (input.ToLower() != "end")
            {
                var tokens = input.Split(' ').ToArray();

                var facNum = tokens[0];

                var currentGrades = tokens
                    .Skip(1)
                    .Select(int.Parse)
                    .ToArray();

                if (facNum.EndsWith("14") || facNum.EndsWith("15"))
                {
                    grades.Add(currentGrades);
                }

                input = Console.ReadLine();
            }

            grades.ForEach(n => Console.WriteLine(string.Join(" ", n)));
        }
    }
}
