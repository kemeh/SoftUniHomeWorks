using System;
using System.Collections.Generic;
using System.Numerics;

namespace _06.AMinersTask
{
    class AMinersTask
    {
        static void Main()
        {
            var resources  = new Dictionary<string, BigInteger>();

            while (true)
            {
                var resource = Console.ReadLine();

                if (resource.ToLower().Equals("stop"))
                {
                    break;
                }

                var quantity = int.Parse(Console.ReadLine());

                if (!resources.ContainsKey(resource))
                {
                    resources.Add(resource, 0);
                }

                resources[resource] += quantity;
            }

            foreach (var res in resources)
            {
                Console.WriteLine($"{res.Key} -> {res.Value}");
            }
        }
    }
}
