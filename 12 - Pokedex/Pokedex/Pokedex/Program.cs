namespace Pokedex
{
    internal class Program
    {
        static void Main()
        {
            //var pikachu = new { Health = 50, Level = 21 };
            //var pikachu = new Pikachu(10, 30);
            //var balbasaur = new Balbasaur(60, 500);

            //Console.WriteLine($"Pikachu har {pikachu.Health} HP og er level {pikachu.Level}");
            //Console.WriteLine($"Balbasaur har {balbasaur.Health} HP og er level {balbasaur.Level}");

            var balbasaur = new Pokemon("Balbasaur", 12, 30);
            var pikachu = new Pokemon("Pikachu", 18, 20);
            var testpokemon = new Pokemon("Drowzee");

            Console.WriteLine($"Du har funnet {balbasaur.Name} som er level {balbasaur.Level} og har {balbasaur.Health} HP, og {pikachu.Name} som er level {pikachu.Level} oh har {pikachu.Health} HP");
        }
    }
}