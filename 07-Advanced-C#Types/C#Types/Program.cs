var baseAddress = "https://datausa.io/api/";
var requestUri = "data?drilldowns=Nation&measures=Population";

IApiDataReader apiDataReader = new ApiDataReader();
var json = apiDataReader.Read(baseAddress, requestUri);
Console.ReadKey();

public interface IApiDataReader
{
    Task<string> Read(string baseAdress, string requestUri);
}

public class ApiDataReader : IApiDataReader
{
    public async Task<string> Read(string baseAdress, string requestUri)
    {

        using var client = new HttpClient();
        client.BaseAddress = new Uri(baseAdress);

        HttpResponseMessage response = await client.GetAsync(requestUri);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync();
    }
}