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
        public IActionResult StoreBooks()
        {
            if (!Request.Query.ContainsKey("bookid"))
            {
                return BadRequest("Missing bookid query parameter");
            }
            int bookId = Convert.ToInt32(Request.Query["bookid"]);
            
            // return new RedirectToActionResult("Books", "Store", new { id = bookId }, true);
            // return RedirectToAction("Books", "Store", new { id = bookId });
            return RedirectToActionPermanent("Books", "Store", new { id = bookId });
        }
    }
}