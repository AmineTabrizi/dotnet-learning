bool isParsingSuccesful;
do
{
    Console.WriteLine("Enter a number: ");
    var userInput = Console.ReadLine();
    isParsingSuccesful = int.TryParse(userInput, out int number);
    if (isParsingSuccesful)
    {
        Console.WriteLine("Parsing worked and number is: " + number);
    }
    else
    {
        Console.WriteLine("Parsing was not worked succesfully.");
    }
}while(!isParsingSuccesful);
