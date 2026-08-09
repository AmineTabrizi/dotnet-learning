var allTodos = new List<string>();
string userChoice;
bool isTrue = true;
do
{
    Console.Clear();
    Console.WriteLine("Hello!");
    Console.WriteLine();

    Console.WriteLine("What do you want to do?");
    Console.WriteLine("[S]ee all ToDOs");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");

    userChoice = Console.ReadLine();
    switch (userChoice)
    {
        case "S":
        case "s":
            for(int i = 0; i < allTodos.Count ; i++)
            {
                Console.WriteLine($"{i + 1}. {allTodos[i]}");
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            break;
        
        case "A":
        case "a":
            AddTodo();
            break;
        
        case "R":
        case "r":
            if (allTodos.Count == 0)
            {
                Console.WriteLine("There are no TODOs to remove.");
            }
            else
            {
                for(int i = 0; i < allTodos.Count ; i++)
                {
                    Console.WriteLine($"{i + 1}. {allTodos[i]}");
                }
                Console.WriteLine();
                Console.Write("Which Todo you want to remove?");
                
                var input = Console.ReadLine();
                if (int.TryParse(input, out int index))
                {
                if (index >= 1 && index <= allTodos.Count)
                {
                    allTodos.RemoveAt(index - 1);
                    Console.WriteLine("Todo Removed Succesfully.");
                }
                else
                {
                Console.WriteLine("Invalid Todo Number.");
                }
                }
                else
                {
                    Console.WriteLine("Please Enter a Valid Number!");
                }
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
            
            }
            break;
        
        case "E":
        case "e":
            Console.WriteLine("Goodbye");
            isTrue = false;
            break;
        

    }
    

}while(isTrue == true);

void AddTodo()
{   
    Console.WriteLine("Enter the TODO description: ");
    var description = Console.ReadLine();

    if(description == "")
    {
        Console.WriteLine("The description can not be Empty!");
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
    }
    else if (allTodos.Contains(description))
    {
        Console.WriteLine("The description must be unique.");
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
    }
    else
    {
        allTodos.Add(description);
        Console.WriteLine($"'{description}' added Succefully.");
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
    }
}