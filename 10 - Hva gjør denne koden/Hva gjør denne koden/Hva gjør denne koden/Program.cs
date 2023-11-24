namespace Hva_gjør_denne_koden
{
    internal class Program
    {
        private static void Main()
        {
            string text = string.Empty;
            Console.WriteLine("Skriv inn teksten din:\n");
            while (string.IsNullOrWhiteSpace(text))
            {
                text = Console.ReadLine()!;
            }

            var range = 250;
            var emptyArry = new int[range];

            var counts = TellTall(text, range, emptyArry);
            ProsentAvBokstavene(text, counts);
            //RightAdjusted(text, counts);
        }
        private static int[] TellTall(string text, int range, int[] counts)
        {
            foreach (var character in text ?? string.Empty)
            {
                var lower = char.ToLower(character);
                counts[(int)lower]++;
            }

            Console.WriteLine("\nAntall av hver bokstav:\n");
            for (var i = 0; i < range; i++)
            {
                if (counts[i] > 0)
                {
                    var character = (char)i;
                    Console.WriteLine(character + " - " + counts[i]);
                }
            }

            return counts;
        }

        private static void ProsentAvBokstavene(string text, int[] counts)
        {
            var total = text.Length;
            foreach (var character in text ?? string.Empty)
            {
                var lower = char.ToLower(character);
                var lowerCount = counts[lower];
                decimal percent = (decimal)lowerCount / total * 100;
                string formattedPercent = percent.ToString("F2"); //ikke spør...      Fixed point - 2 desimaler

                Console.WriteLine($"{character}: {formattedPercent}%");
            }
        }


        //------------------------------------------------------------------------------------------------------------------------------
        //Knønte ikke oseen jeg skulle gjøre dette
        //Teksten under er ChatGPT  ⬇


        //private static void RightAdjusted(string text, int[] counts)
        //{
        //    int totalLetters = 0;

        //    for (int i = 0; i < counts.Length; i++) // Add a loop to iterate over counts
        //    {
        //        totalLetters += counts[i];

        //        if (counts[i] > 0)
        //        {
        //            var character = (char)i;
        //            var percentage = 100 * (double)counts[i] / totalLetters;
        //            string output = character + " - " + percentage.ToString("F2") + "%";
        //            Console.CursorLeft = Console.BufferWidth - output.Length - 1;
        //            Console.WriteLine(output);
        //        }
        //    }
        //}
        //------------------------------------------------------------------------------------------------------------------------------
    }
}
//Oppgave: Hva gjør denne koden?
//    Start Visual Studio og lag et nytt prosjekt "Console App" 

//Legg inn koden under og finn ut hva den gjør. 

//    var range = 250;
//var counts = new int[range];
//string text = "something";
//while (!string.IsNullOrWhiteSpace(text))
//{
//    text = Console.ReadLine();
//    foreach (var character in text ?? string.Empty)
//    {
//        counts[(int)character]++;
//    }
//    for (var i = 0; i < range; i++)
//    {
//        if (counts[i] > 0)
//        {
//            var character = (char)i;
//            Console.WriteLine(character + " - " + counts[i]);
//        }
//    }
//}

//3.Endre det så det håndterer store og små bokstaver likt (bruk google/stackoverflow.com)

//4.Tell i prosent

//5. Skriv ut tall høyrejustert, se eksempel:

//       1
//      20
//     300
//     hei
//      på
//     deg
// 10.000%