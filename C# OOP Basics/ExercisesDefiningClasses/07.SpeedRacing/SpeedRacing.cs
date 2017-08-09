using System;
using System.Collections.Generic;

public class SpeedRacing
{
    static void Main()
    {
        List<Car> cars = new List<Car>();

        int lines = int.Parse(Console.ReadLine());

        for (int i = 0; i < lines; i++)
        {
            var tokens = Console.ReadLine().Split();
            var model = tokens[0];
            var fuelAmount = double.Parse(tokens[1]);
            var fuelConsumpt = double.Parse(tokens[2]);

            var currentCar = new Car(model, fuelAmount, fuelConsumpt);

            cars.Add(currentCar);
        }

        var driveCar = Console.ReadLine();

        while (driveCar.ToLower() != "end")
        {
            var tokens = driveCar.Split();
            var carModel = tokens[1];
            var kilometers = int.Parse(tokens[2]);

            foreach (var car in cars)
            {
                if (car.model == carModel)
                {
                    car.Drive(kilometers);
                }
            }

            driveCar = Console.ReadLine();
        }

        foreach (var car in cars)
        {
            Console.WriteLine($"{car.model} {car.fuelAmount:f2} {car.travelledDistance}");
        }
    }
}