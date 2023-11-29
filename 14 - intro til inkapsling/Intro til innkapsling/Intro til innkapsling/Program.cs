namespace Intro_til_innkapsling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stats = new Stats();
            while (true)
            {
                Console.WriteLine("Skriv et tall (eller blankt får å avslutte)");
                var numberStr = Console.ReadLine();
                if (string.IsNullOrEmpty(numberStr)) break;
                var number = Convert.ToInt32(numberStr);
                stats.AddNumber(number);
                stats.ShowResult();
            }
        }
    }
}