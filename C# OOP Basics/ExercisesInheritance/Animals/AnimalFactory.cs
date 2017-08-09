using System;

public static class AnimalFactory
{
    public static Animal Create(string type, string name, int age, string gender)
    {
        switch (type.ToLower())
        {
            case "dog":
                return new Dog(name, age, gender);
            case "cat":
                return new Cat(name, age, gender);
            case "frog":
                return new Frog(name, age, gender);
            case "kitten":
                return new Kitten(name, age, gender);
            case "tomcat":
                return new Tomcat(name, age, gender);
            default:
                throw new ArgumentException("Invalid input!");
        }
    }
}
