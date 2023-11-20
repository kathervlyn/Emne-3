namespace Loops
{
    internal class Program
    {
        static void Main()
        {
            //------------------------------------------------------------------------------------------------------------------------------
            //Oppgave 1
            //Lag en for-løkke som printer "Terje er kul" til konsollen 5 ganger

            Console.WriteLine("Oppgave 1");
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine(i + " Terje er kul");
            }

            //------------------------------------------------------------------------------------------------------------------------------
            //Oppgave 2
            //Lag en foreach-løkke som går igjennom hver bokstav i en string og printer den til konsollen.
            //Hint: en string kan brukes på samme måte som et array!

            Console.WriteLine();
            Console.WriteLine("Oppgave 2");
            string[] letterarray = { "a", "l", "e", "k", "s", "a", "n", "d", "e", "r" };
            foreach (var letter in letterarray)
            {
                Console.WriteLine(letter);
            }

            //------------------------------------------------------------------------------------------------------------------------------
            //Oppgave 3 
            //Lag en while-løkke som printer ut "Runde nummer:" + et tall som øker med 1 per runde, så lenge rundetelleren er mindre enn 10
            //Eks:
            //Runde nr 1
            //Runde nr 2
            //Runde nr 3

            Console.WriteLine();
            Console.WriteLine("Oppgave 3");
            bool shouldRun = true;
            int index = 1;
            while (shouldRun == true)
            {
                if (index > 9)
                {
                    shouldRun = false;
                }
                Console.WriteLine("Runde nr: " + index);
                index++;

                //------------------------------------------------------------------------------------------------------------------------------
            }
        }
    }
}
