using System;

public class Kitten : Cat
{
    public Kitten(string name, int age, string gender)
        : base(name, age, "Female")
    {
        
    }

    public override string Gender
    {
        get { return base.Gender; }
        set
        {
            if (value.ToLower() == "male")
            {
                throw new ArgumentException("Invalid input!");
            }

            base.Gender = value;
        }
    }

    public override string ProduceSound()
    {
        return "Miau";
    }
}