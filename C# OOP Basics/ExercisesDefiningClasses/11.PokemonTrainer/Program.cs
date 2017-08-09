using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var command = Console.ReadLine();
        List<Trainer> allTrainers = new List<Trainer>();

        while (command.ToLower() != "tournament")
        {
            var tokens = command.Split();
            var currentPokemon = new Pokemon(tokens[1], tokens[2], int.Parse(tokens[3]));
            Trainer currentTrainer;
            if (allTrainers.Exists(t => t.name == tokens[0]))
            {
                currentTrainer = allTrainers.Where(t => t.name == tokens[0]).FirstOrDefault();
                currentTrainer.pokemons.Add(currentPokemon);
            }
            else
            {
                currentTrainer = new Trainer(tokens[0]);
                currentTrainer.pokemons.Add(currentPokemon);
                allTrainers.Add(currentTrainer);
            }

            command = Console.ReadLine();
        }

        command = Console.ReadLine();

        while (command.ToLower() != "end")
        {
            foreach (var trainer in allTrainers)
            {
                trainer.ContainsElement(command);
            }
            command = Console.ReadLine();
        }

        foreach (var trainer in allTrainers.OrderByDescending(x => x.badgesCount))
        {
            Console.WriteLine(trainer.ToString());
        }
    }
}
