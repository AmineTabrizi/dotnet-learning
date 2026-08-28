var result = GetFirstElement(new int[0]);

Console.ReadKey();

int GetFirstElement(IEnumerable<int> numbers)
{
    foreach(var number in numbers)
    {
        return number;
    }
    throw new Exception("The Collection can not be empty.");
     
}