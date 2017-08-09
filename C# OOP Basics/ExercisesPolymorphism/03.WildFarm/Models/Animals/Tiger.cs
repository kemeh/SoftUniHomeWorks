using System;

public class Tiger : Felime
{
    public Tiger(string name, string type, double weight, int foodEaten, string livingRegion) 
        : base(name, type, weight, foodEaten, livingRegion)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine("ROAAR!!!");
    }

    public override void Eat(Food food)
    {
        if (food is Meat)
        {
            this.FoodEaten = food.Quantity;
        }
        else
        {
            Console.WriteLine($"{GetType().Name}s are not eating that type of food!");
        }
    }
}