using Microsoft.AspNetCore.Mvc;

namespace WebsiteFJW.Controllers
{
	public class SinglePostController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
