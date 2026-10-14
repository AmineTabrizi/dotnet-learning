using Microsoft.AspNetCore.Mvc;
using ControllersExample.Models;

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

        [Route("Person")]
        public JsonResult Person()
        {
            Person person = new Person()
            {
                Id = Guid.NewGuid(),
                FirstName = "John",
                LastName = "Doe",
                Age = 30
            };
            return new JsonResult(person);
        }
    }
}