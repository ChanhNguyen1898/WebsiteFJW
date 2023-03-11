using Microsoft.AspNetCore.Mvc;

namespace WebsiteFJW.Controllers
{
	public class EventController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
