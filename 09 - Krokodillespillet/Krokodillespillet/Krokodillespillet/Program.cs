using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Threading.Channels;

namespace Krokodillespillet
{
    internal class Program
    {
        static void Main()
        {
            Random rand = new Random();
            int Point = 0;
            string Awnser;
            Console.WriteLine("Use <, > or = ");

            while (true)
            {
                int randomNumber1 = rand.Next(1, 11);
                int randomNumber2 = rand.Next(1, 11);
                Console.WriteLine(randomNumber1 + " _ " + randomNumber2);


                Awnser = Console.ReadLine();
                if ((Awnser == "<" && randomNumber1 < randomNumber2) || (Awnser == ">" && randomNumber1 > randomNumber2) || (Awnser == "=" && randomNumber1 == randomNumber2))
                {
                    Console.WriteLine("Rigtig !");
                    Point++;
                }
                else
                {
                    Console.WriteLine("Feil !");
                }

                Console.WriteLine("Poeng: " + Point);
                if (Awnser != "<" && Awnser != ">" && Awnser != "=")
                {
                    Console.WriteLine("Du svarte feil, din poengsum er " + Point);
                    return;
                }

                //if (Point == 10)
                //{
                //    Console.WriteLine("Du har vunnet !");
                //    return;
                //}
            }
        }
    }
}
//Du skal bruke det du har lært til å programmere “krokodille spillet”.

//For hver runde skal det printes ut til skjermen et random tall mellom 1-11,
//et mellomrom og et nytt tall mellom 1-11 med en underscore mellom slik at det ser sånn ut: 3 _ 5



//Brukeren kan skrive inn <, > eller =
//    i tilfellet brukeren får 3 _ 5 vil svaret være <, altså 3 < 5

//    Tallene må sjekkes om det første er større eller mindre eller lik det andre tallet,
//    Det må verifiseres om brukeren har valgt riktig alternativ.
//    Brukeren får et poeng per riktig svar, og mister et poeng per feil svar.
//    Poengsummen printes til skjermen for hvert svar brukeren har gitt.
//    Spillet avsluttes når brukeren skriver inn noe annet enn de tre alternativene
