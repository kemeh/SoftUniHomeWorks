using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.CompanyRoaster
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            Dictionary<string, List<Employee>> allDepartments = new Dictionary<string, List<Employee>>();

            for (int i = 0; i < lines; i++)
            {
                var tokens = Console.ReadLine().Split();
                var name = tokens[0];
                double salary = double.Parse(tokens[1]);
                var position = tokens[2];
                var department = tokens[3];

                Employee current = new Employee(name, salary, position, department);

                if (tokens.Length > 3)
                {
                   

                    foreach (var source in tokens.Skip(4))
                    {
                        int age;
                        string email;
                        bool isAge = int.TryParse(source, out age);

                        if (!isAge)
                        {
                            email = source;
                            current.email = email;
                        }
                        else
                        {
                            current.age = age;
                        }
                    }                    
                }

                if (!allDepartments.ContainsKey(department))
                {
                    allDepartments.Add(department, new List<Employee>());
                }               

                allDepartments[department].Add(current);
            }

            PrintResult(allDepartments);
        }

        public static void PrintResult(Dictionary<string, List<Employee>> allDepartments)
        {
            var result = allDepartments.Values.OrderByDescending(x => x.Average(y => y.salary)).First();

            Console.WriteLine($"Highest Average Salary: {result.First().department}");
            foreach (var empl in result.OrderByDescending(x => x.salary))
            {
                Console.WriteLine($"{empl.name} {empl.salary:F2} {empl.email} {empl.age}");
            }
        }
    }
}
