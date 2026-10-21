using Microsoft.AspNetCore.Mvc;
using ViewComponentsExample.Models;

namespace ViewComponentsExample.ViewComponents
{
    public class GridViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            PersonGridModel model = new PersonGridModel
            {
                GridTitle = "People Grid",
                People = new List<Person>
                {
                    new Person { PersonName = "John Doe", JobTitle = "Software Engineer" },
                    new Person { PersonName = "Jane Smith", JobTitle = "Project Manager" },
                    new Person { PersonName = "Alice Johnson", JobTitle = "UX Designer" }
                }
            };
            ViewBag.Grid = model;
            return View(model); //invoked a partial view
        }
    }
}