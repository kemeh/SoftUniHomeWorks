using System;
using System.Collections.Generic;
using System.Reflection;

class Program
{
    static void Main()
    {
        MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
        MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
        if (oldestMemberMethod == null || addMemberMethod == null)
        {
            throw new Exception();
        }

        var lines = int.Parse(Console.ReadLine());
        Family family = new Family();

        for (int i = 0; i < lines; i++)
        {
            var tokens = Console.ReadLine().Split();
            var name = tokens[0];
            var age = int.Parse(tokens[1]);

            family.members.Add(new Person(name, age));
        }
        List<Person> oldest = family.GetOverThirty();

        foreach (var person in oldest)  
        {
            Console.WriteLine($"{person.name} - {person.age}");
        }

    }
}
