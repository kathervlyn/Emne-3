namespace Bossfight
{
    internal class Program
    {
        public static bool Running = true;
        public static List<GameCharacter> Fighters = new();

        static void Main()
        {
            Fighters.Add(new GameCharacter("Boss", 400, 10));
            Fighters.Add(new GameCharacter("Hero", 100, 40, 20));

            while (Running)
            {
                Console.Clear();
                Console.WriteLine("------- Menu -------\n" +
                              "[1] Fight\n" +
                              "[2] View fighter stats\n" +
                              "[3] Exit\n");
                var input = Console.ReadKey(true);
                switch (input.Key)
                {
                    case ConsoleKey.D1:
                        Start();
                        break;
                    case ConsoleKey.D2:
                        ViewFighters();
                        Console.ReadKey(true);
                        break;
                    case ConsoleKey.D3:
                        Running = false;
                        break;
                    default:
                        break;
                }
            }
            //(!users.Any(u => u.Name == friendName)) // lambda operatør
        }

        private static void Start()
        {
            var heroStarts = PrayToRNGesus();
            var combatants = Fighters.OrderBy(gc => gc.Name == (heroStarts ? "Hero" : "Boss") ? 0 : 1).Take(2).ToList(); //¯\_(ツ)_/¯

            while (combatants[0].Health > 0 || combatants[1].Health > 0)
            {
                Console.Clear();

                combatants[0].Fight(combatants[1]);
                Console.WriteLine();
                Thread.Sleep(1000);
                combatants[1].Fight(combatants[0]);
                Console.WriteLine("Press any key to go to the next turn");
                Console.ReadKey();
            }
            Console.WriteLine("Game Over!");
        }

        private static void ViewFighters()
        {
            foreach (GameCharacter gc in Fighters)
            {
                Console.WriteLine("=============================");
                Console.WriteLine($"Name:    {gc.Name}\n" +
                                  $"Health:  {gc.Health}\n" +
                                  $"Stamina: {gc.Stamina}\n" +
                                  $"Strength: {gc.Strength}\n");
            }
            Console.WriteLine("\n=============================");
            Console.WriteLine("\nPress any key to return to the menu.");
        }

        private static bool PrayToRNGesus()
        {
            Random rnd = new();
            var chance = rnd.Next(0, 100);
            if (chance > 50)
            {
                Console.WriteLine("Player attacks first");
                return true;
            }
            else
            {
                Console.WriteLine("Boss attacks first");
                return false;
            }
        }
    }
}
//Oppgave: Bossfight
    //Dere skal lage en konsoll app som viser en battle mellom en hero og en boss.
    //Skriv en klasse GameCharacter som har en metode Fight(), en metode Recharge() og følgende properties:
    //Health, Strength, Stamina
    //Program.cs filen må initialisere to objekter av denne klassen, en Hero og en Boss med følgende stats:
    //Hero:                      Boss:
    //Health: 100                Health: 400
    //Strength: 20               Strength: 0 - 30
    //Stamina: 40                Stamina: 10



//Disse to skal i kamp frem til en seirer (motstanderen sin health = 0) konsollen skal logge hvem som angriper,
//hvor mye skade som tas og hvor mye liv motstanderen har igjen etter slaget.

//I en fight mister GameCharacterene like mye i Health som mostanderen har i Strength.

//Hver gang en character bruker metoden Fight() mister de også 10 stamina.

//Om Fight() kalles med 0 i stamina må de bruke metoden Recharge() som restorer Stamina til det de hadde da de startet kampen.
//De rundene gamecharacterene må recharge får de ikke utført noe skade.

//Styrken til Bossen varierer med en random verdi mellom 0-30 for hver gang Fight() kalles.Om dette blir for avansert,
//la bossen også få en fast styrke på 20.

//Eksempel på Konsollens logg når programmet har kjørt ferdig:

//Enemy hit hero with 5 damage, hero now has 30 health left.
//Hero hit enemy with 20 damage, enemy has 0 health left.
//Hero is the winner!
//Lykke til smile


