using Microsoft.AspNetCore.Mvc;

namespace WebsiteFJW.Controllers
{
	public class MyAccountController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
