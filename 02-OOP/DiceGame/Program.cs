var random = new Random();
var diceRollResult = random.Next(1, 7);
Console.WriteLine(diceRollResult);

Console.ReadKey();

class GuessingGame
{
    private readonly Dice _dice;
    private readonly ConsoleReader _consoleReader;
    private const int InitialTries = 3;
    public GuessingGame(Dice dice, ConsoleReader consoleReader)
    {
        _consoleReader = consoleReader;
        _dice = dice;
    }

    public void Play()
    {
        var diceRollResult = _dice.Roll();
        Console.WriteLine($"Dice rolled. Guess what number it shows in {InitialTries} tries.");

        var triesLeft = InitialTries;
        while(triesLeft > 0)
        {
            var guess = _consoleReader.ReadInteger("Enter a number: ");
            --triesLeft;
        }
    }

    
}

public class ConsoleReader
{
    public int ReadInteger(string message)
    {
        int result;
        do
        {
            Console.WriteLine(message);
        }
        while(!int.TryParse(Console.ReadLine(), out result));
        
        return result;
    }
}


class Dice
{
    private readonly Random _random;
    private const int SidesCount = 6;
    public Dice(Random random)
    {
        _random = random;
    }

    public int Roll() => _random.Next(1, SidesCount + 1);
    public void Describe() => Console.WriteLine($"This is a dice with {SidesCount} sides."); 
}