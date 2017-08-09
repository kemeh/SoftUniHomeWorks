using System.Collections.Generic;

class Person
{
    public string name;
    public Company company;
    public Car car;
    public List<Parent> parents;
    public List<Child> children;
    public List<Pokemon> pokemons;

    public Person(string name)
    {
        this.name = name;
        this.parents = new List<Parent>();
        this.pokemons = new List<Pokemon>();
        this.children = new List<Child>();
    }

    public override string ToString()
    {
        string result = $"{this.name}\n" +
                        $"Company:\n";
        if (this.company != null)
        {
            result += $"{ this.company.name} { this.company.department} { this.company.salary:f2}\n";
        }
        result += $"Car:\n";

        if (this.car != null)
        {
            result += $"{this.car.model} {this.car.speed}\n";
        }
              result +=
               $"Pokemon:\n";

        foreach (var pokemon in this.pokemons)
        {
            result += pokemon.ToString();
        }

        result += "Parents:\n";

        foreach (var parent in this.parents)
        {
            result += parent.ToString();
        }

        result += "Children:\n";

        foreach (var child in this.children)
        {
            result += child.ToString();
        }

        return result;
    }
}