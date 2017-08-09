using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _12.LegendaryFarming
{
    class LegendaryFarming
    {
        static void Main()
        {
            var items = new Dictionary<string, string>
            {
                {"shards","Shadowmourne"},
                {"fragments", "Valanyr"},
                {"motes", "Dragonwrath"}
            };
            
            var materials = new SortedDictionary<string, int>()
            {
                {"shards", 0 },
                {"fragments", 0 },
                {"motes", 0 }
            };
            var junk = new SortedDictionary<string, int>();

            var obtainedItem = "";

            var notObtained = true;
            string regex = "\\d+\\s\\D+";

            while (notObtained)
            {
                var input = Console.ReadLine().Trim();

                var matches = Regex.Matches(input, regex);

                foreach (Match match in matches)
                {
                    var tokens = match
                        .ToString()
                        .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                    var quantity = int.Parse(tokens[0]);
                    var material = tokens[1].ToLower();
                    
                    if (items.ContainsKey(material))
                    {
                        materials[material] += quantity;

                        if (materials[material] >= 250)
                        {
                            materials[material] -= 250;
                            obtainedItem = items[material];
                            notObtained = false;

                            break;
                        }
                    }
                    else
                    {
                        if (!junk.ContainsKey(material))
                        {
                            junk.Add(material, 0);
                        }
                        junk[material] += quantity;
                    }
                }
            }

            Console.WriteLine($"{obtainedItem} obtained!");

            foreach (var material in materials.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }

            foreach (var jun in junk.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{jun.Key}: {jun.Value}");
            }
        }
    }
}
