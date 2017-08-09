using System;
using System.Collections.Generic;
using System.Linq;

namespace _14.DragonArmy
{
    class DragonArmy
    {
        static void Main()
        {
            var dragonTypes = new Dictionary<string, SortedDictionary<string, Dragon>>();

            var lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                var tokens = Console.ReadLine()
                    .Split(new char[] {' ', '\t', '\n'}, StringSplitOptions.RemoveEmptyEntries);

                var type = tokens[0];
                var name = tokens[1];

                var damage = 0;
                var health = 0;
                var armor = 0;
                if (tokens[2].Equals("null"))
                {
                    damage = 45;
                }
                else
                {
                    damage = int.Parse(tokens[2]);
                }

                if (tokens[3].Equals("null"))
                {
                    health = 250;
                }
                else
                {
                    health = int.Parse(tokens[3]);
                }

                if (tokens[4].Equals("null"))
                {
                    armor = 10;
                }
                else
                {
                    armor = int.Parse(tokens[4]);
                }


                var dragon = new Dragon()
                {                    
                    Armor = armor,
                    Damage = damage,
                    Health = health,
                };

                if (!dragonTypes.ContainsKey(type))
                {
                    dragonTypes.Add(type, new SortedDictionary<string, Dragon>());
                }

                if (!dragonTypes[type].ContainsKey(name))
                {
                    dragonTypes[type].Add(name, dragon);
                }

                dragonTypes[type][name] = dragon;
            }

            foreach (var type in dragonTypes)
            {
                Console.WriteLine($"{type.Key}" +
                                  $"::({type.Value.Values.Average(x => x.Damage):f2}" +
                                  $"/{type.Value.Values.Average(x => x.Health):f2}" +
                                  $"/{type.Value.Values.Average(x => x.Armor):f2})");

                foreach (var dragon in type.Value)
                {
                    Console.WriteLine($"-{dragon.Key} -> damage: {dragon.Value.Damage}" +
                                      $", health: {dragon.Value.Health}" +
                                      $", armor: {dragon.Value.Armor}");
                }
            }
        }
    }

    public class Dragon
    {
        public int Damage;
        public int Health;
        public int Armor;
    }
}
