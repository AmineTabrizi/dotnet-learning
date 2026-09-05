IDataDownloader dataDownloader = new CachingDataDownloader(new SlowDataDownloader());

Console.WriteLine(dataDownloader.DownloadData("Resource1"));
Console.WriteLine(dataDownloader.DownloadData("Resource2"));
Console.WriteLine(dataDownloader.DownloadData("Resource3"));
Console.WriteLine(dataDownloader.DownloadData("Resource1"));
Console.WriteLine(dataDownloader.DownloadData("Resource3"));
Console.WriteLine(dataDownloader.DownloadData("Resource2"));
Console.WriteLine(dataDownloader.DownloadData("Resource1"));


Console.ReadKey();

public class Cache<Tkey, TValue>
{
    private readonly Dictionary<Tkey, TValue> _storage = new ();

    public TValue Get(Tkey key, Func<Tkey, TValue> getForTheFirstTime)
    {
        if (!_storage.ContainsKey(key))
        {
            _storage[key] = getForTheFirstTime(key);
        }
        return _storage[key];
    }
}
public class CachingDataDownloader : IDataDownloader
{
    private readonly IDataDownloader _dataDownloader;
    private readonly Cache<string, string> _cache = new();

    public CachingDataDownloader(IDataDownloader dataDownloader)
    {
        _dataDownloader = dataDownloader;
    }

    public string DownloadData(string resourceId)
    {
        return _cache.Get(resourceId, _dataDownloader.DownloadData);
    }
}


public interface IDataDownloader
{
    string DownloadData(string resourceId);
}

public class SlowDataDownloader : IDataDownloader
{
    public string DownloadData(string resourceId)
    {
        // Simulate a slow download operation
        Thread.Sleep(1000);
        return $"Data for {resourceId}";
    }
}
