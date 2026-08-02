
Console.WriteLine("Provide a number.");
string userInput = Console.ReadLine();
int number = int.Parse(userInput);
Console.WriteLine(number);

// Console.WriteLine("Hello!");
// Console.WriteLine("What do you want to do?");
// Console.WriteLine("[S]ee all ToDOs");
// Console.WriteLine("[A]dd a TODO");
// Console.WriteLine("[R]emove a TODO");
// Console.WriteLine("[E]xit");


// Read lines from console and assigns it to the variable
var userChoice = Console.ReadLine();

bool isLong = IsLong(userChoice);

var result = Add(10, 20);
Console.WriteLine("10 + 20= " + result);
// if (userChoice == "S")
// {
//     PrintSelectedOption("See all TODOs");
// }
// else if(userChoice == "A")
// {
//     PrintSelectedOption("Add a TODO");
// }
// else if(userChoice == "R")
// {
//     PrintSelectedOption("Remove a TODO");
// }
// else if(userChoice == "E")
// {
//     PrintSelectedOption("Exit");
// }

Console.ReadKey();

// void PrintSelectedOption(string selectedOption)
// {
//     Console.WriteLine("Selected option: " + selectedOption);
// }

int Add(int a, int b)
{
    return a + b;
}

bool IsLong(string input)
{
    return input.Length > 10;
}