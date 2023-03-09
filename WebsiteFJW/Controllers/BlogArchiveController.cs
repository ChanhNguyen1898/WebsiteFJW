using Microsoft.AspNetCore.Mvc;

namespace WebsiteFJW.Controllers
{
	public class BlogArchiveController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
