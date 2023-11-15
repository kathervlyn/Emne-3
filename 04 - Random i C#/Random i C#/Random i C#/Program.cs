namespace Random_i_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GiveHobby();
        }

        static void GiveHobby()
        {
            Console.WriteLine("Who gets a new hobby? \n");
            string Name = Console.ReadLine();
            Console.WriteLine();
            Random rand = new Random();
            var randomNumber = rand.Next(0, 4);
            if (randomNumber == 0)
            {
                Console.WriteLine($"{Name} is now a Magician");
            }
            else if (randomNumber == 1)
            {
                Console.WriteLine($"{Name} is now a Climber");
            }
            else if (randomNumber == 2)
            {
                Console.WriteLine($"{Name} is now a Carpenter");
            }
            else
            {
                Console.WriteLine($"{Name} is now a Musician");
            }
            Console.WriteLine();
            GiveHobby();
        }
    }
}
