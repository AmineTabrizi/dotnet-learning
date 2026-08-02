Console.WriteLine("Hello!");
Console.WriteLine("Input the First Number: ");
var number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Input the Second Number: ");
var number2 = int.Parse(Console.ReadLine());

Console.WriteLine("What do you want to do?");
Console.WriteLine("[A]dd numbers");
Console.WriteLine("[S]ubtract numbers");
Console.WriteLine("[M]ultiply numbers");
var userRespond = Console.ReadLine();

Calculate(number1, number2, userRespond);

void Calculate(int a, int b, string operation)
{
    if(EqualCaseInsensitive(operation, "A"))
    {
        Console.WriteLine($"{a} + {b} = {a + b}");
    }
    else if(EqualCaseInsensitive(operation, "S"))
    {
        Console.WriteLine($"{a} - {b} = {a - b}");
    }
    else if(EqualCaseInsensitive(operation, "M"))
    {
        Console.WriteLine($"{a} * {b} = {a * b}");
    }
    else
    {
        Console.WriteLine("Invalid Operation!");
    }
}
bool EqualCaseInsensitive(string left, string right)
{
    return left.ToUpper() == right.ToUpper();
}
Console.WriteLine("Press any key to close.");
Console.ReadKey();

