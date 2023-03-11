using Microsoft.AspNetCore.Mvc;

namespace WebsiteFJW.Controllers
{
	public class PortfolioController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
