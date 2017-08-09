using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.WithQueueOrStack
{
    class Program
    {
        static void Main(string[] args)
        {
            var plantsCount = int.Parse(Console.ReadLine());

            var allPlants = plantsCount;
            var initPesticidePerPlant =
                Console.ReadLine()
                    .Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

            var currentPesticidePerPlant = new Stack<int>(initPesticidePerPlant);

            var resultDay = 0;

            while (true)
            {
                for (int i = 0; i < allPlants; i++)
                {
                    var first = currentPesticidePerPlant.Pop();
                    var second = currentPesticidePerPlant.Pop();
                }
            }
        }
    }
}
