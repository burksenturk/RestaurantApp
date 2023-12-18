using Microsoft.AspNetCore.Mvc;

namespace RestaurantApp.Web.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
