
Console.WriteLine("Enter a number: ");

var input = Console.ReadLine();
try
{
    int number = ParseStringToInt(input);
    var result = 10 / number;
    Console.WriteLine($"10 / {number} is " + result);
}
catch(FormatException ex)
{
    Console.WriteLine("Wrong Format. Input string is not parsable to int. Exception Message: " + ex.Message);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Can not devide to 0." + ex.Message) ;
}
finally
{
    Console.WriteLine("Finally block is being executed.");
}
Console.ReadKey();

int ParseStringToInt(string input)
{
    return int.Parse(input);
    
}