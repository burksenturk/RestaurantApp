using Microsoft.AspNetCore.Mvc;

namespace RestaurantApp.Web.Controllers
{
    public class FeatureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
