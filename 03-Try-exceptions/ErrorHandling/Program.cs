var result = GetFirstElement(new int[0]);

Console.ReadKey();

int GetFirstElement(IEnumerable<int> numbers)
{
    foreach(var number in numbers)
    {
        return number;
    }
    throw new InvalidOperationException("The Collection can not be empty.");
     
}

bool IsFirstElementPositive(IEnumerable<int> numbers)
{
    try
    {
        var firstElement = GetFirstElement(numbers);
        return firstElement > 0;
    }
    catch(InvalidOperationException ex)
    {
        Console.WriteLine("The Collection is empty!");
        return true;
    }
    catch(NullReferenceException ex)
    {
        throw new ArgumentNullException("The collection is null!", ex);
    }

}