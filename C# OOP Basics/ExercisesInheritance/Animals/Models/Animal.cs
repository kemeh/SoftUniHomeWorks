using System;

public abstract class Animal
{
    private string name;
    private string gender;
    private int age;

    public Animal(string name, int age, string gender)
    {
        this.Name = name;
        this.Age = age;
        this.Gender = gender;
    }

    public virtual string Name
    {
        get { return this.name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Invalid input!");
            }

            this.name = value;
        }
    }

    public virtual int Age
    {
        get { return this.age; }
        set
        {
            if (string.IsNullOrWhiteSpace(value.ToString()) || string.IsNullOrEmpty(value.ToString()) || value < 0)
            {
                throw new ArgumentException("Invalid input!");
            }

            this.age = value;
        }
    }

    public virtual string Gender
    {
        get { return this.gender; }
        set
        {
            if (string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Invalid input!");
            }

            this.gender = value;
        }
    }

    public virtual string ProduceSound()
    {
        return string.Empty;
    }

    public override string ToString()
    {
        return $"{this.GetType().Name}\n" +
               $"{this.Name} {this.Age} {this.Gender}";
    }
}