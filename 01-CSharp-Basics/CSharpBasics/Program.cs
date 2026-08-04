for(int i = 0 ; i < 4; ++i)
{
    for(int j = 0; j < 3; ++j)
    {
        for(int k = 0; k < 5; ++k)
        {
            Console.WriteLine($"i is {i}, j is {j}, k is {k}");
        }
    }
}




// int userNumber;
// do
// {
//     Console.WriteLine("Enter a number larger than 10: ");
//     var userInput = Console.ReadLine();
//     if(userInput == "stop")
//     {
//         break;
//     }
//     bool isParsableToInt = userInput.All(char.IsDigit);
//     if (!isParsableToInt)
//     {
//         userNumber = 0;
//         continue;
//     }
//     userNumber = int.Parse(userInput);
// }while(userNumber <= 10);

// for(int i = 0 ; i < 20 ; i++)
// {
//     if(i % 3 == 0)
//     {
//         continue;
//     }
//     Console.WriteLine("i is: " + i);
// }


Console.WriteLine("The loop is finished.");














// Console.WriteLine("Hello!");
// Console.WriteLine("What do you want to do?");
// Console.WriteLine("[S]ee all ToDOs");
// Console.WriteLine("[A]dd a TODO");
// Console.WriteLine("[R]emove a TODO");
// Console.WriteLine("[E]xit");

// // Read lines from console and assigns it to the variable
// var userChoice = Console.ReadLine();

// switch (userChoice)
// {
//     case "S":
//         PrintSelectedOption("See all Todos");
//         break;
//     case "A":
//         PrintSelectedOption("Add a TODO");
//         break;
//     case "R":
//         PrintSelectedOption("Remove a TODO");
//         break;
//     case "E":
//         PrintSelectedOption("Exit");
//         break;
// }

// void PrintSelectedOption(string selectedOption)
// {
//     Console.WriteLine("Selected option: " + selectedOption);
// }


Console.ReadKey();



