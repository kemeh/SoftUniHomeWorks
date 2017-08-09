using System;

public class Program
{
    public static void Main()
    {
        var carTokens = Console.ReadLine().Split();
        var truckTokens = Console.ReadLine().Split();
        var busTokens = Console.ReadLine().Split();

        Vehicle car = new Car(double.Parse(carTokens[1]), double.Parse(carTokens[2]), double.Parse(carTokens[3]));
        Vehicle truck = new Truck(double.Parse(truckTokens[1]), double.Parse(truckTokens[2]), double.Parse(truckTokens[3]));
        Vehicle bus = new Bus(double.Parse(busTokens[1]), double.Parse(busTokens[2]), double.Parse(busTokens[3]));

        var lines = int.Parse(Console.ReadLine());

        for (int i = 0; i < lines; i++)
        {
            var command = Console.ReadLine().Split();

            try
            {
                if (command[0].ToLower() == "drive")
                {
                    if (command[1].ToLower() == "car")
                    {
                        car.Drive(double.Parse(command[2]));
                    }
                    if (command[1].ToLower() == "truck")
                    {
                        truck.Drive(double.Parse(command[2]));
                    }
                    if (command[1].ToLower() == "bus")
                    {
                        bus.Drive(double.Parse(command[2]));
                    }
                }

                if (command[0].ToLower() == "refuel")
                {
                    if (command[1].ToLower() == "car")
                    {
                        car.Refill(double.Parse(command[2]));
                    }
                    if (command[1].ToLower() == "bus")
                    {
                        bus.Refill(double.Parse(command[2]));
                    }

                    if (command[1].ToLower() == "truck")
                    {
                        truck.Refill(double.Parse(command[2]));
                    }
                }

                if (command[0].ToLower() == "driveempty")
                {
                    (bus as Bus).DriveEmpty(double.Parse(command[2]));
                }
            }

            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }            
        }

        Console.WriteLine(car.ToString());
        Console.WriteLine(truck.ToString());
        Console.WriteLine(bus.ToString());
    }
}