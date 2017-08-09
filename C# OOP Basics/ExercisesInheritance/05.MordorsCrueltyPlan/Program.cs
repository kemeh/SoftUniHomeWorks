using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var foods = Console.ReadLine()
            .Split(new[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();
        var points = 0;

        for (int i = 0; i < foods.Length; i++)
        {
            var food = FoodFactory.Get(foods[i]);
            points += food.Happiness;
        }

        Console.WriteLine(points);
        Console.WriteLine(MoodFactory.GetMood(points));
    }
}