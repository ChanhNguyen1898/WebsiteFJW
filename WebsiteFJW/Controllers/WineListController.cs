using Microsoft.AspNetCore.Mvc;

namespace WebsiteFJW.Controllers
{
    public class WineListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
