using Microsoft.AspNetCore.Mvc;
using ModelValidationsExample.Model;

namespace ModelValidationsExample.Controllers
{
    public class HomeController : Controller
    {
        [Route("register")]
        public IActionResult Index([Bind(nameof(Person.PersonName), 
        nameof(Person.Email), nameof(Person.Password), nameof(Person.ConfirmPassword))]Person person)
        {
            if (!ModelState.IsValid)
            {
                List<string> errorList = ModelState.Values.SelectMany(value => 
                value.Errors).Select(err => err.ErrorMessage).ToList();
                
                string errors = string.Join("\n", errorList);

                return BadRequest(errors);
            }
            return Content($"{person}");
        }
    }
}