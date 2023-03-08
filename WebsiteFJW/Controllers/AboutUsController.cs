using Microsoft.AspNetCore.Mvc;

namespace WebsiteFJW.Controllers
{
	public class AboutUsController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
