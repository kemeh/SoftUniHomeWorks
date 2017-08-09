using System;

public static class FoodFactory
{
    public static Food Create(string[] tokens)
    {
        switch (tokens[0].ToLower())
        {
            case "vegetable":
                return new Vegetable(int.Parse(tokens[1]));
            case "meat":
                return new Meat(int.Parse(tokens[1]));
            default:
                throw new ArgumentException("Invalid Food");
        }
    }
}