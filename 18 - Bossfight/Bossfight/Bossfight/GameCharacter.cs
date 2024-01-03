namespace Bossfight;

public class GameCharacter
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Strength { get; set; }
    public int Stamina { get; set; }
    public int MaxStamina { get; set; }

    /// <summary>
    /// Creates a new instance of a character
    /// </summary>
    /// <param name="health">How much health should the character have?</param>
    /// <param name="stamina">How much stamina should the character have?</param>
    /// <param name="strength">What is the strength of the character? Defaults to -1 and sets a random strength if not provided.</param>
    /// <param name="maxRndStrength">The maximum value of the randomly determined strength</param>
    /// <param name="minRndStrength">The minimum value of the randomly determined strength</param>
    public GameCharacter(string name, int health, int stamina, int strength = -1, int maxRndStrength = 30, int minRndStrength = 0)
    {
        Name = name;
        Health = health;
        Stamina = stamina;
        MaxStamina = stamina;
        if (strength == -1) Strength = RndStrength(minRndStrength, maxRndStrength);
        else Strength = strength;
    }

    public void Fight(GameCharacter opponent)
    {
        if (Stamina < 10)
        {
            Recharge();
            return;
        }
        opponent.Health -= Strength;
        Stamina -= 10;
        Console.WriteLine($"{Name} attacks {opponent.Name}, and deals {Strength} points of damage. {Name} has {Stamina} stamina remaining\n" +
            $"{opponent.Name} has {opponent.Health} health remaining.");
    }

    public void Recharge()
    {
        Console.WriteLine($"{Name} is taking a break to recharge their Stamina...");
        Stamina = MaxStamina;
    }

    private int RndStrength(int minStrength, int maxStrength) 
    {
        Random rng = new();
        return rng.Next(minStrength, maxStrength);
    }
}