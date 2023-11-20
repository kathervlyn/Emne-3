namespace Switch_02
{
    internal class Program
    { 
        static void Main()
        {
            Console.WriteLine("Hvilken dag er det idag? Skriv et tall fra 1 - 7");
            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Mandag");
                    break;

                case "2":
                    Console.WriteLine("Tirsdag");
                    break;

                case "3":
                    Console.WriteLine("Onsdag");
                    break;

                case "4":
                    Console.WriteLine("Torsdag");
                    break;

                case "5":
                    Console.WriteLine("Fredag");
                    break;

                case "6":
                    Console.WriteLine("Lørdag");
                    break;

                case "7":
                    Console.WriteLine("Søndag");
                    break;

                default:
                    Console.WriteLine("Velg et tall mellom 1 - 7");
                    Main();
                    break;
            }
        }
    }
}
//Oppgave 2: 

//Ta utgangspunkt fra oppgave 1, men istedenfor å bruke en int med en fastsatt value,
//bruker du Console.ReadLine() for at man kan skrive inn et tall i konsollen.
//Hvis man ikke får inn et tall, skal switch-en kjøre programmet på nytt. 
//----------------------------------------------------------------

//Console.WriteLine("Hva er 2 + 2?");
//var input = Console.ReadLine();
//switch ("input")
//{
//    case "4":
//        Console.WriteLine("Riktig !");
//        break;

//    default:
//        Main();
//        break;
//}