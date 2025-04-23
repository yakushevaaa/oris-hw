using Microsoft.AspNetCore.Mvc;

namespace Socialite.Controllers
{
    public class PagesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
