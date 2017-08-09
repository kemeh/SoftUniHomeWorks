using System;

public static class AnimalFactory
{
    public static Animal CreateAnimal(string[] input)
    {
        switch (input[0].ToLower())
        {
            case "cat":
                return new Cat(input[1], input[0], double.Parse(input[2]), 0, input[3], input[4]);
            case "tiger":
                return new Tiger(input[1], input[0], double.Parse(input[2]), 0, input[3]);
            case "zebra":
                return new Zebra(input[1], input[0], double.Parse(input[2]), 0, input[3]);
            case "mouse":
                return new Mouse(input[1], input[0], double.Parse(input[2]), 0, input[3]);
            default:
                throw new ArgumentException("Invalid Animal");
        }
    }
}