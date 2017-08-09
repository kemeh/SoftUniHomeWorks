using System;
using System.Linq;

namespace _11.PoisonousPlants
{
    class PoisonousPlants
    {
        static void Main()
        {
            var plantsCount = int.Parse(Console.ReadLine());
            var allPlants = plantsCount;

            var pesticideAmount = Console.ReadLine()
                .Split(new char[] {' ', '\n', '\t'}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var resultDay = 0;

            while (true)
            {
                for (int i = allPlants - 1; i > 0; i--)
                {
                    if (pesticideAmount[i] > pesticideAmount[i - 1] && pesticideAmount[i] != -1)
                    {
                        pesticideAmount[i] = -1;

                        allPlants -= 1;
                    }
                }

                if (allPlants == pesticideAmount.Length)
                {
                    break;
                }

                resultDay++;
                pesticideAmount = pesticideAmount.Where(x => x != -1).ToArray();
            }

            Console.WriteLine(resultDay);
        }
    }
}
