    using Microsoft.AspNetCore.Mvc;

namespace RestaurantApp.Web.Controllers
{
    public class StatisticController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
