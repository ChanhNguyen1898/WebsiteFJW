using Microsoft.AspNetCore.Mvc;

namespace WebsiteFJW.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
