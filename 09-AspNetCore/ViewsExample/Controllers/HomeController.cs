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
            
            return View("Index", people);
        }

        [Route("person-details/{name}")]
        public IActionResult Details(string? name)
        {
            if(name == null)
            {
                return Content("Person name con't be null");
            }

            List<Person> people = new List<Person>() {
            new Person() {Name = "Amin", DateOfBirth = null, PersonGender = Gender.Male},
            new Person() {Name = "mobin", DateOfBirth = DateTime.Parse("2003-01-3"), PersonGender = Gender.Female},      
            new Person() {Name = "Ali", DateOfBirth = null, PersonGender = Gender.Male},
        };
        Person? matchingPerson = people.Where(temp => temp.Name == name).FirstOrDefault();
        return View(matchingPerson); //Views/Home/Details.cshtml
        }

        [Route("person-with-product")]
        public IActionResult PersonWithProduct()
        {
            Person person = new Person() 
            {Name = "Amin", DateOfBirth = Convert.ToDateTime("2007-05-05"), PersonGender = Gender.Male};

            Product product = new Product() {ProductId = 1, ProductName = "Keyboard"};

            PersonWithProductWrapperModel personWithProductWrapperModel = new PersonWithProductWrapperModel() {PersonData = person, 
            ProductData = product };
            
            return View("PersonWithProduct", personWithProductWrapperModel);
        }
    }
}