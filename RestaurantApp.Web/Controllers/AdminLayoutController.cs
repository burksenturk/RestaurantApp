using Microsoft.AspNetCore.Mvc;

namespace RestaurantApp.Web.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
