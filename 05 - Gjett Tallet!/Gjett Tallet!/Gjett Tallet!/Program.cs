namespace Gjett_Tallet_
{
    internal class Program
    {
        static void Main()
        {
            Random rand = new Random();
            int randomNumber = rand.Next(1, 101);
            GjettRandomNummer(randomNumber);
        }
        static void GjettRandomNummer(int randomNumber)
        {
            Console.WriteLine("Guess a number between 1 and 100");
            Console.WriteLine();
            int Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (randomNumber > Number)
            {
                Console.WriteLine($"{Number} is too low try a higher number");
            }
            else if (randomNumber < Number)
            {
                Console.WriteLine($"{Number} is too high try a lower number");
            }
            else
            {
                Console.WriteLine("riktig vil du spille igjen y/n");
                Console.WriteLine();
                if (Console.ReadLine().ToLower() == "y")
                {
                    Console.WriteLine();
                    Main();
                }
                else
                {
                    Environment.Exit(1);
                }
            }
            Console.WriteLine();
            GjettRandomNummer(randomNumber);
        }
    }
}
//Oppgave: Gjett Tallet!

//Lag et program hvor brukeren skal gjette et tilfeldig tall mellom 1-100
//Hver gang brukeren skriver inn et tall vil man få svar fra programmet om man må høyere eller lavere,
//helt til man gjetter riktig tall. Da skal man få spørsmål om man vil spille på nytt

