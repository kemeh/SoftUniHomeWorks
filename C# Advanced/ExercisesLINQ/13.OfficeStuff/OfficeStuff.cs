using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _13.OfficeStuff
{
    class OfficeStuff
    {
        static void Main()
        {
            var lines = int.Parse(Console.ReadLine());

            var data = ReadData(lines);

            PrintData(data);
        }

        private static void PrintData(SortedDictionary<string, Dictionary<string, int>> data)
        {
            foreach (var company in data)
            {
                Console.WriteLine($"{company.Key}: {string.Join(", ", company.Value.Select(kv => kv.Key +"-" + kv.Value).ToArray())}");
            }
        }

        private static SortedDictionary<string, Dictionary<string, int>> ReadData(int lines)
        {
            var data = new SortedDictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < lines; i++)
            {
                var tokens = Console.ReadLine().Split(new[] {'-',' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var companyName = tokens[0].TrimStart('|');
                var amount = int.Parse(tokens[1]);
                var product = tokens[2].TrimEnd('|');

                if (!data.ContainsKey(companyName))
                {
                    data.Add(companyName, new Dictionary<string, int>());
                }
                if (!data[companyName].ContainsKey(product))
                {
                    data[companyName].Add(product, 0);
                }

                data[companyName][product] += amount;
            }

            return data;
        }
    }
}
