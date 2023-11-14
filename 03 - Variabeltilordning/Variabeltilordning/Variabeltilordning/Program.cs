namespace Variabeltilordning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tall1 = 4;
            int tall2 = 8;
            int sum = ReturnNummer(tall1, tall2);
            Console.WriteLine($"{tall1} + {tall2} = {sum}");
            ReturnString();
        }

        static int ReturnNummer(int nummer1, int nummer2)
        {
            int sum = nummer1 + nummer2;
            return sum;
        }

        static void ReturnString()
        {
            Console.WriteLine("Denne metoden returnerer ingenting");
        }
    }
}
//Oppgave 1:
//Lag en metode som tar inn og returnerer summen av to tall

//Kan jeg ta ReadLine + tall? eller går ikke det?
//-----------------------------------------------------------
//Oppgave 2:
//Lag en metode skal printe setningen "Denne metoden returnerer ingenting" til konsollen.
//Denne metoden skal altså ikke returnere noe verdi ;)