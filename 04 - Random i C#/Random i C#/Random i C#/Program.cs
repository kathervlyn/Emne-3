namespace Random_i_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            var randomNumber = rand.Next(0, 3);
            if (randomNumber == 0)
            {
                Console.WriteLine("Tallet Ble 0");
            }
            else if (randomNumber == 1)
            {
                Console.WriteLine("Tallet ble 1");
            }
            else
            {
                Console.WriteLine("Tallet Ble 2");
            }
        }

    }
}