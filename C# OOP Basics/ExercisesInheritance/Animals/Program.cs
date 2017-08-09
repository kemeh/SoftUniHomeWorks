using System;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        while (input.ToLower() != "beast!")
        {
            var details = Console.ReadLine().Split();

            try
            {
                var animal = AnimalFactory.Create(input, details[0], int.Parse(details[1]), details[2]);
                Console.WriteLine(animal.ToString());
                Console.WriteLine(animal.ProduceSound());
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            input = Console.ReadLine();
        }
    }
}