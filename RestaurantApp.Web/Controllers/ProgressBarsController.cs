using Microsoft.AspNetCore.Mvc;

namespace RestaurantApp.Web.Controllers
{
    public class ProgressBarsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
