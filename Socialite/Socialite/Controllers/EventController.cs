using Microsoft.AspNetCore.Mvc;

namespace Socialite.Controllers
{
    public class EventController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
