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
                var email = tokens[2];

                var student = new Student(firstName, lastName, email);

                allStudents.Add(student);

                input = Console.ReadLine();
            }

            allStudents
                .Where(s => s.Email.EndsWith("@gmail.com"))
                .ToList()
                .ForEach(s => Console.WriteLine($"{s.FirstName} {s.LastName}"));
        }
    }

    public class Student
    {
        public Student(string firstName, string lastName, string email)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;

        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
