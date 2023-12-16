using Microsoft.AspNetCore.Mvc;

namespace RestaurantApp.Web.Controllers
{
    public class SignalRDefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
