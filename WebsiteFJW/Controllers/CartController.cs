using Microsoft.AspNetCore.Mvc;

namespace WebsiteFJW.Controllers
{
	public class CartController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
