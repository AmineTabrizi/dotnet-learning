var numbers = new List<int> {3, 5, 11, 2, 9, 14};

Tuple<int, int> minAndMax = GetMinAndMax(numbers);
Console.WriteLine("Smallest number is: " + minAndMax.Item1);
Console.WriteLine("Largest number is: " + minAndMax.Item2);
Console.ReadKey();

Tuple<int, int> GetMinAndMax(IEnumerable<int> input)
{
    if (!input.Any())
    {
        throw new InvalidOperationException($"The input collection can not be empty.");
    }
    int min = input.First();
    int max = input.First();

    foreach(var number in input)
    {
        if(number > max)
        {
            max = number;
        }
        if(number < min)
        {
            min = number;
        }
    }
    return new Tuple<int, int>(min, max);
}

public class Tuple<T1, T2>
{
    public T1 Item1 {get; }
    public T2 Item2 {get; }
    public Tuple(T1 item1, T2 item2)
    {
        Item1 = item1;
        Item2 = item2;
    }

}