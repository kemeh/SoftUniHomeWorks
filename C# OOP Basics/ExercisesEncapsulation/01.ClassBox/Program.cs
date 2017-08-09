using System;
using System.Linq;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {

        Type boxType = typeof(Box);
        FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
        Console.WriteLine(fields.Count());

        try
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Box box = new Box(length, width, height);

            Console.WriteLine($"Surface Area - {box.CalculateArea():f2}");
            Console.WriteLine($"Lateral Surface Area - {box.CalculateLateralSurface():f2}");
            Console.WriteLine($"Volume - {box.CalculateVolume():f2}");

        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }       
    }
}