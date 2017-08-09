public abstract class Mammal : Animal
{
    private string livingRegion;

    public Mammal(string name, string type, double weight, int foodEaten, string livingRegion) 
        : base(name, type, weight, foodEaten)
    {
        this.LivingRegion = livingRegion;
    }

    public string LivingRegion
    {
        get { return livingRegion; }
        set { livingRegion = value; }
    }

    public override string ToString()
    {
        return base.ToString() + $"{this.LivingRegion}, {this.FoodEaten}]";
    }
}