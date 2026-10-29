namespace StocksApp.Services
{
    public class MyService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public MyService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task method()
        {
            using (HttpClient client = _httpClientFactory.CreateClient())
            {
                HttpRequestMessage httpresponse = new HttpRequestMessage()
                {
                    RequestUri = new Uri("https://finnhub.io/api/v1/quote?symbol=AAPL&token=dbhh1m1r01qjpoc7srmgdbhh1m1r01qjpoc7srn0"),
                    Method = HttpMethod.Get
                };
                
                HttpResponseMessage result = await client.SendAsync(httpresponse);
                Stream stream = result.Content.ReadAsStream();
                StreamReader reader = new StreamReader(stream);

                string response = reader.ReadToEnd();
            }

        }
    }
}