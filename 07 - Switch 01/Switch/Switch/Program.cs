using System.Runtime.InteropServices;
using System.Threading.Channels;

namespace Switch
{
    internal class Program
    {
        static void Main()
        {
            Random rand = new Random();
            int randomNumber = rand.Next(1, 8);

            switch (randomNumber)
            {
                case 1:
                    Console.WriteLine("Mandag");
                    break;

                case 2:
                    Console.WriteLine("Tirsdag");
                    break;

                case 3:
                    Console.WriteLine("Onsdag");
                    break;

                case 4:
                    Console.WriteLine("Torsdag");
                    break;

                case 5:
                    Console.WriteLine("Fredag");
                    break;

                case 6:
                    Console.WriteLine("Lørdag");
                    break;

                case 7:
                    Console.WriteLine("Søndag");
                    break;

                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }
}
//Oppgave 1: 

//Ha en variabel med datatypen int og gi den en value med et tall mellom1 og 7. 
//Bruk en switch for å finne ut hvilken dag i uken det tallet er, og print ut dagen med Console.WriteLine();
//Eksempel:
//1 er mandag, 2 er tirsdag, osv. 

//----------------------------------------------------------------
//Oppgave 2: 

//Ta utgangspunkt fra oppgave 1, men istedenfor å bruke en int med en fastsatt value,
//bruker du Console.ReadLine() for at man kan skrive inn et tall i konsollen.
//Hvis man ikke får inn et tall, skal switch-en kjøre programmet på nytt. 

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