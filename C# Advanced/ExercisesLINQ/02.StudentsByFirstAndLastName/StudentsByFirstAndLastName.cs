using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _01.StudentsByGroup
{
    class StudentsByGroup
    {
        static void Main()
        {
            string input = Console.ReadLine();

            List<Student> allStudents = new List<Student>();

            while (input.ToLower() != "end")
            {
                var tokens = input.Split(' ');
                var firstName = tokens[0];
                var lastName = tokens[1];

                var student = new Student(firstName, lastName);

                allStudents.Add(student);

                input = Console.ReadLine();
            }

            allStudents
                .Where(n => n.CompareNames(n.FirstName, n.LastName))
                .ToList()
                .ForEach(s => Console.WriteLine($"{s.FirstName} {s.LastName}"));
            Console.WriteLine();
        }
    }

    public class Student
    {
        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public bool CompareNames(string first, string last)
        {
            for (int i = 0; i < Math.Min(first.Length, last.Length); i++)
            {
                if (first[i] != last[i])
                {
                    if (first[i] < last[i])
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return false;
        }
    }
}
