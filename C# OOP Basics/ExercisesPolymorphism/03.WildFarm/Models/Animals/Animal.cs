public abstract class Animal
{
    private string animalName;
    private string animalType;
    private double animalWeight;
    private int foodEaten;

    public Animal(string name, string type, double weight, int foodEaten)
    {
        this.AnimalName = name;
        this.AnimalType = type;
        this.AnimalWeight = weight;
        this.FoodEaten = foodEaten;
    }

    public int FoodEaten
    {
        get { return foodEaten; }
        set { foodEaten = value; }
    }

    public double AnimalWeight
    {
        get { return animalWeight; }
        set { animalWeight = value; }
    }

    public string AnimalType
    {
        get { return animalType; }
        set { animalType = value; }
    }

    public string AnimalName
    {
        get { return animalName; }
        set { animalName = value; }
    }

    public abstract void MakeSound();
    public abstract void Eat(Food food);

    public override string ToString()
    {
        return $"{GetType().Name}[{this.AnimalName}, {this.AnimalWeight}, ";
    }
}