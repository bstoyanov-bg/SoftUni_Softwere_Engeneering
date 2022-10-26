
namespace P09_PokemonTrainerProject
{
    public class Pokemon
    {
        public Pokemon(string pokemonName, string element, int health)
        {
            this.Name = pokemonName;
            this.Element = element;
            this.Health = health;
        }
        public string Name { get; set; }

        public string Element { get; set; }

        public int Health { get; set; }
    }
}
