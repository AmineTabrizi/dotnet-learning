using Microsoft.AspNetCore.Mvc;

namespace ControllersExample.Controllers
{
    public class HomeController
    {
        [Route("home")]
        [Route("/")]
        public string Index()
        {
            return "Hello From Index";
        }

        [Route("About")]
        public string About()
        {
            return "Hello From About";
        }

        [Route("contact-us/{mobile:regex(^\\d{{10}}$)}")]
        public string contact()
        {
            return "Hello From Contact";
        }
    }
}