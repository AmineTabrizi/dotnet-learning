using Microsoft.AspNetCore.Mvc;
using ViewsExample.Models;

namespace ViewsExample.Controllers
{
    public class HomeController : Controller
    {
        [Route("home")]
        [Route("/")]
        public IActionResult Index()
        {
            ViewData["appTitle"] = "Asp.Net Core Demo App";
            
            List<Person> people = new List<Person>() {
            new Person() {Name = "Amin", DateOfBirth = null, PersonGender = Gender.Male},
            new Person() {Name = "mobin", DateOfBirth = DateTime.Parse("2003-01-3"), PersonGender = Gender.Female},      
            new Person() {Name = "Ali", DateOfBirth = null, PersonGender = Gender.Male},
        };
            // ViewData["people"] = people;
            ViewBag.people = people;
            return View();
        }
    }
}