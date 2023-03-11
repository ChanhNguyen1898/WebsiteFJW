using Microsoft.AspNetCore.Mvc;

namespace WebsiteFJW.Controllers
{
	public class EventsController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
