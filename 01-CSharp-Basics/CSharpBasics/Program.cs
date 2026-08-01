// string userInput = "A";
// Console.WriteLine(userInput);

// int number;
// number = 10;
// Console.WriteLine(number);

// string @class = "First";

// int firstNumber = 10;
// int secondNumber = 15;

// Console.WriteLine(firstNumber + secondNumber);
// Console.WriteLine(firstNumber - secondNumber);
// Console.WriteLine(firstNumber * secondNumber);
// Console.WriteLine(firstNumber / secondNumber);
// Console.WriteLine("Amin" + " " + "Tabrizi");
// string word = "aBC";
// Console.WriteLine(word + secondNumber);

// var word = "Amin";


Console.WriteLine("Hello!");
Console.WriteLine("What do you want to do?");
Console.WriteLine("[S]ee all ToDOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

// Read lines from console and assigns it to the variable
string userChoice = Console.ReadLine();
Console.WriteLine("User Input: " + userChoice);

bool isUserInputS = userChoice == "S";
bool isUserInputnotS = userChoice != "S";
bool isUserInputnotS2 = !(userChoice == "S");

var isEven = 10 % 2 == 0;

var number = 6;
var isEqualTo6OrLargerThan10orSmallerThan100 = number == 6 || number > 6 || number < 100;


Console.ReadKey();