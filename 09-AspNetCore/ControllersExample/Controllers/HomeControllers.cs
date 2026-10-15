using Microsoft.AspNetCore.Mvc;
using ControllersExample.Models;

namespace ControllersExample.Controllers
{
    public class HomeController : Controller
    {
        [Route("home")]
        [Route("/")]
        public string Index()
        {
            return "Hello From Index";
        }

        [Route("bookstore")]
        public IActionResult StoreBooks([FromQuery] int? bookid, bool? isloggedin, Book book)
        {
            if (bookid.HasValue == false)
            {
                return BadRequest("Missing bookid query parameter");
            }
            if(isloggedin == false)
            {
                return Unauthorized("User does not authorized yet!");
            }
            
            // return new RedirectToActionResult("Books", "Store", new { id = bookId }, true);
            // return RedirectToAction("Books", "Store", new { id = bookId });
            return RedirectToActionPermanent("Books", "Store", new { id = bookid});
        }
    }
}