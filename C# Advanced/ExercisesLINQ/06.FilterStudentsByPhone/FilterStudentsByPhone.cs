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
                var phone = tokens[2];

                var student = new Student(firstName, lastName, phone);

                allStudents.Add(student);

                input = Console.ReadLine();
            }

            allStudents
                .Where(s => s.Phone.StartsWith("02") || s.Phone.StartsWith("+3592"))
                .ToList()
                .ForEach(s => Console.WriteLine($"{s.FirstName} {s.LastName}"));
        }
    }

    public class Student
    {
        public Student(string firstName, string lastName, string phone)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Phone = phone;

        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
    }
}
