using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var command = Console.ReadLine();

        while (command.ToLower() != "end")
        {
            Animal animal = AnimalFactory.CreateAnimal(command.Split().ToArray());
            Food food = FoodFactory.Create(Console.ReadLine().Split().ToArray());

            animal.MakeSound();
            animal.Eat(food);
            Console.WriteLine(animal.ToString());       

            command = Console.ReadLine();
        }
    }
}