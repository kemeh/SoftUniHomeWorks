class Child : Relative
{

    public Child(string name, string birthDate)
    {
        this.name = name;
        this.birthDate = birthDate;
    }

    public override string ToString()
    {
        return $"{this.name} {this.birthDate}\n";
    }
}