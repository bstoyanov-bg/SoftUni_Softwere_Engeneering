﻿
using System.Collections.Generic;
using System.Linq;

namespace P09_PokemonTrainerProject
{
    public class Trainer
    {
        public Trainer(string trainerName)
        {
            this.Name = trainerName;

            Pokemons = new List<Pokemon>();

        }
        public string Name { get; set; }

        public int NumOfBadges { get; set; }

        public List<Pokemon> Pokemons { get; set; }


        public void CheckPokemon(string element)
        {
            if (this.Pokemons.Any(p => p.Element == element))
            {
                NumOfBadges++;
            }
            else
            {
                for (int i = 0; i < this.Pokemons.Count; i++)
                {
                    Pokemon currentPokemon = this.Pokemons[i];

                    currentPokemon.Health -= 10;

                    if (currentPokemon.Health <= 0)
                    {
                        this.Pokemons.Remove(currentPokemon);
                    }
                }
            }
        }
    }
}