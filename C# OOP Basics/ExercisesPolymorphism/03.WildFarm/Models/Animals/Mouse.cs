using System;

public class Mouse : Mammal
{
    public Mouse(string name, string type, double weight, int foodEaten, string livingRegion) 
        : base(name, type, weight, foodEaten, livingRegion)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine("SQUEEEAAAK!");
    }

    public override void Eat(Food food)
    {
        if (food is Vegetable)
        {
            this.FoodEaten = food.Quantity;
        }
        else
        {
            Console.WriteLine($"{GetType().Name}s are not eating that type of food!");
        }
    }
}