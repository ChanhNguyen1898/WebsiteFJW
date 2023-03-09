using Microsoft.AspNetCore.Mvc;

namespace WebsiteFJW.Controllers
{
	public class ProductController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
