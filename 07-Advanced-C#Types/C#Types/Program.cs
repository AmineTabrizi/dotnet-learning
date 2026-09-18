var evenNumbers = GenerateEvenNumbers();
foreach(var evenNumber in evenNumbers.Take(3))
{
    Console.WriteLine($"Number is {evenNumber}");
}

Console.ReadKey();

IEnumerable<int> GenerateEvenNumbers()
{
    for(int i = 0; i < int.MaxValue; i += 2)
    {
        Console.WriteLine($"Yielding {i}");
        yield return i;
    }
}