using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var command = Console.ReadLine();

        List<Person> all = new List<Person>();

        while (command.ToLower() != "end")
        {
            var tokens = command.Split();
            Person currentPerson;

            if (all.Exists(p => p.name == tokens[0]))
            {
                currentPerson = all.Where(p => p.name == tokens[0]).FirstOrDefault();
            }
            else
            {
                currentPerson = new Person(tokens[0]);
            }

            switch (tokens[1])
            {
                case "company":
                    Company company = new Company(tokens[2], tokens[3], double.Parse(tokens[4]));
                    currentPerson.company = company;
                    break;
                case "car":
                    Car car = new Car(tokens[2], int.Parse(tokens[3]));
                    currentPerson.car = car;
                    break;
                case "pokemon":
                    Pokemon currentPokemon = new Pokemon(tokens[2], tokens[3]);
                    currentPerson.pokemons.Add(currentPokemon);
                    break;
                case "parents":
                    Parent currentParent = new Parent(tokens[2], tokens[3]);
                    currentPerson.parents.Add(currentParent);
                    break;
                case "children":
                    Child currentChild = new Child(tokens[2], tokens[3]);
                    currentPerson.children.Add(currentChild);
                    break;
            }

            all.Add(currentPerson);
            command = Console.ReadLine();
        }

        command = Console.ReadLine();

        Console.WriteLine(all.Where(p => p.name == command).FirstOrDefault().ToString());
    }
}