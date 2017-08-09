using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.TruckTour
{
    class TruckTour
    {
        static void Main()
        {
            var pumps = int.Parse(Console.ReadLine());

            var liters = new Queue<int>();

            for (int i = 0; i < pumps; i++)
            {
                var pumpSpecs = Console.ReadLine()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                liters.Enqueue(pumpSpecs[0] - pumpSpecs[1]);
            }

            var index = 0;
            var fuelAmount = -1;

            for (int i = 0; i < pumps; i++)
            {
                if (liters.Peek() >= 0 && fuelAmount < 0)
                {
                    index = i;
                    fuelAmount = 0;
                }

                fuelAmount += liters.Dequeue();
            }

            Console.WriteLine(index);

        }
    }
}
