using Microsoft.AspNetCore.Mvc;

namespace WebsiteFJW.Controllers
{
	public class ShopController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
