using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.GroupByGroup
{
    class GroupByGroup
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine();

            var people = new List<Person>();

            while (command.ToLower() != "end")
            {
                var tokens = command.Split(' ');

                var fullName = tokens[0] + " " + tokens[1];
                var group = int.Parse(tokens[2]);

                var currentPerson = new Person()
                {
                    Group = group,
                    Name = fullName
                };

                people.Add(currentPerson);

                command = Console.ReadLine();
            }

            var result = people
                .GroupBy(n => n.Group, n => n.Name, (key, g) => new {group = key, people = g.ToList()})
                .OrderBy(g => g.group);

            foreach (var group in result)
            {
                Console.WriteLine($"{group.group} - {string.Join(", ", group.people)}");
            }
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Group { get; set; }
    }
}
