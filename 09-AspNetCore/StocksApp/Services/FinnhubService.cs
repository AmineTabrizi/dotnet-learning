using System.Text.Json;
using StocksApp.ServiceContracts;

namespace StocksApp.Services
{
    public class FinnhubService: IFinnhubService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        public FinnhubService(IHttpClientFactory httpClientFactory, IConfiguration configuration)
        {
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
        }


        public async Task<Dictionary<string, object>?> GetStockPriceQuote(string stockSymbol)
        {
            using (HttpClient client = _httpClientFactory.CreateClient())
            {
                HttpRequestMessage httpresponse = new HttpRequestMessage()
                {
                    RequestUri = new Uri($"https://finnhub.io/api/v1/quote?symbol={stockSymbol}&token={_configuration["FinnhubToken"]}"),
                    Method = HttpMethod.Get
                };
                
                HttpResponseMessage result = await client.SendAsync(httpresponse);
                string response = await result.Content.ReadAsStringAsync();
                Dictionary<string, object>? responseDictionary = JsonSerializer.Deserialize<Dictionary<string, object>>(response);

                if(responseDictionary == null)
                    throw new InvalidOperationException("No response from finnhub"); 

                if(responseDictionary.ContainsKey("error"))
                    throw new InvalidOperationException(Convert.ToString(responseDictionary["error"]));
                return responseDictionary;
            }
        }

    
    }
}