using Microsoft.AspNetCore.Mvc;

namespace ConfigurationExample.Controllers
{
    public class HomeController : Controller
    {
        // private field
        private readonly IConfiguration _configuration;

        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }


        [Route("/")]
        public IActionResult Index()
        {
            WeatherApiOptions options = _configuration.GetSection("weatherapi").Get<WeatherApiOptions>();

            ViewBag.ClientID = options.ClientID;
            ViewBag.ClientSecret = options.ClientSecret;
            
            return View(); 
        }
    }
}