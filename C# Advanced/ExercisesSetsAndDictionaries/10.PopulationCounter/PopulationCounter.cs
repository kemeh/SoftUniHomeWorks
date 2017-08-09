using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.PopulationCounter
{
    class PopulationCounter
    {
        static void Main()
        {
            var countries = new Dictionary<string, Dictionary<string, long>>();

            var input = Console.ReadLine();

            while (true)
            {
                if (input.ToLower().Equals("report"))
                {
                    break;
                }

                var tokens = input.Split('|');

                var country = tokens[1];
                var city = tokens[0];
                var population = int.Parse(tokens[2]);

                if (!countries.ContainsKey(country))
                {
                    countries.Add(country, new Dictionary<string, long>());
                }

                countries[country].Add(city, population);

                input = Console.ReadLine();
            }

            foreach (var country in countries.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.Values.Sum()})");

                foreach (var city in country.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }


        }
    }
}
