using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CarSalesman
{
    static void Main(string[] args)
    {
        var lines = int.Parse(Console.ReadLine());
        List<Engine> engineTypes = new List<Engine>();
        List<Car> allCars = new List<Car>();
        for (int i = 0; i < lines; i++)
        {            
            var engineTokens = Console.ReadLine().Split();
            Engine currentEngine = new Engine(engineTokens[0], double.Parse(engineTokens[1]));

            if (engineTokens.Length > 2)
            {
                int displacement;

                bool isNumber = int.TryParse(engineTokens[2], out displacement);

                if (isNumber)
                {
                    if (engineTokens.Length > 3)
                    {
                        currentEngine.efficiency = engineTokens[3];
                    }

                    currentEngine.displacement = displacement.ToString();
                }
                else
                {
                    currentEngine.efficiency = engineTokens[2];
                }
            }  
            
            engineTypes.Add(currentEngine);          
        }

        lines = int.Parse(Console.ReadLine());

        for (int i = 0; i < lines; i++)
        {
            var carTokens = Console.ReadLine().Split();

            var currentCar = new Car(carTokens[0], engineTypes.Where(e => e.model == carTokens[1]).FirstOrDefault());

            if (carTokens.Length > 2)
            {
                int weight;

                bool isNumber = int.TryParse(carTokens[2], out weight);

                if (isNumber)
                {
                    if (carTokens.Length > 3)
                    {
                        currentCar.color = carTokens[3];
                    }

                    currentCar.weight = weight.ToString();
                }
                else
                {
                    currentCar.color = carTokens[2];
                }
            }

            allCars.Add(currentCar);
        }

        foreach (var car in allCars)
        {
            Console.WriteLine(car.ToString());
        }
    }
}