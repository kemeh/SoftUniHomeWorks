using System;

public class Worker:Human
{
    private decimal weekSalary;
    private double workHours;

    public Worker(string firstName, string lastName, decimal weekSalary, double workingHours)
        : base(firstName, lastName)
    {
        this.WeekSalary = weekSalary;
        this.WorkingHours = workingHours;
    }

    private decimal WeekSalary
    {
        set
        {
            if (value < 11)
            {
                throw new ArgumentException("Expected value mismatch!Argument: weekSalary");
            }

            this.weekSalary = value;
        }
    }

    private double WorkingHours
    {
        set
        {
            if (value < 1 || value > 12)
            {
                throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
            }

            this.workHours = value;
        }
    }

    public override string ToString()
    {
        return base.ToString() + $"Week Salary: {this.weekSalary:f2}\n" +
               $"Hours per day: {this.workHours:f2}\n" +
               $"Salary per hour: {(this.weekSalary / (decimal)this.workHours)/5:f2}";
    }
}