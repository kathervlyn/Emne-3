namespace if_else
{
    internal class Program
    {
        public static void Main()
        {
            int number = 5;
            int number2 = 5;
            bool isEqual = false;

            if (number == number2)
            {
                isEqual = true;
                Console.WriteLine($"combined the equal number is {number + number2}");
            }
            else
            {
                isEqual = false;
                Console.WriteLine($"{number} and {number2} are not equal");
            }
            Console.WriteLine(IfTheNumbersAreThirty(10, 30));
        }
        public static bool IfTheNumbersAreThirty(int nnbr1, int nnbr2)
        {
            if (nnbr1 == 30 || nnbr2 == 30)
            {
                Console.Write("ett av tallene er \"30\". Dermed rertuneres => ");
                return true;
            }
            else if (nnbr1 + nnbr2 == 30)
            {
                Console.Write("Summen av tallene blir \"30\". Dermed rertuneres => ");
                return true;
            }
            else
            {
                Console.Write("Ingen av tallene er \"30\". Summen av tallene (Multiplisert) blir ikke \"30\". Dermet returneres =>");
                return false;
            }
        }
    }
}
//Oppgaver om conditions - if/else

//Oppgave 1: 
//Lag en metode som tar imot to tall og returnerer true dersom tallene er like. 

//--------------------------------------------------------------------------------------
//Oppgave 2: 
//
//Lag en metode som tar imot to tall og returnerer summen av tallene dersom de er ulike,
//og returnerer tallene multiplisert med hverandre dersom de er like

//--------------------------------------------------------------------------------------
//Oppgave 3:
//Lag en metode som tar inn to int verdier. Dersom en av de, eller summen til int verdiene blir 30,
//skal metoden returnere true. Ellers returnerer metoden false