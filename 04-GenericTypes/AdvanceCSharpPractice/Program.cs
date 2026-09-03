var numbers = new [] { 1, 2, 3, 4, 5 };

Console.WriteLine("Is Any Larger than 10??" + IsAny(numbers, n => n > 10));
Console.WriteLine("Is Any Even?" + IsAny(numbers, n => n % 2 == 0));

Console.ReadKey();


bool IsAny(IEnumerable<int> numbers, Func<int, bool> predicate)
{
    foreach (var number in numbers)
    {
        if (predicate(number))
        {
            return true;
        }
    }
    return false;
}   

