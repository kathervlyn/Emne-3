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

        static int ReturnNummer(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        static void ReturnString()
        {
            Console.WriteLine("Denne metoden returnerer ingenting");
        }
    }
}