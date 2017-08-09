using System;

public class Cat : Felime
{
    private string breed;

    public Cat(string name, string type, double weight, int foodEaten, string livingRegion, string breed) 
        : base(name, type, weight, foodEaten, livingRegion)
    {
        this.Breed = breed;
    }

    public string Breed
    {
        get { return breed; }
        set { breed = value; }
    }

    public override void MakeSound()
    {
        Console.WriteLine("Meowwww");
    }

    public override void Eat(Food food)
    {
        this.FoodEaten = food.Quantity;
    }

    public override string ToString()
    {
        return $"{GetType().Name}[{this.AnimalName}, {this.Breed}, {this.AnimalWeight}, {this.LivingRegion}, {this.FoodEaten}]";
    }
}