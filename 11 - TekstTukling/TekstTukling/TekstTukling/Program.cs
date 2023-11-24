using System.Runtime.InteropServices;

namespace TekstTukling
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Velg enter 1, 2 eller 3");
            Console.WriteLine("1 = roter teksten");
            Console.WriteLine("2 = Endre ord");
            Console.WriteLine("3 = Exit");

            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Skriv in teksten du vil rotere: ");
                    string textToRotate = Console.ReadLine();
                    string rotatedText = RotateText(textToRotate);
                    Console.WriteLine($"Rotert tekst: {rotatedText}");
                    break;

                case "2":
                    Console.WriteLine("Skriv inn teksten du vil endre:");
                    string textToChange = Console.ReadLine();
                    string changedText = ChangeWord(textToChange);
                    Console.WriteLine($"Endret Tekst: {changedText}");
                    break;

                case "3":
                    Console.WriteLine("Progammet Avsluttes.");
                    return;
                    break;

                default:
                    Console.WriteLine("Skriv inn en gyldig komando");
                    Main();
                    break;
            }
        }

        static string RotateText(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        static string ChangeWord(string input)
        {
            return input.Replace('e', 'a');
        }
    }
}
//Lag et enkelt kommandobasert program med følgende meny: 

//1.RotateText

//2.Change word

//    Etter brukeren har valgt 1 eller to skal de promptes for å skrive inn et ord. Ordet skal ta enten snus eller endres med følgende funksjoner

//1 -> En funksjon som tar en tekst som parameter og som returnerer teksten snudd i motsatt rekkefølge. For eksempel skal 'Terje' bli til 'ejreT.

//2 -> En funksjon som bytter ut alle 'e' med 'a' i tekst du sender inn