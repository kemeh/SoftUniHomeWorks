using System;
using System.Collections.Generic;
using System.Linq;

    class Program
    {
        static void Main()
        {
            var lines = int.Parse(Console.ReadLine());

            List<Car> allCars = new List<Car>();

            for (int i = 0; i < lines; i++)
            {
                var tokens = Console.ReadLine().Split();
                var currentCar = new Car(tokens[0]);
                currentCar.engine.speed = int.Parse(tokens[1]);
                currentCar.engine.power = int.Parse(tokens[2]);
                currentCar.cargo.weight = int.Parse(tokens[3]);
                currentCar.cargo.type = tokens[4];
                currentCar.tires.Add(new Tire() {pressure = double.Parse(tokens[5]), age = int.Parse(tokens[6])});
                currentCar.tires.Add(new Tire() { pressure = double.Parse(tokens[7]), age = int.Parse(tokens[8]) });
                currentCar.tires.Add(new Tire() { pressure = double.Parse(tokens[9]), age = int.Parse(tokens[10]) });
                currentCar.tires.Add(new Tire() { pressure = double.Parse(tokens[11]), age = int.Parse(tokens[12]) });

                allCars.Add(currentCar);
            }

            string type = Console.ReadLine();

            if (type == "fragile")
            {
                foreach (var car in allCars.Where(x => x.cargo.type == type && x.tires.Exists(t => t.pressure < 1)))
                {
                    Console.WriteLine(car.model);
                }
            }
            if (type == "flamable")
            {
                foreach(var car in allCars.Where(x => x.cargo.type == type && x.engine.power > 250))
                {
                    Console.WriteLine(car.model);
                }
            }
        }
    }