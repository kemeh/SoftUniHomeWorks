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
                var group = int.Parse(tokens[2]);

                var student = new Student(firstName, lastName, group);

                allStudents.Add(student);

                input = Console.ReadLine();
            }

            allStudents
                .Where(s => s.Age >= 18 && s.Age <= 24)
                .ToList()
                .ForEach(s => Console.WriteLine($"{s.FirstName} {s.LastName} {s.Age}"));
        }
    }

    public class Student
    {
        public Student(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;

        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
