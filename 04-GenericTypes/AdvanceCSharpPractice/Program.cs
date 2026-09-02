
// var points = CreateCollectionOfRandomLength<Point>(1000);
var points = CreateCollectionOfRandomLength<int>(1000);


Console.ReadKey();


IEnumerable<T> CreateCollectionOfRandomLength<T> (int maxLength) where T : new()
{
    var length = new Random().Next(maxLength + 1);
    var result = new List<T>();

    for (int i = 0; i < length; ++i)
    {
        result.Add(new T());
    }

    return result;
}