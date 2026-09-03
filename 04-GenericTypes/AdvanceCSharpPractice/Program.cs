using System.Diagnostics;

Stopwatch stopwatch = Stopwatch.StartNew();
var points = CreateCollectionOfRandomLength<int>(1000);
stopwatch.Stop();
Console.WriteLine($"Created {points.Count()} points in {stopwatch.ElapsedMilliseconds} ms.");

Console.ReadKey();


IEnumerable<T> CreateCollectionOfRandomLength<T> (int maxLength) where T : new()
{
    var length = 100000000;//new Random().Next(maxLength + 1);
    var result = new List<T>(length);

    for (int i = 0; i < length; ++i)
    {
        result.Add(new T());
    }

    return result;
}