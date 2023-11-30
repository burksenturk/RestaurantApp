using Microsoft.AspNetCore.Mvc;

namespace RestaurantApp.Web.ViewComponents.LayoutComponents
{
	public class _LayoutScriptComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
