namespace kk
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Hva er temperaturen i grader?");
            var grader = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("[C] °C til °F");
            Console.WriteLine("[F] °F til °C");
            var gradertype = Console.ReadLine();

            var graderKonvertert = 0;

            switch (gradertype.ToUpper())
            {
                case "F":

                    graderKonvertert = (Convert.ToInt32(grader) - 32) * 5 / 9;
                    Console.WriteLine($"{grader} i °F blir {graderKonvertert} i °C");
                    break;

                case "C":
                    graderKonvertert = (Convert.ToInt32(grader) * 9 / 5) + 32;
                    Console.WriteLine($"{grader} i °C blir {graderKonvertert} i °F");
                    break;

            }
        }



        //static void IfVersjon() //stian
        //{
        //    Console.WriteLine("Hva er temperaturen i grader?");
        //    var grader = Console.ReadLine();
        //    Console.WriteLine("\n[C] °C til °F");
        //    Console.WriteLine("[F] °F til °C");
        //    var gradertype = Console.ReadLine().ToUpper();
        //    decimal graderKonvertert = 0;
        //    if (gradertype == "C")
        //        graderKonvertert = (Convert.ToInt32(grader) - 32) * 5 / 9;
        //    else if (gradertype == "F")
        //        graderKonvertert = (Convert.ToInt32(grader) * 9 / 5) + 32;
        //}



        //static void TerneryVersjon() // stian OG bittelittegranne chatgpt (ikke så mye, mest stian. Lover.) ¯\_(ツ)_/¯
        //{
        //    Console.WriteLine("Hva er temperaturen i grader?");
        //    var grader = Console.ReadLine();
        //    Console.WriteLine("\n[C] °C til °F\n[F] °F til °C");
        //    var gradertype = Console.ReadLine().ToUpper();

        //    decimal graderKonvertert = (gradertype == "C") ? (Convert.ToDecimal(grader) - 32) * 5 / 9 : (Convert.ToDecimal(grader) * 9 / 5) + 32;

        //    Console.WriteLine("Konvertert blir temperaturen: " + graderKonvertert);
        //}
    }
}


/*
En konsollapp hvor brukeren skal kunne konvertere mellom Celsius og Fahrenheit.
Programmet skal be brukeren først velge om h*n vil konvertere fra C til F eller fra F til C.
Deretter taste inn gradetallet, og få opp hva dette tallet er konvertert.
Formlene:
Temperature in degrees Fahrenheit   °F = (°C * 9/5) + 32
Temperature in degrees Celsius      °C = (°F - 32) * 5/9

 */