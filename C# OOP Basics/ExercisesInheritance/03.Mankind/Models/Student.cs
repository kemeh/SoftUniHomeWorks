using System;
using System.Text.RegularExpressions;

public class Student : Human
{
    private string facNumber;

    public Student(string firstName, string lastName, string facNumber)
        : base(firstName, lastName)
    {
        this.FacultyNumber = facNumber;
    }

    private string FacultyNumber
    {
        get { return this.facNumber; }
        set
        {
            Match match = Regex.Match(value, @"\b[a-zA-Z0-9]{5,10}\b");

            if (!match.Success)
            {
                throw new ArgumentException("Invalid faculty number!");
            }

            this.facNumber = value;
        }

    }

    public override string ToString()
    {
        return base.ToString() + $"Faculty number: {this.FacultyNumber}";
    }
}