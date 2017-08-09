using System;

class Program
{
    static void Main()
    {
        DateModifier date = new DateModifier();

        date.firstDate = Console.ReadLine();
        date.secondDate = Console.ReadLine();

        date.CalculateDifference();
    }
}

