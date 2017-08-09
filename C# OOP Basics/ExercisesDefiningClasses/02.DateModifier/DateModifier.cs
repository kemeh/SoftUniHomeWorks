using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

class DateModifier
{
    public string firstDate;
    public string secondDate;

    public void CalculateDifference()
    {
        var firstDateTokens = firstDate
            .Split()
            .Select(int.Parse)
            .ToArray();
        var secondDateTokens = secondDate
            .Split()
            .Select(int.Parse)
            .ToArray();
        TimeSpan result = new DateTime(secondDateTokens[0], secondDateTokens[1], secondDateTokens[2]) - 
            new DateTime(firstDateTokens[0], firstDateTokens[1], firstDateTokens[2]);

        Console.WriteLine(Math.Abs(result.Days));
    }
}