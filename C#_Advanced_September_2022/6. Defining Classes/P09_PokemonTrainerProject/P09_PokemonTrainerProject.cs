using System;
using System.Collections.Generic;
using System.Linq;

namespace P09_PokemonTrainerProject
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            List<Trainer> trainers = new List<Trainer>();

            string info = Console.ReadLine();

            while (info != "Tournament")
            {
                string[] inputInfo = info
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Trainer trainer = trainers.SingleOrDefault(t => t.Name == inputInfo[0]);

                if (trainer == null)
                {
                    trainer = new Trainer(inputInfo[0]);
                    trainer.Pokemons.Add(new Pokemon(inputInfo[1], inputInfo[2], int.Parse(inputInfo[3])));
                    trainers.Add(trainer);
                }
                else
                {
                    trainer.Pokemons.Add(new Pokemon(inputInfo[1], inputInfo[2], int.Parse(inputInfo[3])));
                }

                info = Console.ReadLine();
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                foreach (var trainer in trainers)
                {
                    trainer.CheckPokemon(command);
                }

                command = Console.ReadLine();
            }

            foreach (var trainer in trainers.OrderByDescending(t => t.NumOfBadges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumOfBadges} {trainer.Pokemons.Count}");
            }
        }
    }
}