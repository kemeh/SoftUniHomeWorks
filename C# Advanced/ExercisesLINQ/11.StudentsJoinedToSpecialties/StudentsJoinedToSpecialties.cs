using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _11.StudentsJoinedToSpecialties
{
    class StudentsJoinedToSpecialties
    {
        static void Main(string[] args)
        {
            List<StudentSpecialty> specs = new List<StudentSpecialty>();
            List<Student> students = new List<Student>();

            var command = Console.ReadLine();

            while (command != "Students:")
            {
                var tokens = command.Split(' ');

                var specName = tokens[0] + " " + tokens[1];
                var facNum = tokens[2];

                specs.Add(new StudentSpecialty()
                {
                    SpecName = specName,
                    FacNum = facNum
                });

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command.ToLower() != "end")
            {
                var tokens = command.Split(' ');
               
                var facNum = tokens[0];
                var studName = tokens[1] + " " + tokens[2];

                students.Add(new Student()
                {
                    FacNum = facNum,
                    Name = studName
                });

                command = Console.ReadLine();
            }

            var result = MergeData(specs, students);

            PrintResult(result);
        }

        private static void PrintResult(Dictionary<Student, List<StudentSpecialty>> result)
        {
            foreach (var student in result.OrderBy(n => n.Key.Name))
            {
                foreach (var spec in student.Value)
                {
                    Console.WriteLine($"{student.Key.Name} {student.Key.FacNum} {spec.SpecName}");
                }
            }
        }

        private static Dictionary<Student, List<StudentSpecialty>> MergeData(List<StudentSpecialty> specs, List<Student> students)
        {
            var result = new Dictionary<Student, List<StudentSpecialty>>();

            foreach (var st in students)
            {
                if (!result.ContainsKey(st))
                {
                    result.Add(st, new List<StudentSpecialty>());
                }

                result[st] = specs.Where(s => s.FacNum == st.FacNum).ToList();
            }

            return result;
        }
    }

    public class StudentSpecialty
    {
        public string SpecName { get; set; }
        public string FacNum { get; set; }
    }

    public class Student
    {
        public string FacNum { get; set; }
        public string Name { get; set; }
    }
}
