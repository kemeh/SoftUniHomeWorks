class Parent:Relative
{
    public Parent(string name, string birthDate)
    {
        this.name = name;
        this.birthDate = birthDate;
    }

    public override string ToString()
    {
        return $"{this.name} {this.birthDate}\n";
    }
}