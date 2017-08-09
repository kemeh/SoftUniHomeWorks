using System;

public class Tomcat : Cat
{
    public Tomcat(string name, int age, string gender)
        : base(name, age, "Male")
    {

    }

    public override string Gender
    {
        get { return base.Gender; }
        set
        {
            if (value.ToLower() == "female")
            {
                throw new ArgumentException("Invalid input!");
            }

            base.Gender = value;
        }
    }

    public override string ProduceSound()
    {
        return "Give me one million b***h";
    }
}
